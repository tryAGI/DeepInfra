
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebSearchTool
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"web_search"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "web_search";

        /// <summary>
        /// Maximum results returned per search call. Values above 20 are clamped.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Only results from these domains are kept. Entries are bare domains with an optional path prefix; a bare domain covers its subdomains. Wildcards are not supported. Mutually exclusive with exclude_domains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_domains")]
        public global::System.Collections.Generic.IList<string>? IncludeDomains { get; set; }

        /// <summary>
        /// Results from these domains are dropped. Entries are bare domains with an optional path prefix; a bare domain covers its subdomains. Wildcards are not supported. Mutually exclusive with include_domains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_domains")]
        public global::System.Collections.Generic.IList<string>? ExcludeDomains { get; set; }

        /// <summary>
        /// Steering text for how retrieved results are framed when injected into the model's context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_prompt")]
        public string? SearchPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchTool" /> class.
        /// </summary>
        /// <param name="maxResults">
        /// Maximum results returned per search call. Values above 20 are clamped.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="includeDomains">
        /// Only results from these domains are kept. Entries are bare domains with an optional path prefix; a bare domain covers its subdomains. Wildcards are not supported. Mutually exclusive with exclude_domains.
        /// </param>
        /// <param name="excludeDomains">
        /// Results from these domains are dropped. Entries are bare domains with an optional path prefix; a bare domain covers its subdomains. Wildcards are not supported. Mutually exclusive with include_domains.
        /// </param>
        /// <param name="searchPrompt">
        /// Steering text for how retrieved results are framed when injected into the model's context.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchTool(
            int? maxResults,
            global::System.Collections.Generic.IList<string>? includeDomains,
            global::System.Collections.Generic.IList<string>? excludeDomains,
            string? searchPrompt,
            string type = "web_search")
        {
            this.Type = type;
            this.MaxResults = maxResults;
            this.IncludeDomains = includeDomains;
            this.ExcludeDomains = excludeDomains;
            this.SearchPrompt = searchPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchTool" /> class.
        /// </summary>
        public WebSearchTool()
        {
        }

    }
}