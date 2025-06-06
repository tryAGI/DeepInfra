
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public enum SourceTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Civitai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SourceTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SourceTypeEnum value)
        {
            return value switch
            {
                SourceTypeEnum.Civitai => "civitai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SourceTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "civitai" => SourceTypeEnum.Civitai,
                _ => null,
            };
        }
    }
}