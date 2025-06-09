#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Container Rentals List
        /// </summary>
        /// <param name="state">
        /// A list of states that should be returned, separated by comma. Allowed values in the list are: creating,starting,running,shutting_down,failed,deleted
        /// </param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::DeepInfra.ContainerRentalOut>> ContainerRentalsListAsync(
            string? state = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}