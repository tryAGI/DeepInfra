
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIImagesEditsIn
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
        /// Input image bytes for editing task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// Input image bytes for editing task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// A text description of the desired image edits.<br/>
        /// Example: Add a hat to the cat
        /// </summary>
        /// <example>Add a hat to the cat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where image should be edited. Must be a valid PNG file, less than 4MB, and have the same dimensions as image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public byte[]? Mask { get; set; }

        /// <summary>
        /// An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where image should be edited. Must be a valid PNG file, less than 4MB, and have the same dimensions as image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskname")]
        public string? Maskname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIImagesEditsIn" /> class.
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
        /// Input image bytes for editing task
        /// </param>
        /// <param name="imagename">
        /// Input image bytes for editing task
        /// </param>
        /// <param name="prompt">
        /// A text description of the desired image edits.<br/>
        /// Example: Add a hat to the cat
        /// </param>
        /// <param name="mask">
        /// An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where image should be edited. Must be a valid PNG file, less than 4MB, and have the same dimensions as image.
        /// </param>
        /// <param name="maskname">
        /// An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where image should be edited. Must be a valid PNG file, less than 4MB, and have the same dimensions as image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIImagesEditsIn(
            string model,
            byte[] image,
            string imagename,
            string prompt,
            int? n,
            global::DeepInfra.OpenAIImagesResponseFormat? responseFormat,
            string? size,
            string? user,
            byte[]? mask,
            string? maskname)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.N = n;
            this.ResponseFormat = responseFormat;
            this.Size = size;
            this.User = user;
            this.Mask = mask;
            this.Maskname = maskname;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIImagesEditsIn" /> class.
        /// </summary>
        public OpenAIImagesEditsIn()
        {
        }
    }
}