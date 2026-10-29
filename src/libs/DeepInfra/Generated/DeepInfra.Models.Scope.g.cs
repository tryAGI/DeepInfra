
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// What an API key may do; a login session may do everything.
    /// </summary>
    public enum Scope
    {
        /// <summary>
        ///
        /// </summary>
        Account_read,
        /// <summary>
        ///
        /// </summary>
        Batch,
        /// <summary>
        ///
        /// </summary>
        Billing,
        /// <summary>
        ///
        /// </summary>
        Compute_containers,
        /// <summary>
        ///
        /// </summary>
        Compute_sandbox,
        /// <summary>
        ///
        /// </summary>
        Deploys,
        /// <summary>
        ///
        /// </summary>
        Inference,
        /// <summary>
        ///
        /// </summary>
        Metrics,
        /// <summary>
        ///
        /// </summary>
        Models,
        /// <summary>
        ///
        /// </summary>
        Unrestricted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Scope value)
        {
            return value switch
            {
                Scope.Account_read => "account:read",
                Scope.Batch => "batch",
                Scope.Billing => "billing",
                Scope.Compute_containers => "compute:containers",
                Scope.Compute_sandbox => "compute:sandbox",
                Scope.Deploys => "deploys",
                Scope.Inference => "inference",
                Scope.Metrics => "metrics",
                Scope.Models => "models",
                Scope.Unrestricted => "unrestricted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Scope? ToEnum(string value)
        {
            return value switch
            {
                "account:read" => Scope.Account_read,
                "batch" => Scope.Batch,
                "billing" => Scope.Billing,
                "compute:containers" => Scope.Compute_containers,
                "compute:sandbox" => Scope.Compute_sandbox,
                "deploys" => Scope.Deploys,
                "inference" => Scope.Inference,
                "metrics" => Scope.Metrics,
                "models" => Scope.Models,
                "unrestricted" => Scope.Unrestricted,
                _ => null,
            };
        }
    }
}