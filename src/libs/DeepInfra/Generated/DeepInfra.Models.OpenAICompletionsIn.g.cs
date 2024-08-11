
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAICompletionsIn
    {
        /// <summary>
        /// model name<br/>
        /// Example: meta-llama/Llama-2-70b-chat-hf
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// input prompt - a single string is currently supported
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate in the completion.<br/>
        /// The total length of input tokens and generated tokens is limited by the model's context length.If explicitly set to None it will be the model's max context length minus input length.<br/>
        /// Default Value: 512
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int MaxTokens { get; set; } = 512;

        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double Temperature { get; set; } = 1;

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double TopP { get; set; } = 1;

        /// <summary>
        /// Sample from the best k (number of) tokens. 0 means off<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int TopK { get; set; } = 0;

        /// <summary>
        /// number of sequences to return. n != 1 incompatible with streaming<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int N { get; set; } = 1;

        /// <summary>
        /// whether to stream the output via SSE or return the full response<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool Stream { get; set; } = false;

        /// <summary>
        /// return top tokens and their log-probabilities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public int Logprobs { get; set; }

        /// <summary>
        /// return prompt as part of the respons
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("echo")]
        public bool Echo { get; set; }

        /// <summary>
        /// up to 16 sequences where the API will stop generating further tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::System.AnyOf<string?, global::System.Collections.Generic.IList<string>?>? Stop { get; set; }

        /// <summary>
        /// Positive values penalize new tokens based on whether they appear in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double PresencePenalty { get; set; } = 0;

        /// <summary>
        /// Positive values penalize new tokens based on how many times they appear in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double FrequencyPenalty { get; set; } = 0;

        /// <summary>
        /// The format of the response. Currently, only json is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AllOfJsonConverterFactory1))]
        public global::System.AllOf<global::DeepInfra.ResponseFormat4?>? ResponseFormat { get; set; }

        /// <summary>
        /// Alternative penalty for repetition, but multiplicative instead of additive (&gt; 1 penalize, &lt; 1 encourage)<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetition_penalty")]
        public double RepetitionPenalty { get; set; } = 1;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}