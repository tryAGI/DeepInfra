
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum StandardArgsQuantization2
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
    public static class StandardArgsQuantization2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StandardArgsQuantization2 value)
        {
            return value switch
            {
                StandardArgsQuantization2.Awq => "awq",
                StandardArgsQuantization2.AwqMarlin => "awq_marlin",
                StandardArgsQuantization2.Bitsandbytes => "bitsandbytes",
                StandardArgsQuantization2.CompressedTensors => "compressed-tensors",
                StandardArgsQuantization2.Fp8 => "fp8",
                StandardArgsQuantization2.Gptq => "gptq",
                StandardArgsQuantization2.GptqMarlin => "gptq_marlin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StandardArgsQuantization2? ToEnum(string value)
        {
            return value switch
            {
                "awq" => StandardArgsQuantization2.Awq,
                "awq_marlin" => StandardArgsQuantization2.AwqMarlin,
                "bitsandbytes" => StandardArgsQuantization2.Bitsandbytes,
                "compressed-tensors" => StandardArgsQuantization2.CompressedTensors,
                "fp8" => StandardArgsQuantization2.Fp8,
                "gptq" => StandardArgsQuantization2.Gptq,
                "gptq_marlin" => StandardArgsQuantization2.GptqMarlin,
                _ => null,
            };
        }
    }
}