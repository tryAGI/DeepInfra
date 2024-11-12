
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HFModel
    {
        /// <summary>
        /// Model Id from huggingface<br/>
        /// Example: google/vit-base-patch16-224
        /// </summary>
        /// <example>google/vit-base-patch16-224</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Task<br/>
        /// Example: image-classification
        /// </summary>
        /// <example>image-classification</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public string? Task { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HFModel" /> class.
        /// </summary>
        /// <param name="modelName">
        /// Model Id from huggingface<br/>
        /// Example: google/vit-base-patch16-224
        /// </param>
        /// <param name="task">
        /// Task<br/>
        /// Example: image-classification
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public HFModel(
            string modelName,
            string? task)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Task = task;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HFModel" /> class.
        /// </summary>
        public HFModel()
        {
        }
    }
}