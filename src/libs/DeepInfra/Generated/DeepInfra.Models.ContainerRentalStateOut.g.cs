
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContainerRentalStateOut
    {
        /// <summary>
        /// 
        /// </summary>
        Creating,
        /// <summary>
        /// 
        /// </summary>
        Starting,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        ShuttingDown,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainerRentalStateOutExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerRentalStateOut value)
        {
            return value switch
            {
                ContainerRentalStateOut.Creating => "creating",
                ContainerRentalStateOut.Starting => "starting",
                ContainerRentalStateOut.Running => "running",
                ContainerRentalStateOut.ShuttingDown => "shutting_down",
                ContainerRentalStateOut.Failed => "failed",
                ContainerRentalStateOut.Deleted => "deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerRentalStateOut? ToEnum(string value)
        {
            return value switch
            {
                "creating" => ContainerRentalStateOut.Creating,
                "starting" => ContainerRentalStateOut.Starting,
                "running" => ContainerRentalStateOut.Running,
                "shutting_down" => ContainerRentalStateOut.ShuttingDown,
                "failed" => ContainerRentalStateOut.Failed,
                "deleted" => ContainerRentalStateOut.Deleted,
                _ => null,
            };
        }
    }
}