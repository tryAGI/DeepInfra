
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NoulAnswer
    {
        /// <summary>
        /// Default Value: noul
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noul")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Noul { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NoulAnswer" /> class.
        /// </summary>
        /// <param name="noul"></param>
        /// <param name="type">
        /// Default Value: noul
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NoulAnswer(
            double noul,
            string? type)
        {
            this.Type = type;
            this.Noul = noul;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoulAnswer" /> class.
        /// </summary>
        public NoulAnswer()
        {
        }

    }
}