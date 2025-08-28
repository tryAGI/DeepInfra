
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyOpenaiImagesGenerationsV1OpenaiImagesGenerationsPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inp")]
        public global::DeepInfra.OpenAIImagesGenerationsIn? Inp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyOpenaiImagesGenerationsV1OpenaiImagesGenerationsPost" /> class.
        /// </summary>
        /// <param name="inp"></param>
        /// <param name="prompt"></param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyOpenaiImagesGenerationsV1OpenaiImagesGenerationsPost(
            string prompt,
            string model,
            global::DeepInfra.OpenAIImagesGenerationsIn? inp)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Inp = inp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyOpenaiImagesGenerationsV1OpenaiImagesGenerationsPost" /> class.
        /// </summary>
        public BodyOpenaiImagesGenerationsV1OpenaiImagesGenerationsPost()
        {
        }
    }
}