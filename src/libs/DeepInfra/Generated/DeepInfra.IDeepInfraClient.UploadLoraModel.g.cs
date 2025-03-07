#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Upload Lora Model
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.DeploymentOut> UploadLoraModelAsync(
            global::DeepInfra.LoraModelUploadIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload Lora Model
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="hfModelName"></param>
        /// <param name="hfToken"></param>
        /// <param name="loraModelName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.DeploymentOut> UploadLoraModelAsync(
            string hfModelName,
            string loraModelName,
            string? xiApiKey = default,
            string? hfToken = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}