
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChoiceAnswer
    {
        /// <summary>
        /// Default Value: choice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Choice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> Probabilities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChoiceAnswer" /> class.
        /// </summary>
        /// <param name="choice"></param>
        /// <param name="probabilities"></param>
        /// <param name="confidence"></param>
        /// <param name="type">
        /// Default Value: choice
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChoiceAnswer(
            string choice,
            global::System.Collections.Generic.Dictionary<string, double> probabilities,
            double confidence,
            string? type)
        {
            this.Type = type;
            this.Choice = choice ?? throw new global::System.ArgumentNullException(nameof(choice));
            this.Probabilities = probabilities ?? throw new global::System.ArgumentNullException(nameof(probabilities));
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChoiceAnswer" /> class.
        /// </summary>
        public ChoiceAnswer()
        {
        }

    }
}