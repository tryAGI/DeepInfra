#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Get Checklist
        /// </summary>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.Checklist> GetChecklistAsync(
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}