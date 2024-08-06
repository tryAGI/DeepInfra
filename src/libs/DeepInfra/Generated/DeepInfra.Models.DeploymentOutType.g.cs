
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum DeploymentOutType
    {
        /// <summary>
        /// 
        /// </summary>
        Legacy,
        /// <summary>
        /// 
        /// </summary>
        Llm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentOutTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentOutType value)
        {
            return value switch
            {
                DeploymentOutType.Legacy => "legacy",
                DeploymentOutType.Llm => "llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentOutType? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => DeploymentOutType.Legacy,
                "llm" => DeploymentOutType.Llm,
                _ => null,
            };
        }
    }
}