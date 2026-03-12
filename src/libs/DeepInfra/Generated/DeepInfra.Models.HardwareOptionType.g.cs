
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public enum HardwareOptionType
    {
        /// <summary>
        /// 
        /// </summary>
        Serverless,
        /// <summary>
        /// 
        /// </summary>
        Dedicated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HardwareOptionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HardwareOptionType value)
        {
            return value switch
            {
                HardwareOptionType.Serverless => "serverless",
                HardwareOptionType.Dedicated => "dedicated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HardwareOptionType? ToEnum(string value)
        {
            return value switch
            {
                "serverless" => HardwareOptionType.Serverless,
                "dedicated" => HardwareOptionType.Dedicated,
                _ => null,
            };
        }
    }
}