
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeployGPUs
    {
        /// <summary>
        /// 
        /// </summary>
        A10080gb,
        /// <summary>
        /// 
        /// </summary>
        B200180gb,
        /// <summary>
        /// 
        /// </summary>
        B300270gb,
        /// <summary>
        /// 
        /// </summary>
        H10080gb,
        /// <summary>
        /// 
        /// </summary>
        H200141gb,
        /// <summary>
        /// 
        /// </summary>
        L424gb,
        /// <summary>
        /// 
        /// </summary>
        L40s48gb,
        /// <summary>
        /// 
        /// </summary>
        Rtxpro600096gb,
        /// <summary>
        /// 
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeployGPUsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeployGPUs value)
        {
            return value switch
            {
                DeployGPUs.A10080gb => "A100-80GB",
                DeployGPUs.B200180gb => "B200-180GB",
                DeployGPUs.B300270gb => "B300-270GB",
                DeployGPUs.H10080gb => "H100-80GB",
                DeployGPUs.H200141gb => "H200-141GB",
                DeployGPUs.L424gb => "L4-24GB",
                DeployGPUs.L40s48gb => "L40S-48GB",
                DeployGPUs.Rtxpro600096gb => "RTXPRO6000-96GB",
                DeployGPUs.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeployGPUs? ToEnum(string value)
        {
            return value switch
            {
                "A100-80GB" => DeployGPUs.A10080gb,
                "B200-180GB" => DeployGPUs.B200180gb,
                "B300-270GB" => DeployGPUs.B300270gb,
                "H100-80GB" => DeployGPUs.H10080gb,
                "H200-141GB" => DeployGPUs.H200141gb,
                "L4-24GB" => DeployGPUs.L424gb,
                "L40S-48GB" => DeployGPUs.L40s48gb,
                "RTXPRO6000-96GB" => DeployGPUs.Rtxpro600096gb,
                "other" => DeployGPUs.Other,
                _ => null,
            };
        }
    }
}