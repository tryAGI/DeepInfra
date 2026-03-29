
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIImagesGenerationsIn
    {
        /// <summary>
        /// The model to use for image generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// The format in which the generated images are returned. Currently only b64_json is supported.<br/>
        /// Default Value: b64_json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::DeepInfra.OpenAIImagesResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// The size of the generated images. Available sizes depend on the model.<br/>
        /// Default Value: 1024x1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user, which can help to monitor and detect abuse.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// A text description of desired image(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The quality of the image that will be generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public string? Quality { get; set; }

        /// <summary>
        /// The style of the generated images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public string? Style { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIImagesGenerationsIn" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for image generation.
        /// </param>
        /// <param name="prompt">
        /// A text description of desired image(s).
        /// </param>
        /// <param name="n">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="responseFormat">
        /// The format in which the generated images are returned. Currently only b64_json is supported.<br/>
        /// Default Value: b64_json
        /// </param>
        /// <param name="size">
        /// The size of the generated images. Available sizes depend on the model.<br/>
        /// Default Value: 1024x1024
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help to monitor and detect abuse.
        /// </param>
        /// <param name="quality">
        /// The quality of the image that will be generated.
        /// </param>
        /// <param name="style">
        /// The style of the generated images.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIImagesGenerationsIn(
            string model,
            string prompt,
            int? n,
            global::DeepInfra.OpenAIImagesResponseFormat? responseFormat,
            string? size,
            string? user,
            string? quality,
            string? style)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.N = n;
            this.ResponseFormat = responseFormat;
            this.Size = size;
            this.User = user;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Quality = quality;
            this.Style = style;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIImagesGenerationsIn" /> class.
        /// </summary>
        public OpenAIImagesGenerationsIn()
        {
        }
    }
}