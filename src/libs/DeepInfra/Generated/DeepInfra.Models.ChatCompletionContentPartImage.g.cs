
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionContentPartImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.ChatCompletionContentPartImageTypeJsonConverter))]
        public global::DeepInfra.ChatCompletionContentPartImageType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.ImageURL ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartImage" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="imageUrl"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatCompletionContentPartImage(
            global::DeepInfra.ImageURL imageUrl,
            global::DeepInfra.ChatCompletionContentPartImageType type)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartImage" /> class.
        /// </summary>
        public ChatCompletionContentPartImage()
        {
        }
    }
}