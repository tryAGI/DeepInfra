
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SystemoneV1DecisionsPostRequestQuestionsDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.SystemoneV1DecisionsPostRequestQuestionsDiscriminatorTypeJsonConverter))]
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemoneV1DecisionsPostRequestQuestionsDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SystemoneV1DecisionsPostRequestQuestionsDiscriminator(
            global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemoneV1DecisionsPostRequestQuestionsDiscriminator" /> class.
        /// </summary>
        public SystemoneV1DecisionsPostRequestQuestionsDiscriminator()
        {
        }

    }
}