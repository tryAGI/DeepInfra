
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Per-model metadata exposed by ``/v1/openai/models``.<br/>
    /// Pricing key names are surface-specific:<br/>
    /// - chat / vlm:  {"input_tokens", "output_tokens", "cache_read_tokens"}  ($/1M tokens)<br/>
    /// - embed:       {"input_tokens"}                                        ($/1M tokens)<br/>
    /// - image-gen:   {"per_image_unit"}                                      ($/image at default geometry)<br/>
    /// - video-gen:   {"output_seconds"}                                      ($/sec generated)<br/>
    /// - tts:         {"input_characters"}                                    ($/1M input chars)<br/>
    /// - stt:         {"input_seconds"}                                       ($/sec input audio)<br/>
    /// ``tags`` always carries the surface short alias (e.g. ``'chat'``,<br/>
    /// ``'image-gen'``) and, for chat models, any of ``'vision'``,<br/>
    /// ``'prompt_cache'``, ``'reasoning_effort'``, ``'reasoning'``.
    /// </summary>
    public sealed partial class ModelMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        public int? ContextLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> Pricing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_width")]
        public int? DefaultWidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_height")]
        public int? DefaultHeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_iterations")]
        public int? DefaultIterations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelMetadata" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="pricing"></param>
        /// <param name="tags"></param>
        /// <param name="contextLength"></param>
        /// <param name="maxTokens"></param>
        /// <param name="defaultWidth"></param>
        /// <param name="defaultHeight"></param>
        /// <param name="defaultIterations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelMetadata(
            string description,
            global::System.Collections.Generic.Dictionary<string, double> pricing,
            global::System.Collections.Generic.IList<string> tags,
            int? contextLength,
            int? maxTokens,
            int? defaultWidth,
            int? defaultHeight,
            int? defaultIterations)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ContextLength = contextLength;
            this.MaxTokens = maxTokens;
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.DefaultWidth = defaultWidth;
            this.DefaultHeight = defaultHeight;
            this.DefaultIterations = defaultIterations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelMetadata" /> class.
        /// </summary>
        public ModelMetadata()
        {
        }

    }
}