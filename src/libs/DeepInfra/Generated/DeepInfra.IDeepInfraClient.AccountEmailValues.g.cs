#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Account Email Values
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.EmailsOut> AccountEmailValuesAsync(
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}