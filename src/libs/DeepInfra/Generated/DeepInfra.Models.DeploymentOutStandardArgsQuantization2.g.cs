
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum DeploymentOutStandardArgsQuantization2
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
    public static class DeploymentOutStandardArgsQuantization2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentOutStandardArgsQuantization2 value)
        {
            return value switch
            {
                DeploymentOutStandardArgsQuantization2.Awq => "awq",
                DeploymentOutStandardArgsQuantization2.AwqMarlin => "awq_marlin",
                DeploymentOutStandardArgsQuantization2.Bitsandbytes => "bitsandbytes",
                DeploymentOutStandardArgsQuantization2.CompressedTensors => "compressed-tensors",
                DeploymentOutStandardArgsQuantization2.Fp8 => "fp8",
                DeploymentOutStandardArgsQuantization2.Gptq => "gptq",
                DeploymentOutStandardArgsQuantization2.GptqMarlin => "gptq_marlin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentOutStandardArgsQuantization2? ToEnum(string value)
        {
            return value switch
            {
                "awq" => DeploymentOutStandardArgsQuantization2.Awq,
                "awq_marlin" => DeploymentOutStandardArgsQuantization2.AwqMarlin,
                "bitsandbytes" => DeploymentOutStandardArgsQuantization2.Bitsandbytes,
                "compressed-tensors" => DeploymentOutStandardArgsQuantization2.CompressedTensors,
                "fp8" => DeploymentOutStandardArgsQuantization2.Fp8,
                "gptq" => DeploymentOutStandardArgsQuantization2.Gptq,
                "gptq_marlin" => DeploymentOutStandardArgsQuantization2.GptqMarlin,
                _ => null,
            };
        }
    }
}