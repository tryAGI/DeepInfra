
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentMainStatsOut
    {
        /// <summary>
        /// Model name<br/>
        /// Example: google/vit-base-patch16-224
        /// </summary>
        /// <example>google/vit-base-patch16-224</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// number of inference requests in the provided interval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentMainStatsOut" /> class.
        /// </summary>
        /// <param name="modelName">
        /// Model name<br/>
        /// Example: google/vit-base-patch16-224
        /// </param>
        /// <param name="requests">
        /// number of inference requests in the provided interval
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentMainStatsOut(
            string modelName,
            int requests)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Requests = requests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentMainStatsOut" /> class.
        /// </summary>
        public DeploymentMainStatsOut()
        {
        }
    }
}