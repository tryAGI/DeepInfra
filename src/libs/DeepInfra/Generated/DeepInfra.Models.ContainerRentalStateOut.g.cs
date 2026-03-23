
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
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Failed,
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
        Starting,
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
                ContainerRentalStateOut.Deleted => "deleted",
                ContainerRentalStateOut.Failed => "failed",
                ContainerRentalStateOut.Running => "running",
                ContainerRentalStateOut.ShuttingDown => "shutting_down",
                ContainerRentalStateOut.Starting => "starting",
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
                "deleted" => ContainerRentalStateOut.Deleted,
                "failed" => ContainerRentalStateOut.Failed,
                "running" => ContainerRentalStateOut.Running,
                "shutting_down" => ContainerRentalStateOut.ShuttingDown,
                "starting" => ContainerRentalStateOut.Starting,
                _ => null,
            };
        }
    }
}