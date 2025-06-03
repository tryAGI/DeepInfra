#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Container Rentals Update
        /// </summary>
        /// <param name="containerId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ContainerRentalsUpdateAsync(
            string containerId,
            global::DeepInfra.ContainerRentalUpdateIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Container Rentals Update
        /// </summary>
        /// <param name="containerId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="name">
        /// Container Name
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ContainerRentalsUpdateAsync(
            string containerId,
            string name,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}