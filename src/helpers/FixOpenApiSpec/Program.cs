using Microsoft.OpenApi;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Readers;

var path = args[0];
var text = await File.ReadAllTextAsync(path);

text = text.Replace("\"exclusiveMaximum\":1000.0", "\"exclusiveMinimum\":false");
text = text.Replace("\"exclusiveMinimum\": 0.0", "\"exclusiveMinimum\": false");
text = text.Replace("\"exclusiveMinimum\":0.0", "\"exclusiveMinimum\":false");
text = text.Replace("\"type\":\"String\"", "\"type\":\"string\"");

var openApiDocument = new OpenApiStringReader().Read(text, out var diagnostics);

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