
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScaleSettings
    {
        /// <summary>
        /// Minimum number of model instances to run<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_instances")]
        public int? MinInstances { get; set; }

        /// <summary>
        /// Maximum number of model instances to run<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_instances")]
        public int? MaxInstances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScaleSettings" /> class.
        /// </summary>
        /// <param name="minInstances">
        /// Minimum number of model instances to run<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="maxInstances">
        /// Maximum number of model instances to run<br/>
        /// Default Value: 1
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ScaleSettings(
            int? minInstances,
            int? maxInstances)
        {
            this.MinInstances = minInstances;
            this.MaxInstances = maxInstances;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScaleSettings" /> class.
        /// </summary>
        public ScaleSettings()
        {
        }
    }
}