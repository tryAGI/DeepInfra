
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiTokenVercelExportIn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id_or_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ProjectIdOrName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_sensitive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool IsSensitive { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env_development")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool EnvDevelopment { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env_preview")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool EnvPreview { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env_production")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool EnvProduction { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTokenVercelExportIn" /> class.
        /// </summary>
        /// <param name="projectIdOrName"></param>
        /// <param name="isSensitive"></param>
        /// <param name="envDevelopment"></param>
        /// <param name="envPreview"></param>
        /// <param name="envProduction"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiTokenVercelExportIn(
            string projectIdOrName,
            bool isSensitive,
            bool envDevelopment,
            bool envPreview,
            bool envProduction)
        {
            this.ProjectIdOrName = projectIdOrName ?? throw new global::System.ArgumentNullException(nameof(projectIdOrName));
            this.IsSensitive = isSensitive;
            this.EnvDevelopment = envDevelopment;
            this.EnvPreview = envPreview;
            this.EnvProduction = envProduction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTokenVercelExportIn" /> class.
        /// </summary>
        public ApiTokenVercelExportIn()
        {
        }
    }
}