
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LoraModelUploadIn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hf_model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HfModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hf_token")]
        public string? HfToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LoraModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoraModelUploadIn" /> class.
        /// </summary>
        /// <param name="hfModelName"></param>
        /// <param name="hfToken"></param>
        /// <param name="loraModelName"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public LoraModelUploadIn(
            string hfModelName,
            string loraModelName,
            string? hfToken)
        {
            this.HfModelName = hfModelName ?? throw new global::System.ArgumentNullException(nameof(hfModelName));
            this.LoraModelName = loraModelName ?? throw new global::System.ArgumentNullException(nameof(loraModelName));
            this.HfToken = hfToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoraModelUploadIn" /> class.
        /// </summary>
        public LoraModelUploadIn()
        {
        }
    }
}