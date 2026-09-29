
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Default Value: auto
    /// </summary>
    public enum InputImagePartDetail
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputImagePartDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputImagePartDetail value)
        {
            return value switch
            {
                InputImagePartDetail.Auto => "auto",
                InputImagePartDetail.High => "high",
                InputImagePartDetail.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputImagePartDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => InputImagePartDetail.Auto,
                "high" => InputImagePartDetail.High,
                "low" => InputImagePartDetail.Low,
                _ => null,
            };
        }
    }
}