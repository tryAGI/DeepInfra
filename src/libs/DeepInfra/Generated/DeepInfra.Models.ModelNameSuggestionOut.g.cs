
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelNameSuggestionOut
    {
        /// <summary>
        /// A model name that is currently free to claim (prefixed in username/model-name format).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelNameSuggestionOut" /> class.
        /// </summary>
        /// <param name="modelName">
        /// A model name that is currently free to claim (prefixed in username/model-name format).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelNameSuggestionOut(
            string modelName)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelNameSuggestionOut" /> class.
        /// </summary>
        public ModelNameSuggestionOut()
        {
        }

    }
}