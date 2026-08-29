
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DetokenizeIn
    {
        /// <summary>
        /// model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// token ids to detokenize
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public global::System.Collections.Generic.IList<int>? Tokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetokenizeIn" /> class.
        /// </summary>
        /// <param name="model">
        /// model name
        /// </param>
        /// <param name="tokens">
        /// token ids to detokenize
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetokenizeIn(
            string model,
            global::System.Collections.Generic.IList<int>? tokens)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Tokens = tokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetokenizeIn" /> class.
        /// </summary>
        public DetokenizeIn()
        {
        }

    }
}