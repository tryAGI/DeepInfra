#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Container Rentals Start
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.ContainerRentalStartOut> ContainerRentalsStartAsync(
            global::DeepInfra.ContainerRentalStartIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Container Rentals Start
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="name">
        /// Container Name
        /// </param>
        /// <param name="gpuConfig">
        /// GPU config
        /// </param>
        /// <param name="containerImage">
        /// Container Image
        /// </param>
        /// <param name="cloudInitUserData">
        /// Cloud Init User Data
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.ContainerRentalStartOut> ContainerRentalsStartAsync(
            string name,
            string gpuConfig,
            string containerImage,
            string cloudInitUserData,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}