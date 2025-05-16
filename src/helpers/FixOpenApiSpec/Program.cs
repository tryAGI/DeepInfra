using AutoSDK.Helpers;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var jsonOrYaml = await File.ReadAllTextAsync(path);

if (OpenApi31Support.IsOpenApi31(jsonOrYaml))
{
    jsonOrYaml = OpenApi31Support.ConvertToOpenApi30(jsonOrYaml);
}

var openApiDocument = new OpenApiStringReader().Read(jsonOrYaml, out var diagnostics);

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

jsonOrYaml = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(jsonOrYaml, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, jsonOrYaml);