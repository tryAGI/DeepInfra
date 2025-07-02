
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenRouterModelData
    {
        /// <summary>
        /// Model identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Supported input modalities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> InputModalities { get; set; }

        /// <summary>
        /// Supported output modalities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> OutputModalities { get; set; }

        /// <summary>
        /// Model quantization type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Quantization { get; set; }

        /// <summary>
        /// Maximum context length
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContextLength { get; set; }

        /// <summary>
        /// Maximum output length
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxOutputLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.OpenRouterPricing Pricing { get; set; }

        /// <summary>
        /// Supported sampling parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_sampling_parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SupportedSamplingParameters { get; set; }

        /// <summary>
        /// Supported features
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_features")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SupportedFeatures { get; set; }

        /// <summary>
        /// Model description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// OpenRouter specific data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openrouter")]
        public global::System.Collections.Generic.Dictionary<string, string>? Openrouter { get; set; }

        /// <summary>
        /// Available datacenters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datacenters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepInfra.OpenRouterDatacenter> Datacenters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenRouterModelData" /> class.
        /// </summary>
        /// <param name="id">
        /// Model identifier
        /// </param>
        /// <param name="name">
        /// Human-readable model name
        /// </param>
        /// <param name="inputModalities">
        /// Supported input modalities
        /// </param>
        /// <param name="outputModalities">
        /// Supported output modalities
        /// </param>
        /// <param name="quantization">
        /// Model quantization type
        /// </param>
        /// <param name="contextLength">
        /// Maximum context length
        /// </param>
        /// <param name="maxOutputLength">
        /// Maximum output length
        /// </param>
        /// <param name="pricing"></param>
        /// <param name="supportedSamplingParameters">
        /// Supported sampling parameters
        /// </param>
        /// <param name="supportedFeatures">
        /// Supported features
        /// </param>
        /// <param name="description">
        /// Model description
        /// </param>
        /// <param name="openrouter">
        /// OpenRouter specific data
        /// </param>
        /// <param name="datacenters">
        /// Available datacenters
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenRouterModelData(
            string id,
            string name,
            global::System.Collections.Generic.IList<string> inputModalities,
            global::System.Collections.Generic.IList<string> outputModalities,
            string quantization,
            int contextLength,
            int maxOutputLength,
            global::DeepInfra.OpenRouterPricing pricing,
            global::System.Collections.Generic.IList<string> supportedSamplingParameters,
            global::System.Collections.Generic.IList<string> supportedFeatures,
            global::System.Collections.Generic.IList<global::DeepInfra.OpenRouterDatacenter> datacenters,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? openrouter)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.InputModalities = inputModalities ?? throw new global::System.ArgumentNullException(nameof(inputModalities));
            this.OutputModalities = outputModalities ?? throw new global::System.ArgumentNullException(nameof(outputModalities));
            this.Quantization = quantization ?? throw new global::System.ArgumentNullException(nameof(quantization));
            this.ContextLength = contextLength;
            this.MaxOutputLength = maxOutputLength;
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.SupportedSamplingParameters = supportedSamplingParameters ?? throw new global::System.ArgumentNullException(nameof(supportedSamplingParameters));
            this.SupportedFeatures = supportedFeatures ?? throw new global::System.ArgumentNullException(nameof(supportedFeatures));
            this.Datacenters = datacenters ?? throw new global::System.ArgumentNullException(nameof(datacenters));
            this.Description = description;
            this.Openrouter = openrouter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenRouterModelData" /> class.
        /// </summary>
        public OpenRouterModelData()
        {
        }
    }
}