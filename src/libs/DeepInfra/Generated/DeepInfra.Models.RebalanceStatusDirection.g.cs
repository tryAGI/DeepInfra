
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Whether this deployment is the source or the target.
    /// </summary>
    public enum RebalanceStatusDirection
    {
        /// <summary>
        ///
        /// </summary>
        Incoming,
        /// <summary>
        ///
        /// </summary>
        Outgoing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RebalanceStatusDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RebalanceStatusDirection value)
        {
            return value switch
            {
                RebalanceStatusDirection.Incoming => "incoming",
                RebalanceStatusDirection.Outgoing => "outgoing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RebalanceStatusDirection? ToEnum(string value)
        {
            return value switch
            {
                "incoming" => RebalanceStatusDirection.Incoming,
                "outgoing" => RebalanceStatusDirection.Outgoing,
                _ => null,
            };
        }
    }
}