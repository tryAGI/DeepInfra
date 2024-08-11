
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum TtsModel
    {
        /// <summary>
        /// 
        /// </summary>
        DeepinfraTts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsModel value)
        {
            return value switch
            {
                TtsModel.DeepinfraTts => "deepinfra/tts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsModel? ToEnum(string value)
        {
            return value switch
            {
                "deepinfra/tts" => TtsModel.DeepinfraTts,
                _ => null,
            };
        }
    }
}