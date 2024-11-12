
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("months")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepInfra.UsageMonth> Months { get; set; }

        /// <summary>
        /// The first month for this account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_month")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InitialMonth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageOut" /> class.
        /// </summary>
        /// <param name="months"></param>
        /// <param name="initialMonth">
        /// The first month for this account
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UsageOut(
            global::System.Collections.Generic.IList<global::DeepInfra.UsageMonth> months,
            string initialMonth)
        {
            this.Months = months ?? throw new global::System.ArgumentNullException(nameof(months));
            this.InitialMonth = initialMonth ?? throw new global::System.ArgumentNullException(nameof(initialMonth));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageOut" /> class.
        /// </summary>
        public UsageOut()
        {
        }
    }
}