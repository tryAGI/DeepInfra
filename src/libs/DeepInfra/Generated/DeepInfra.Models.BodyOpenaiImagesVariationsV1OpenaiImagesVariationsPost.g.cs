
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyOpenaiImagesVariationsV1OpenaiImagesVariationsPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inp")]
        public global::DeepInfra.OpenAIImagesVariationsIn? Inp { get; set; }

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
        /// Initializes a new instance of the <see cref="BodyOpenaiImagesVariationsV1OpenaiImagesVariationsPost" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="imagename"></param>
        /// <param name="inp"></param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyOpenaiImagesVariationsV1OpenaiImagesVariationsPost(
            byte[] image,
            string imagename,
            string model,
            global::DeepInfra.OpenAIImagesVariationsIn? inp)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Inp = inp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyOpenaiImagesVariationsV1OpenaiImagesVariationsPost" /> class.
        /// </summary>
        public BodyOpenaiImagesVariationsV1OpenaiImagesVariationsPost()
        {
        }
    }
}