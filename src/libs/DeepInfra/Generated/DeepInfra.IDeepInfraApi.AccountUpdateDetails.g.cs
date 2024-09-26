#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Account Update Details
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AccountUpdateDetailsV1MePatchResponse> AccountUpdateDetailsAsync(
            global::DeepInfra.MeIn request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Account Update Details
        /// </summary>
        /// <param name="name">
        /// Personal name
        /// </param>
        /// <param name="email"></param>
        /// <param name="isBusinessAccount"></param>
        /// <param name="company">
        /// Company name
        /// </param>
        /// <param name="website">
        /// Company website address
        /// </param>
        /// <param name="displayName">
        /// String with length between 1 and 39 characters. Only alphanumeric characters and dashes allowed. Must contain no leading, trailing or consecutive dashes.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AccountUpdateDetailsV1MePatchResponse> AccountUpdateDetailsAsync(
            string? name = default,
            string? email = default,
            bool? isBusinessAccount = default,
            string? company = default,
            string? website = default,
            string? displayName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}