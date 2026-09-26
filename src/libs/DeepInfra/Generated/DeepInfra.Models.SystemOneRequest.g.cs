
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SystemOneRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.IList<object>> State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("questions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Questions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemOneRequest" /> class.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="model"></param>
        /// <param name="questions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SystemOneRequest(
            global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.IList<object>> state,
            string model,
            object questions)
        {
            this.State = state;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Questions = questions ?? throw new global::System.ArgumentNullException(nameof(questions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemOneRequest" /> class.
        /// </summary>
        public SystemOneRequest()
        {
        }

    }
}