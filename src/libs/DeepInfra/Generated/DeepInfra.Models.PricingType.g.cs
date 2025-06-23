
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
        Tokens,
        /// <summary>
        /// 
        /// </summary>
        Time,
        /// <summary>
        /// 
        /// </summary>
        Uptime,
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
        InputCharacterLength,
        /// <summary>
        /// 
        /// </summary>
        ImageUnits,
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
                PricingType.Tokens => "tokens",
                PricingType.Time => "time",
                PricingType.Uptime => "uptime",
                PricingType.InputLength => "input_length",
                PricingType.InputTokens => "input_tokens",
                PricingType.InputCharacterLength => "input_character_length",
                PricingType.ImageUnits => "image_units",
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
                "tokens" => PricingType.Tokens,
                "time" => PricingType.Time,
                "uptime" => PricingType.Uptime,
                "input_length" => PricingType.InputLength,
                "input_tokens" => PricingType.InputTokens,
                "input_character_length" => PricingType.InputCharacterLength,
                "image_units" => PricingType.ImageUnits,
                _ => null,
            };
        }
    }
}