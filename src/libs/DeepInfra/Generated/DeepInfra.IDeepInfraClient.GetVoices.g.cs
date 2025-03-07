#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Get Voices<br/>
        /// Get available voices for a given user
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.GetVoicesOut> GetVoicesAsync(
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}