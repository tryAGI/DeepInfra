
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// The format in which the generated images are returned: 'b64_json' (default) or 'url'. For most models 'url' points to a temporary copy we host that expires after about a day; for some provider-backed models it is the provider's own URL with the provider's own lifetime.<br/>
    /// Default Value: b64_json
    /// </summary>
    public sealed partial class OpenAIImagesEditsInResponseFormat
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}