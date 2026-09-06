
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum DeploymentOutStandardArgsQuantization
    {
        /// <summary>
        ///
        /// </summary>
        Awq,
        /// <summary>
        ///
        /// </summary>
        AwqMarlin,
        /// <summary>
        ///
        /// </summary>
        Bitsandbytes,
        /// <summary>
        ///
        /// </summary>
        CompressedTensors,
        /// <summary>
        ///
        /// </summary>
        Fp8,
        /// <summary>
        ///
        /// </summary>
        Gptq,
        /// <summary>
        ///
        /// </summary>
        GptqMarlin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentOutStandardArgsQuantizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentOutStandardArgsQuantization value)
        {
            return value switch
            {
                DeploymentOutStandardArgsQuantization.Awq => "awq",
                DeploymentOutStandardArgsQuantization.AwqMarlin => "awq_marlin",
                DeploymentOutStandardArgsQuantization.Bitsandbytes => "bitsandbytes",
                DeploymentOutStandardArgsQuantization.CompressedTensors => "compressed-tensors",
                DeploymentOutStandardArgsQuantization.Fp8 => "fp8",
                DeploymentOutStandardArgsQuantization.Gptq => "gptq",
                DeploymentOutStandardArgsQuantization.GptqMarlin => "gptq_marlin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentOutStandardArgsQuantization? ToEnum(string value)
        {
            return value switch
            {
                "awq" => DeploymentOutStandardArgsQuantization.Awq,
                "awq_marlin" => DeploymentOutStandardArgsQuantization.AwqMarlin,
                "bitsandbytes" => DeploymentOutStandardArgsQuantization.Bitsandbytes,
                "compressed-tensors" => DeploymentOutStandardArgsQuantization.CompressedTensors,
                "fp8" => DeploymentOutStandardArgsQuantization.Fp8,
                "gptq" => DeploymentOutStandardArgsQuantization.Gptq,
                "gptq_marlin" => DeploymentOutStandardArgsQuantization.GptqMarlin,
                _ => null,
            };
        }
    }
}