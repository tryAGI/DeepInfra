#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Model Meta Update
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.ModelMetaUpdateModelsModelNameMetaPostResponse> ModelMetaUpdateAsync(
            string modelName,
            global::DeepInfra.ModelMetaIn request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Model Meta Update
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="description">
        /// short model description in plain text
        /// </param>
        /// <param name="githubUrl">
        /// source code project link (empty to delete)
        /// </param>
        /// <param name="paperUrl">
        /// paper/research link (empty to delete)
        /// </param>
        /// <param name="licenseUrl">
        /// usage license link (empty to delete)
        /// </param>
        /// <param name="readme">
        /// markdown flavored model readme
        /// </param>
        /// <param name="coverImgUrl">
        /// dataurl or regular url to cover image (empty to delete)
        /// </param>
        /// <param name="reportedType">
        /// model type
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.ModelMetaUpdateModelsModelNameMetaPostResponse> ModelMetaUpdateAsync(
            string modelName,
            string? description = default,
            string? githubUrl = default,
            string? paperUrl = default,
            string? licenseUrl = default,
            string? readme = default,
            string? coverImgUrl = default,
            global::DeepInfra.HFTasksE? reportedType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}