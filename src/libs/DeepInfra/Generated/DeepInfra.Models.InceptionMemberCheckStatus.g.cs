
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum InceptionMemberCheckStatus
    {
        /// <summary>
        ///
        /// </summary>
        Approved,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InceptionMemberCheckStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InceptionMemberCheckStatus value)
        {
            return value switch
            {
                InceptionMemberCheckStatus.Approved => "approved",
                InceptionMemberCheckStatus.Error => "error",
                InceptionMemberCheckStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InceptionMemberCheckStatus? ToEnum(string value)
        {
            return value switch
            {
                "approved" => InceptionMemberCheckStatus.Approved,
                "error" => InceptionMemberCheckStatus.Error,
                "rejected" => InceptionMemberCheckStatus.Rejected,
                _ => null,
            };
        }
    }
}