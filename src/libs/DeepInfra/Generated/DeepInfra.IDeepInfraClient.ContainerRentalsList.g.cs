#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Container Rentals List
        /// </summary>
        /// <param name="state">
        /// whether to return active or inactive containers<br/>
        /// Default Value: active
        /// </param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::DeepInfra.ContainerRentalOut>> ContainerRentalsListAsync(
            global::DeepInfra.ContainerRentalsListV1ContainersGetState? state = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}