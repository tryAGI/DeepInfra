using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

var openApiDocument = yamlOrJson.GetOpenApiDocument(Settings.Default);

if (openApiDocument.Components?.Schemas?.TryGetValue("TimeInterval", out var timeIntervalSchema) == true
    && timeIntervalSchema is OpenApiSchema timeInterval)
{
    if (timeInterval.Properties?.TryGetValue("to", out var toProp) == true
        && toProp is OpenApiSchema toSchema)
    {
        toSchema.Format = "int64";
        if (toSchema.Default is JsonValue defaultValue
            && defaultValue.ToString() is { } defaultStr
            && long.TryParse(defaultStr, out var to))
        {
            toSchema.Default = JsonValue.Create(to);
        }
    }
}

if (openApiDocument.Components?.Schemas?.TryGetValue("DeploymentOut", out var deploymentOutSchema) == true
    && deploymentOutSchema is OpenApiSchema deploymentOut)
{
    if (deploymentOut.Properties?.TryGetValue("type", out var typeProp) == true
        && typeProp is OpenApiSchema typeSchema)
    {
        typeSchema.Default = null;
    }
}

if (openApiDocument.Components?.Schemas?.TryGetValue("DeployModelIn", out var deployModelInSchema) == true
    && deployModelInSchema is OpenApiSchema deployModelIn)
{
    if (deployModelIn.Properties?.TryGetValue("provider", out var providerProp) == true
        && providerProp is OpenApiSchema providerSchema)
    {
        providerSchema.Default = null;
    }
}

if (openApiDocument.Components?.Schemas?.TryGetValue("OpenAITextToSpeechIn", out var ttsSchema) == true
    && ttsSchema is OpenApiSchema tts)
{
    if (tts.Properties?.TryGetValue("voice", out var voiceProp) == true
        && voiceProp is OpenApiSchema voiceSchema)
    {
        voiceSchema.Default = null;
    }
    if (tts.Properties?.TryGetValue("response_format", out var formatProp) == true
        && formatProp is OpenApiSchema formatSchema)
    {
        formatSchema.Default = null;
    }
}

yamlOrJson = await openApiDocument.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2);

await File.WriteAllTextAsync(path, yamlOrJson);
