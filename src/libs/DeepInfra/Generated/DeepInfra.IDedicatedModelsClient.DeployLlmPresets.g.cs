#nullable enable

namespace DeepInfra
{
    public partial interface IDedicatedModelsClient
    {
        /// <summary>
        /// Deploy Llm Presets<br/>
        /// DeepInfra presets and mirrored vLLM recipes for ``hf_repo_id``, told apart by<br/>
        /// ``source``; empty when none. Filter by ``gpu``/``engine``/``source``.
        /// </summary>
        /// <param name="hfRepoId"></param>
        /// <param name="gpu"></param>
        /// <param name="engine"></param>
        /// <param name="source"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::DeepInfra.PresetConfigOut>> DeployLlmPresetsAsync(
            string hfRepoId,
            global::DeepInfra.DeployGPUs? gpu = default,
            string? engine = default,
            string? source = default,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deploy Llm Presets<br/>
        /// DeepInfra presets and mirrored vLLM recipes for ``hf_repo_id``, told apart by<br/>
        /// ``source``; empty when none. Filter by ``gpu``/``engine``/``source``.
        /// </summary>
        /// <param name="hfRepoId"></param>
        /// <param name="gpu"></param>
        /// <param name="engine"></param>
        /// <param name="source"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::DeepInfra.PresetConfigOut>>> DeployLlmPresetsAsResponseAsync(
            string hfRepoId,
            global::DeepInfra.DeployGPUs? gpu = default,
            string? engine = default,
            string? source = default,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}