
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum SystemoneV1DecisionsPostRequestQuestionsDiscriminatorType
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
    public static class SystemoneV1DecisionsPostRequestQuestionsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemoneV1DecisionsPostRequestQuestionsDiscriminatorType value)
        {
            return value switch
            {
                SystemoneV1DecisionsPostRequestQuestionsDiscriminatorType.Choice => "choice",
                SystemoneV1DecisionsPostRequestQuestionsDiscriminatorType.Noul => "noul",
                SystemoneV1DecisionsPostRequestQuestionsDiscriminatorType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemoneV1DecisionsPostRequestQuestionsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "choice" => SystemoneV1DecisionsPostRequestQuestionsDiscriminatorType.Choice,
                "noul" => SystemoneV1DecisionsPostRequestQuestionsDiscriminatorType.Noul,
                "score" => SystemoneV1DecisionsPostRequestQuestionsDiscriminatorType.Score,
                _ => null,
            };
        }
    }
}