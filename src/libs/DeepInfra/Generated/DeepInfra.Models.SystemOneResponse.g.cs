
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SystemOneResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Answers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.Usage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemOneResponse" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="answers"></param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SystemOneResponse(
            string model,
            object answers,
            global::DeepInfra.Usage usage)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Answers = answers ?? throw new global::System.ArgumentNullException(nameof(answers));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemOneResponse" /> class.
        /// </summary>
        public SystemOneResponse()
        {
        }

    }
}