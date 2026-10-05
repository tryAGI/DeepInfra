
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponsesWebSearchTool
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"web_search"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "web_search";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public int? MaxResults { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_domains")]
        public global::System.Collections.Generic.IList<string>? IncludeDomains { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_domains")]
        public global::System.Collections.Generic.IList<string>? ExcludeDomains { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_prompt")]
        public string? SearchPrompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_web_access")]
        public bool? ExternalWebAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesWebSearchTool" /> class.
        /// </summary>
        /// <param name="maxResults"></param>
        /// <param name="includeDomains"></param>
        /// <param name="excludeDomains"></param>
        /// <param name="searchPrompt"></param>
        /// <param name="externalWebAccess"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesWebSearchTool(
            int? maxResults,
            global::System.Collections.Generic.IList<string>? includeDomains,
            global::System.Collections.Generic.IList<string>? excludeDomains,
            string? searchPrompt,
            bool? externalWebAccess,
            string type = "web_search")
        {
            this.Type = type;
            this.MaxResults = maxResults;
            this.IncludeDomains = includeDomains;
            this.ExcludeDomains = excludeDomains;
            this.SearchPrompt = searchPrompt;
            this.ExternalWebAccess = externalWebAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesWebSearchTool" /> class.
        /// </summary>
        public ResponsesWebSearchTool()
        {
        }

    }
}