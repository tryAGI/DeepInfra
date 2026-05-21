
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Which instances to return: active, inactive, or all (both)<br/>
    /// Default Value: active
    /// </summary>
    public enum OpenclawListV1OpenclawGetState
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
    public static class OpenclawListV1OpenclawGetStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenclawListV1OpenclawGetState value)
        {
            return value switch
            {
                OpenclawListV1OpenclawGetState.Active => "active",
                OpenclawListV1OpenclawGetState.All => "all",
                OpenclawListV1OpenclawGetState.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenclawListV1OpenclawGetState? ToEnum(string value)
        {
            return value switch
            {
                "active" => OpenclawListV1OpenclawGetState.Active,
                "all" => OpenclawListV1OpenclawGetState.All,
                "inactive" => OpenclawListV1OpenclawGetState.Inactive,
                _ => null,
            };
        }
    }
}