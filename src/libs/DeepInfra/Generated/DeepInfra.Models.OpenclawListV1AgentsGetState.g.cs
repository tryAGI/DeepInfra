
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Which instances to return: active, inactive, or all (both)<br/>
    /// Default Value: active
    /// </summary>
    public enum OpenclawListV1AgentsGetState
    {
        /// <summary>
        /// active, inactive, or all (both)
        /// </summary>
        Active,
        /// <summary>
        /// active, inactive, or all (both)
        /// </summary>
        All,
        /// <summary>
        /// active, inactive, or all (both)
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenclawListV1AgentsGetStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenclawListV1AgentsGetState value)
        {
            return value switch
            {
                OpenclawListV1AgentsGetState.Active => "active",
                OpenclawListV1AgentsGetState.All => "all",
                OpenclawListV1AgentsGetState.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenclawListV1AgentsGetState? ToEnum(string value)
        {
            return value switch
            {
                "active" => OpenclawListV1AgentsGetState.Active,
                "all" => OpenclawListV1AgentsGetState.All,
                "inactive" => OpenclawListV1AgentsGetState.Inactive,
                _ => null,
            };
        }
    }
}