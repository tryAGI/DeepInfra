
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentInstanceState
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
    public static class AgentInstanceStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentInstanceState value)
        {
            return value switch
            {
                AgentInstanceState.Creating => "creating",
                AgentInstanceState.Deleted => "deleted",
                AgentInstanceState.Failed => "failed",
                AgentInstanceState.Running => "running",
                AgentInstanceState.Starting => "starting",
                AgentInstanceState.Stopped => "stopped",
                AgentInstanceState.Stopping => "stopping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentInstanceState? ToEnum(string value)
        {
            return value switch
            {
                "creating" => AgentInstanceState.Creating,
                "deleted" => AgentInstanceState.Deleted,
                "failed" => AgentInstanceState.Failed,
                "running" => AgentInstanceState.Running,
                "starting" => AgentInstanceState.Starting,
                "stopped" => AgentInstanceState.Stopped,
                "stopping" => AgentInstanceState.Stopping,
                _ => null,
            };
        }
    }
}