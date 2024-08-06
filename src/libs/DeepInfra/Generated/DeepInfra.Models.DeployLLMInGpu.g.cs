
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum DeployLLMInGpu
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
    public static class DeployLLMInGpuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeployLLMInGpu value)
        {
            return value switch
            {
                DeployLLMInGpu.A10080GB => "A100-80GB",
                DeployLLMInGpu.H10080GB => "H100-80GB",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeployLLMInGpu? ToEnum(string value)
        {
            return value switch
            {
                "A100-80GB" => DeployLLMInGpu.A10080GB,
                "H100-80GB" => DeployLLMInGpu.H10080GB,
                _ => null,
            };
        }
    }
}