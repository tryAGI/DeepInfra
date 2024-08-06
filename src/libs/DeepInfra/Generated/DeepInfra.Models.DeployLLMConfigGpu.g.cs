
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum DeployLLMConfigGpu
    {
        /// <summary>
        /// 
        /// </summary>
        A10080GB,
        /// <summary>
        /// 
        /// </summary>
        H10080GB,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeployLLMConfigGpuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeployLLMConfigGpu value)
        {
            return value switch
            {
                DeployLLMConfigGpu.A10080GB => "A100-80GB",
                DeployLLMConfigGpu.H10080GB => "H100-80GB",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeployLLMConfigGpu? ToEnum(string value)
        {
            return value switch
            {
                "A100-80GB" => DeployLLMConfigGpu.A10080GB,
                "H100-80GB" => DeployLLMConfigGpu.H10080GB,
                _ => null,
            };
        }
    }
}