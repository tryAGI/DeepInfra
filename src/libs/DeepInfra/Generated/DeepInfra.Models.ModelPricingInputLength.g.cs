
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPricingInputLength
    {
        /// <summary>
        /// Short description of the pricing, ideal for cards and headers<br/>
        /// Example: $0.15 / second
        /// </summary>
        /// <example>$0.15 / second</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("short")]
        public string? Short { get; set; }

        /// <summary>
        /// Full description of the pricing, perfect for details<br/>
        /// Example: $0.15 / second for 1080P, $0.10 / second for 720P
        /// </summary>
        /// <example>$0.15 / second for 1080P, $0.10 / second for 720P</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("full")]
        public string? Full { get; set; }

        /// <summary>
        /// Could be used to generate pricing tables<br/>
        /// Example: {"columns":["resolution","$ cost per second"],"rows":[["780P","$0.10"],["1080P","$0.15"]]}
        /// </summary>
        /// <example>{"columns":["resolution","$ cost per second"],"rows":[["780P","$0.10"],["1080P","$0.15"]]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        public object? Table { get; set; }

        /// <summary>
        /// Default Value: input_length
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cents_per_input_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CentsPerInputSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingInputLength" /> class.
        /// </summary>
        /// <param name="short">
        /// Short description of the pricing, ideal for cards and headers<br/>
        /// Example: $0.15 / second
        /// </param>
        /// <param name="full">
        /// Full description of the pricing, perfect for details<br/>
        /// Example: $0.15 / second for 1080P, $0.10 / second for 720P
        /// </param>
        /// <param name="table">
        /// Could be used to generate pricing tables<br/>
        /// Example: {"columns":["resolution","$ cost per second"],"rows":[["780P","$0.10"],["1080P","$0.15"]]}
        /// </param>
        /// <param name="type">
        /// Default Value: input_length
        /// </param>
        /// <param name="centsPerInputSec"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPricingInputLength(
            double centsPerInputSec,
            string? @short,
            string? full,
            object? table,
            string? type)
        {
            this.CentsPerInputSec = centsPerInputSec;
            this.Short = @short;
            this.Full = full;
            this.Table = table;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingInputLength" /> class.
        /// </summary>
        public ModelPricingInputLength()
        {
        }
    }
}