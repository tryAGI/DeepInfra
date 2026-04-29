
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// The DeepInfra API provides serverless AI inference, custom model deployments, and GPU rentals.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IDeepInfraClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::DeepInfra.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// User profile, team management, and rate limits.
        /// </summary>
        public AccountClient Account { get; }

        /// <summary>
        /// OpenAI-compatible speech synthesis, transcription, and translation.
        /// </summary>
        public AudioClient Audio { get; }

        /// <summary>
        /// API tokens, SSH keys, scoped JWTs, and login flows.
        /// </summary>
        public AuthenticationClient Authentication { get; }

        /// <summary>
        /// Payment methods, usage tracking, and billing.
        /// </summary>
        public BillingClient Billing { get; }

        /// <summary>
        /// OpenAI and Anthropic-compatible chat completion endpoints for LLMs.
        /// </summary>
        public ChatCompletionsClient ChatCompletions { get; }

        /// <summary>
        /// Deploy and manage private model instances with autoscaling.
        /// </summary>
        public DedicatedModelsClient DedicatedModels { get; }

        /// <summary>
        /// Generate text embeddings for search and RAG.
        /// </summary>
        public EmbeddingsClient Embeddings { get; }

        /// <summary>
        /// File uploads and batch processing.
        /// </summary>
        public FilesBatchesClient FilesBatches { get; }

        /// <summary>
        /// Manage OpenClaw GPU instances.
        /// </summary>
        public GpuInstancesClient GpuInstances { get; }

        /// <summary>
        /// Rent dedicated GPU containers.
        /// </summary>
        public GpuRentalsClient GpuRentals { get; }

        /// <summary>
        /// Generate, edit, and create variations of images.
        /// </summary>
        public ImageGenerationClient ImageGeneration { get; }

        /// <summary>
        /// Native DeepInfra inference API for models and deployments.
        /// </summary>
        public InferenceClient Inference { get; }

        /// <summary>
        /// Create, manage, and query LoRA adapter models.
        /// </summary>
        public LoRAAdaptersClient LoRAAdapters { get; }

        /// <summary>
        /// Query inference logs, deployment logs, and usage metrics.
        /// </summary>
        public LogsMetricsClient LogsMetrics { get; }

        /// <summary>
        /// Browse, search, and manage AI models.
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// OpenAI-compatible text completion endpoints.
        /// </summary>
        public TextCompletionsClient TextCompletions { get; }

        /// <summary>
        /// ElevenLabs-compatible TTS endpoints and voice management.
        /// </summary>
        public TextToSpeechClient TextToSpeech { get; }

        /// <summary>
        /// Feedback submission and CLI version.
        /// </summary>
        public UtilitiesClient Utilities { get; }

    }
}