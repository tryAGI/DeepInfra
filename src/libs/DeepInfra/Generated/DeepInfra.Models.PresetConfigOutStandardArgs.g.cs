
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Engine tuning knobs.
    /// </summary>
    public sealed partial class PresetConfigOutStandardArgs
    {
        /// <summary>
        /// Maximum total sequence length (prompt + generation).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_context_size")]
        public int? MaxContextSize { get; set; }

        /// <summary>
        /// Max number of requests served concurrently.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent_requests")]
        public int? MaxConcurrentRequests { get; set; }

        /// <summary>
        /// Fraction of GPU memory the engine may use for weights + KV cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_memory_fraction")]
        public double? GpuMemoryFraction { get; set; }

        /// <summary>
        /// Max tokens processed per prefill/engine step (chunked prefill size).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_prefill_tokens")]
        public int? MaxPrefillTokens { get; set; }

        /// <summary>
        /// KV cache precision. fp8 ~doubles KV capacity at &lt;1% accuracy loss.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kv_cache_dtype")]
        public global::DeepInfra.PresetConfigOutStandardArgsKvCacheDtype2? KvCacheDtype { get; set; }

        /// <summary>
        /// Reuse KV cache for shared prompt prefixes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_prefix_caching")]
        public bool? EnablePrefixCaching { get; set; }

        /// <summary>
        /// On-the-fly weight quantization method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization")]
        public global::DeepInfra.PresetConfigOutStandardArgsQuantization2? Quantization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresetConfigOutStandardArgs" /> class.
        /// </summary>
        /// <param name="maxContextSize">
        /// Maximum total sequence length (prompt + generation).
        /// </param>
        /// <param name="maxConcurrentRequests">
        /// Max number of requests served concurrently.
        /// </param>
        /// <param name="gpuMemoryFraction">
        /// Fraction of GPU memory the engine may use for weights + KV cache.
        /// </param>
        /// <param name="maxPrefillTokens">
        /// Max tokens processed per prefill/engine step (chunked prefill size).
        /// </param>
        /// <param name="kvCacheDtype">
        /// KV cache precision. fp8 ~doubles KV capacity at &lt;1% accuracy loss.
        /// </param>
        /// <param name="enablePrefixCaching">
        /// Reuse KV cache for shared prompt prefixes.
        /// </param>
        /// <param name="quantization">
        /// On-the-fly weight quantization method.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PresetConfigOutStandardArgs(
            int? maxContextSize,
            int? maxConcurrentRequests,
            double? gpuMemoryFraction,
            int? maxPrefillTokens,
            global::DeepInfra.PresetConfigOutStandardArgsKvCacheDtype2? kvCacheDtype,
            bool? enablePrefixCaching,
            global::DeepInfra.PresetConfigOutStandardArgsQuantization2? quantization)
        {
            this.MaxContextSize = maxContextSize;
            this.MaxConcurrentRequests = maxConcurrentRequests;
            this.GpuMemoryFraction = gpuMemoryFraction;
            this.MaxPrefillTokens = maxPrefillTokens;
            this.KvCacheDtype = kvCacheDtype;
            this.EnablePrefixCaching = enablePrefixCaching;
            this.Quantization = quantization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresetConfigOutStandardArgs" /> class.
        /// </summary>
        public PresetConfigOutStandardArgs()
        {
        }

    }
}