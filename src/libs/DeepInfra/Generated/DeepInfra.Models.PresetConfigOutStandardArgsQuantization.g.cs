
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum PresetConfigOutStandardArgsQuantization
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
    public static class PresetConfigOutStandardArgsQuantizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PresetConfigOutStandardArgsQuantization value)
        {
            return value switch
            {
                PresetConfigOutStandardArgsQuantization.Awq => "awq",
                PresetConfigOutStandardArgsQuantization.AwqMarlin => "awq_marlin",
                PresetConfigOutStandardArgsQuantization.Bitsandbytes => "bitsandbytes",
                PresetConfigOutStandardArgsQuantization.CompressedTensors => "compressed-tensors",
                PresetConfigOutStandardArgsQuantization.Fp8 => "fp8",
                PresetConfigOutStandardArgsQuantization.Gptq => "gptq",
                PresetConfigOutStandardArgsQuantization.GptqMarlin => "gptq_marlin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PresetConfigOutStandardArgsQuantization? ToEnum(string value)
        {
            return value switch
            {
                "awq" => PresetConfigOutStandardArgsQuantization.Awq,
                "awq_marlin" => PresetConfigOutStandardArgsQuantization.AwqMarlin,
                "bitsandbytes" => PresetConfigOutStandardArgsQuantization.Bitsandbytes,
                "compressed-tensors" => PresetConfigOutStandardArgsQuantization.CompressedTensors,
                "fp8" => PresetConfigOutStandardArgsQuantization.Fp8,
                "gptq" => PresetConfigOutStandardArgsQuantization.Gptq,
                "gptq_marlin" => PresetConfigOutStandardArgsQuantization.GptqMarlin,
                _ => null,
            };
        }
    }
}