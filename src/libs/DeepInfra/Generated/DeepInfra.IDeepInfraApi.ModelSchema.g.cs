#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Model Schema
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="variantKey">
        /// An enumeration.
        /// </param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.SchemaOut> ModelSchemaAsync(
            string modelName,
            global::DeepInfra.SchemaVariantKey variantKey,
            string? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}