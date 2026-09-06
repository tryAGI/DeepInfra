
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum StandardArgsQuantization
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
    public static class StandardArgsQuantizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StandardArgsQuantization value)
        {
            return value switch
            {
                StandardArgsQuantization.Awq => "awq",
                StandardArgsQuantization.AwqMarlin => "awq_marlin",
                StandardArgsQuantization.Bitsandbytes => "bitsandbytes",
                StandardArgsQuantization.CompressedTensors => "compressed-tensors",
                StandardArgsQuantization.Fp8 => "fp8",
                StandardArgsQuantization.Gptq => "gptq",
                StandardArgsQuantization.GptqMarlin => "gptq_marlin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StandardArgsQuantization? ToEnum(string value)
        {
            return value switch
            {
                "awq" => StandardArgsQuantization.Awq,
                "awq_marlin" => StandardArgsQuantization.AwqMarlin,
                "bitsandbytes" => StandardArgsQuantization.Bitsandbytes,
                "compressed-tensors" => StandardArgsQuantization.CompressedTensors,
                "fp8" => StandardArgsQuantization.Fp8,
                "gptq" => StandardArgsQuantization.Gptq,
                "gptq_marlin" => StandardArgsQuantization.GptqMarlin,
                _ => null,
            };
        }
    }
}