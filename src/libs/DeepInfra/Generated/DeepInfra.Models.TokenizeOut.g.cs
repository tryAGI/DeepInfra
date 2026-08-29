
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TokenizeOut
    {
        /// <summary>
        /// number of tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// the model's maximum context length
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_model_len")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxModelLen { get; set; }

        /// <summary>
        /// token ids
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Tokens { get; set; }

        /// <summary>
        /// per-token strings, if requested (vLLM)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_strs")]
        public global::System.Collections.Generic.IList<string>? TokenStrs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeOut" /> class.
        /// </summary>
        /// <param name="count">
        /// number of tokens
        /// </param>
        /// <param name="maxModelLen">
        /// the model's maximum context length
        /// </param>
        /// <param name="tokens">
        /// token ids
        /// </param>
        /// <param name="tokenStrs">
        /// per-token strings, if requested (vLLM)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenizeOut(
            int count,
            int maxModelLen,
            global::System.Collections.Generic.IList<int> tokens,
            global::System.Collections.Generic.IList<string>? tokenStrs)
        {
            this.Count = count;
            this.MaxModelLen = maxModelLen;
            this.Tokens = tokens ?? throw new global::System.ArgumentNullException(nameof(tokens));
            this.TokenStrs = tokenStrs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeOut" /> class.
        /// </summary>
        public TokenizeOut()
        {
        }

    }
}