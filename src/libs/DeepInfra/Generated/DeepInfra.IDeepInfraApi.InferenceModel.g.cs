#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Inference Model
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="version">
        /// model version to run inference against
        /// </param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> InferenceModelAsync(
            string modelName,
            string? version = default,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}