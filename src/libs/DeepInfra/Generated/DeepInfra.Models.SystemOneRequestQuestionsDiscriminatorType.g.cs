
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum SystemOneRequestQuestionsDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Choice,
        /// <summary>
        ///
        /// </summary>
        Noul,
        /// <summary>
        ///
        /// </summary>
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SystemOneRequestQuestionsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemOneRequestQuestionsDiscriminatorType value)
        {
            return value switch
            {
                SystemOneRequestQuestionsDiscriminatorType.Choice => "choice",
                SystemOneRequestQuestionsDiscriminatorType.Noul => "noul",
                SystemOneRequestQuestionsDiscriminatorType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemOneRequestQuestionsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "choice" => SystemOneRequestQuestionsDiscriminatorType.Choice,
                "noul" => SystemOneRequestQuestionsDiscriminatorType.Noul,
                "score" => SystemOneRequestQuestionsDiscriminatorType.Score,
                _ => null,
            };
        }
    }
}