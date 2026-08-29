
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum PresetConfigOutStandardArgsQuantization2
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
    public static class PresetConfigOutStandardArgsQuantization2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PresetConfigOutStandardArgsQuantization2 value)
        {
            return value switch
            {
                PresetConfigOutStandardArgsQuantization2.Awq => "awq",
                PresetConfigOutStandardArgsQuantization2.AwqMarlin => "awq_marlin",
                PresetConfigOutStandardArgsQuantization2.Bitsandbytes => "bitsandbytes",
                PresetConfigOutStandardArgsQuantization2.CompressedTensors => "compressed-tensors",
                PresetConfigOutStandardArgsQuantization2.Fp8 => "fp8",
                PresetConfigOutStandardArgsQuantization2.Gptq => "gptq",
                PresetConfigOutStandardArgsQuantization2.GptqMarlin => "gptq_marlin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PresetConfigOutStandardArgsQuantization2? ToEnum(string value)
        {
            return value switch
            {
                "awq" => PresetConfigOutStandardArgsQuantization2.Awq,
                "awq_marlin" => PresetConfigOutStandardArgsQuantization2.AwqMarlin,
                "bitsandbytes" => PresetConfigOutStandardArgsQuantization2.Bitsandbytes,
                "compressed-tensors" => PresetConfigOutStandardArgsQuantization2.CompressedTensors,
                "fp8" => PresetConfigOutStandardArgsQuantization2.Fp8,
                "gptq" => PresetConfigOutStandardArgsQuantization2.Gptq,
                "gptq_marlin" => PresetConfigOutStandardArgsQuantization2.GptqMarlin,
                _ => null,
            };
        }
    }
}