
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum DeployModelInProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Huggingface,
        /// <summary>
        /// 
        /// </summary>
        Deepinfra,
        /// <summary>
        /// 
        /// </summary>
        Cnt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeployModelInProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeployModelInProvider value)
        {
            return value switch
            {
                DeployModelInProvider.Huggingface => "huggingface",
                DeployModelInProvider.Deepinfra => "deepinfra",
                DeployModelInProvider.Cnt => "cnt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeployModelInProvider? ToEnum(string value)
        {
            return value switch
            {
                "huggingface" => DeployModelInProvider.Huggingface,
                "deepinfra" => DeployModelInProvider.Deepinfra,
                "cnt" => DeployModelInProvider.Cnt,
                _ => null,
            };
        }
    }
}