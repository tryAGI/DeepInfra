
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// whether to return active or inactive containers<br/>
    /// Default Value: active
    /// </summary>
    public enum ContainerRentalsListV1ContainersGetState
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainerRentalsListV1ContainersGetStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerRentalsListV1ContainersGetState value)
        {
            return value switch
            {
                ContainerRentalsListV1ContainersGetState.Active => "active",
                ContainerRentalsListV1ContainersGetState.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerRentalsListV1ContainersGetState? ToEnum(string value)
        {
            return value switch
            {
                "active" => ContainerRentalsListV1ContainersGetState.Active,
                "inactive" => ContainerRentalsListV1ContainersGetState.Inactive,
                _ => null,
            };
        }
    }
}