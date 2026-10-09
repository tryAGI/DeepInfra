
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SystemoneV1DecisionsPostRequestQuestionsNoulQuestionCriteria
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("true")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>))]
        public global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.IList<object>>? True { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("false")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>))]
        public global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.IList<object>>? False { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemoneV1DecisionsPostRequestQuestionsNoulQuestionCriteria" /> class.
        /// </summary>
        /// <param name="true"></param>
        /// <param name="false"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SystemoneV1DecisionsPostRequestQuestionsNoulQuestionCriteria(
            global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.IList<object>>? @true,
            global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.IList<object>>? @false)
        {
            this.True = @true;
            this.False = @false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemoneV1DecisionsPostRequestQuestionsNoulQuestionCriteria" /> class.
        /// </summary>
        public SystemoneV1DecisionsPostRequestQuestionsNoulQuestionCriteria()
        {
        }

    }
}