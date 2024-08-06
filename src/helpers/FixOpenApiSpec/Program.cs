using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Readers;

var path = args[0];
var text = await File.ReadAllTextAsync(path);

// text = text.Replace("description: *run_temperature_description", "description: empty");
// text = text.Replace("description: &run_temperature_description ", "description: ");
//
// text = text.Replace("description: *run_top_p_description", "description: empty");
// text = text.Replace("description: &run_top_p_description ", "description: ");

text = text.Replace("\"exclusiveMinimum\": 0.0", "\"exclusiveMinimum\": false");
text = text.Replace("\"exclusiveMinimum\":0.0", "\"exclusiveMinimum\":false");
text = text.Replace("\"type\":\"String\"", "\"type\":\"string\"");

var openApiDocument = new OpenApiStringReader().Read(text, out var diagnostics);
// openApiDocument.Components.Schemas["ParallelToolCalls"]!.Default = null;
// openApiDocument.Components.Schemas["ParallelToolCalls"]!.Nullable = true;
//
// openApiDocument.Components.Schemas["CreateEmbeddingRequest"]!.Properties["dimensions"].Nullable = true;
//
// openApiDocument.Components.Schemas["CreateChatCompletionResponse"]!.Properties["choices"].Items.Required.Remove("logprobs");
//     
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