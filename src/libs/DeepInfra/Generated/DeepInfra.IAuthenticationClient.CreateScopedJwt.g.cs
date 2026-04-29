#nullable enable

namespace DeepInfra
{
    public partial interface IAuthenticationClient
    {
        /// <summary>
        ///  Create Scoped Jwt
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.ScopedJWTOut> CreateScopedJwtAsync(

            global::DeepInfra.ScopedJWTIn request,
            string? xiApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///  Create Scoped Jwt
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="apiKeyName"></param>
        /// <param name="models">
        /// allow inference only to the specified model names
        /// </param>
        /// <param name="expiresDelta">
        /// how many seconds in the future should the token be valid for
        /// </param>
        /// <param name="expiresAt">
        /// unix timestamp when the token should expire
        /// </param>
        /// <param name="spendingLimit">
        /// only allow spending that much USD until the token becomes invalid
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.ScopedJWTOut> CreateScopedJwtAsync(
            string apiKeyName,
            string? xiApiKey = default,
            global::System.Collections.Generic.IList<string>? models = default,
            int? expiresDelta = default,
            int? expiresAt = default,
            double? spendingLimit = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}