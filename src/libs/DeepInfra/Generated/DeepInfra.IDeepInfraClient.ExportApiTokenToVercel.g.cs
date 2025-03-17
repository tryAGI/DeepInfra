#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Export Api Token To Vercel
        /// </summary>
        /// <param name="apiToken"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ExportApiTokenToVercelAsync(
            string apiToken,
            global::DeepInfra.ApiTokenVercelExportIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Export Api Token To Vercel
        /// </summary>
        /// <param name="apiToken"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="projectIdOrName"></param>
        /// <param name="isSensitive"></param>
        /// <param name="envDevelopment"></param>
        /// <param name="envPreview"></param>
        /// <param name="envProduction"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ExportApiTokenToVercelAsync(
            string apiToken,
            string projectIdOrName,
            bool isSensitive,
            bool envDevelopment,
            bool envPreview,
            bool envProduction,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}