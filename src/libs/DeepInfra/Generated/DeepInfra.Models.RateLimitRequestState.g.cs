
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// What an account is shown for one of its own requests.
    /// </summary>
    public enum RateLimitRequestState
    {
        /// <summary>
        ///
        /// </summary>
        Approved,
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Closed,
        /// <summary>
        ///
        /// </summary>
        Declined,
        /// <summary>
        ///
        /// </summary>
        Expired,
        /// <summary>
        ///
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RateLimitRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RateLimitRequestState value)
        {
            return value switch
            {
                RateLimitRequestState.Approved => "approved",
                RateLimitRequestState.Cancelled => "cancelled",
                RateLimitRequestState.Closed => "closed",
                RateLimitRequestState.Declined => "declined",
                RateLimitRequestState.Expired => "expired",
                RateLimitRequestState.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RateLimitRequestState? ToEnum(string value)
        {
            return value switch
            {
                "approved" => RateLimitRequestState.Approved,
                "cancelled" => RateLimitRequestState.Cancelled,
                "closed" => RateLimitRequestState.Closed,
                "declined" => RateLimitRequestState.Declined,
                "expired" => RateLimitRequestState.Expired,
                "pending" => RateLimitRequestState.Pending,
                _ => null,
            };
        }
    }
}