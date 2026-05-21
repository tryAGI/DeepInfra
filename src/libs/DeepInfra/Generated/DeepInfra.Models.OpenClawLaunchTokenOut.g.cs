
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenClawLaunchTokenOut
    {
        /// <summary>
        /// Single-use URL that opens the dashboard. Short TTL; mint right before navigating.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dashboard_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DashboardUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenClawLaunchTokenOut" /> class.
        /// </summary>
        /// <param name="dashboardUrl">
        /// Single-use URL that opens the dashboard. Short TTL; mint right before navigating.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenClawLaunchTokenOut(
            string dashboardUrl)
        {
            this.DashboardUrl = dashboardUrl ?? throw new global::System.ArgumentNullException(nameof(dashboardUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenClawLaunchTokenOut" /> class.
        /// </summary>
        public OpenClawLaunchTokenOut()
        {
        }

    }
}