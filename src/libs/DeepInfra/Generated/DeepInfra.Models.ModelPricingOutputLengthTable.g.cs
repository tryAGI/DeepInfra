
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Could be used to generate pricing tables<br/>
    /// Example: {"columns":["resolution","$ cost per second"],"rows":[["780P","$0.10"],["1080P","$0.15"]]}
    /// </summary>
    public sealed partial class ModelPricingOutputLengthTable
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}