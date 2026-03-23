
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public enum PricingType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUnits,
        /// <summary>
        /// 
        /// </summary>
        InputCharacterLength,
        /// <summary>
        /// 
        /// </summary>
        InputLength,
        /// <summary>
        /// 
        /// </summary>
        InputTokens,
        /// <summary>
        /// 
        /// </summary>
        OutputLength,
        /// <summary>
        /// 
        /// </summary>
        Time,
        /// <summary>
        /// 
        /// </summary>
        Tokens,
        /// <summary>
        /// 
        /// </summary>
        Uptime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PricingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PricingType value)
        {
            return value switch
            {
                PricingType.ImageUnits => "image_units",
                PricingType.InputCharacterLength => "input_character_length",
                PricingType.InputLength => "input_length",
                PricingType.InputTokens => "input_tokens",
                PricingType.OutputLength => "output_length",
                PricingType.Time => "time",
                PricingType.Tokens => "tokens",
                PricingType.Uptime => "uptime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PricingType? ToEnum(string value)
        {
            return value switch
            {
                "image_units" => PricingType.ImageUnits,
                "input_character_length" => PricingType.InputCharacterLength,
                "input_length" => PricingType.InputLength,
                "input_tokens" => PricingType.InputTokens,
                "output_length" => PricingType.OutputLength,
                "time" => PricingType.Time,
                "tokens" => PricingType.Tokens,
                "uptime" => PricingType.Uptime,
                _ => null,
            };
        }
    }
}