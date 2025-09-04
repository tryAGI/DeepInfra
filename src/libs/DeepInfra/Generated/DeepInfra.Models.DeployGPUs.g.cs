
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
        L424GB,
        /// <summary>
        /// 
        /// </summary>
        L40S48GB,
        /// <summary>
        /// 
        /// </summary>
        A10080GB,
        /// <summary>
        /// 
        /// </summary>
        H10080GB,
        /// <summary>
        /// 
        /// </summary>
        H200141GB,
        /// <summary>
        /// 
        /// </summary>
        B200180GB,
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
                DeployGPUs.L424GB => "L4-24GB",
                DeployGPUs.L40S48GB => "L40S-48GB",
                DeployGPUs.A10080GB => "A100-80GB",
                DeployGPUs.H10080GB => "H100-80GB",
                DeployGPUs.H200141GB => "H200-141GB",
                DeployGPUs.B200180GB => "B200-180GB",
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
                "L4-24GB" => DeployGPUs.L424GB,
                "L40S-48GB" => DeployGPUs.L40S48GB,
                "A100-80GB" => DeployGPUs.A10080GB,
                "H100-80GB" => DeployGPUs.H10080GB,
                "H200-141GB" => DeployGPUs.H200141GB,
                "B200-180GB" => DeployGPUs.B200180GB,
                "other" => DeployGPUs.Other,
                _ => null,
            };
        }
    }
}