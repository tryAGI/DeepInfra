#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Model Family
        /// </summary>
        /// <param name="familyName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.ModelFamilyOut> ModelFamilyAsync(
            string familyName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}