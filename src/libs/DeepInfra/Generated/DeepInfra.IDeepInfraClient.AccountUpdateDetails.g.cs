#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Account Update Details
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AccountUpdateDetailsAsync(
            global::DeepInfra.MeIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Account Update Details
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="name">
        /// Personal name
        /// </param>
        /// <param name="firstName">
        /// First name of the user
        /// </param>
        /// <param name="lastName">
        /// Last name of the user
        /// </param>
        /// <param name="country">
        /// Country of the user
        /// </param>
        /// <param name="email"></param>
        /// <param name="isBusinessAccount"></param>
        /// <param name="company">
        /// Company name
        /// </param>
        /// <param name="website">
        /// Company website address
        /// </param>
        /// <param name="title">
        /// Job title of the user, e.g. 'Software Engineer'
        /// </param>
        /// <param name="displayName">
        /// String with length between 1 and 39 characters. Only alphanumeric characters and dashes allowed. Must contain no leading, trailing or consecutive dashes.
        /// </param>
        /// <param name="useCase">
        /// Short description of the use case for the account
        /// </param>
        /// <param name="attribution">
        /// Short description of how the user found out about DeepInfra
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AccountUpdateDetailsAsync(
            string? xiApiKey = default,
            string? name = default,
            string? firstName = default,
            string? lastName = default,
            string? country = default,
            string? email = default,
            bool? isBusinessAccount = default,
            string? company = default,
            string? website = default,
            string? title = default,
            string? displayName = default,
            string? useCase = default,
            string? attribution = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}