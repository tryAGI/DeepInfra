
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// What an API key may do. A scope `x` also grants `x:read`; `unrestricted` grants every scope.
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
        AccountScopedJwt,
        /// <summary>
        ///
        /// </summary>
        AccountScopedJwt_read,
        /// <summary>
        ///
        /// </summary>
        Batch,
        /// <summary>
        ///
        /// </summary>
        Billing_read,
        /// <summary>
        ///
        /// </summary>
        Compute_agents,
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
        Inference,
        /// <summary>
        ///
        /// </summary>
        Lora,
        /// <summary>
        ///
        /// </summary>
        Lora_read,
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
        Models_read,
        /// <summary>
        /// read`; `unrestricted` grants every scope.
        /// </summary>
        Unrestricted,
        /// <summary>
        ///
        /// </summary>
        Voice,
        /// <summary>
        ///
        /// </summary>
        Voice_read,
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
                Scope.AccountScopedJwt => "account_scoped_jwt",
                Scope.AccountScopedJwt_read => "account_scoped_jwt:read",
                Scope.Batch => "batch",
                Scope.Billing_read => "billing:read",
                Scope.Compute_agents => "compute:agents",
                Scope.Compute_containers => "compute:containers",
                Scope.Compute_sandbox => "compute:sandbox",
                Scope.Inference => "inference",
                Scope.Lora => "lora",
                Scope.Lora_read => "lora:read",
                Scope.Metrics => "metrics",
                Scope.Models => "models",
                Scope.Models_read => "models:read",
                Scope.Unrestricted => "unrestricted",
                Scope.Voice => "voice",
                Scope.Voice_read => "voice:read",
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
                "account_scoped_jwt" => Scope.AccountScopedJwt,
                "account_scoped_jwt:read" => Scope.AccountScopedJwt_read,
                "batch" => Scope.Batch,
                "billing:read" => Scope.Billing_read,
                "compute:agents" => Scope.Compute_agents,
                "compute:containers" => Scope.Compute_containers,
                "compute:sandbox" => Scope.Compute_sandbox,
                "inference" => Scope.Inference,
                "lora" => Scope.Lora,
                "lora:read" => Scope.Lora_read,
                "metrics" => Scope.Metrics,
                "models" => Scope.Models,
                "models:read" => Scope.Models_read,
                "unrestricted" => Scope.Unrestricted,
                "voice" => Scope.Voice,
                "voice:read" => Scope.Voice_read,
                _ => null,
            };
        }
    }
}