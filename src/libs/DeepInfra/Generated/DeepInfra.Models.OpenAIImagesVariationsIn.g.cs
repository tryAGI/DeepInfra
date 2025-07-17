
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIImagesVariationsIn
    {
        /// <summary>
        /// The model to use.
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.OpenAIImagesResponseFormatJsonConverter))]
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
        /// Input image bytes for variation task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// Input image bytes for variation task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIImagesVariationsIn" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use.
        /// </param>
        /// <param name="n">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="responseFormat"></param>
        /// <param name="size">
        /// The size of the generated images. Available sizes depend on the model.<br/>
        /// Default Value: 1024x1024
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help to monitor and detect abuse.
        /// </param>
        /// <param name="image">
        /// Input image bytes for variation task
        /// </param>
        /// <param name="imagename">
        /// Input image bytes for variation task
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIImagesVariationsIn(
            string model,
            byte[] image,
            string imagename,
            int? n,
            global::DeepInfra.OpenAIImagesResponseFormat? responseFormat,
            string? size,
            string? user)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.N = n;
            this.ResponseFormat = responseFormat;
            this.Size = size;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIImagesVariationsIn" /> class.
        /// </summary>
        public OpenAIImagesVariationsIn()
        {
        }
    }
}