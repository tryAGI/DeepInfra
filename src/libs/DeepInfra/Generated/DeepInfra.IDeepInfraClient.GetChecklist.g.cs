#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Get Checklist
        /// </summary>
        /// <param name="computeOwed">
        /// Default Value: false
        /// </param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.Checklist> GetChecklistAsync(
            bool? computeOwed = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}