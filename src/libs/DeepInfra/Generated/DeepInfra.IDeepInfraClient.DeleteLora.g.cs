#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Delete Lora
        /// </summary>
        /// <param name="loraName"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteLoraAsync(
            string loraName,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}