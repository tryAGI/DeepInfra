
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenClawInstanceState
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
        Starting,
        /// <summary>
        /// 
        /// </summary>
        Stopped,
        /// <summary>
        /// 
        /// </summary>
        Stopping,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenClawInstanceStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenClawInstanceState value)
        {
            return value switch
            {
                OpenClawInstanceState.Creating => "creating",
                OpenClawInstanceState.Deleted => "deleted",
                OpenClawInstanceState.Failed => "failed",
                OpenClawInstanceState.Running => "running",
                OpenClawInstanceState.Starting => "starting",
                OpenClawInstanceState.Stopped => "stopped",
                OpenClawInstanceState.Stopping => "stopping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenClawInstanceState? ToEnum(string value)
        {
            return value switch
            {
                "creating" => OpenClawInstanceState.Creating,
                "deleted" => OpenClawInstanceState.Deleted,
                "failed" => OpenClawInstanceState.Failed,
                "running" => OpenClawInstanceState.Running,
                "starting" => OpenClawInstanceState.Starting,
                "stopped" => OpenClawInstanceState.Stopped,
                "stopping" => OpenClawInstanceState.Stopping,
                _ => null,
            };
        }
    }
}