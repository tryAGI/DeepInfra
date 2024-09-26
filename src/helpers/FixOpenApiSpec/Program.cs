using System.Text.RegularExpressions;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var text = await File.ReadAllTextAsync(path);

text = text.Replace("\"type\":\"String\"", "\"type\":\"string\"");

// Replace string like this `,"exclusiveMaximum":9.223372036854776e+18` to `,"maximum":9.223372036854776e+18, "exclusiveMaximum":true`
// and this `,"exclusiveMaximum":1000.0` to `,"maximum":1000.0, "exclusiveMaximum":true`
// only maximum
Regex exclusiveMaximumRegex = new(@",\s*""exclusiveMaximum"":(?<value>\d+(\.\d+)?(e\+\d+)?)", RegexOptions.Compiled);
text = exclusiveMaximumRegex.Replace(text, @", ""maximum"":${value}, ""exclusiveMaximum"":true");
Regex exclusiveMinimumRegex = new(@",\s*""exclusiveMinimum"":(?<value>\d+(\.\d+)?(e\+\d+)?)", RegexOptions.Compiled);
text = exclusiveMinimumRegex.Replace(text, @", ""minimum"":${value}, ""exclusiveMinimum"":true");

var openApiDocument = new OpenApiStringReader().Read(text, out var diagnostics);

openApiDocument.Servers.Add(new OpenApiServer
{
    Url = "https://api.deepinfra.com/",
});

openApiDocument.Components.SecuritySchemes.Add("Bearer", new OpenApiSecurityScheme
{
    Type = SecuritySchemeType.Http,
    Scheme = "bearer",
});
openApiDocument.SecurityRequirements.Add(new OpenApiSecurityRequirement
{
    [new OpenApiSecurityScheme
    {
        Reference = new OpenApiReference
        {
            Id = "Bearer",
            Type = ReferenceType.SecurityScheme
        }
    }] = new List<string>(),
});

openApiDocument.Components.Schemas["TimeInterval"]!.Properties["to"].Format = "int64";
if (long.TryParse(
    (openApiDocument.Components.Schemas["TimeInterval"]!.Properties["to"].Default as OpenApiString)?.Value ?? string.Empty,
    out var to))
{
    openApiDocument.Components.Schemas["TimeInterval"]!.Properties["to"].Default = new OpenApiLong(to);
}
openApiDocument.Components.Schemas["DeploymentOut"]!.Properties["type"].Default = null;
openApiDocument.Components.Schemas["DeployModelIn"]!.Properties["provider"].Default = null;
openApiDocument.Components.Schemas["OpenAITextToSpeechIn"]!.Properties["voice"].Default = null;
openApiDocument.Components.Schemas["OpenAITextToSpeechIn"]!.Properties["response_format"].Default = null;

text = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(text, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, text);