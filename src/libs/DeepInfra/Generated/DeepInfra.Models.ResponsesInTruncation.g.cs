
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesInTruncation
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesInTruncationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesInTruncation value)
        {
            return value switch
            {
                ResponsesInTruncation.Auto => "auto",
                ResponsesInTruncation.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesInTruncation? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponsesInTruncation.Auto,
                "disabled" => ResponsesInTruncation.Disabled,
                _ => null,
            };
        }
    }
}