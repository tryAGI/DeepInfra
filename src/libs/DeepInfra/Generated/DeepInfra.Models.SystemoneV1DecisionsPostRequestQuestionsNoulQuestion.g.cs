
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SystemoneV1DecisionsPostRequestQuestionsNoulQuestion
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"noul"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "noul";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.IList<object>> Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestionCriteria? Criteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemoneV1DecisionsPostRequestQuestionsNoulQuestion" /> class.
        /// </summary>
        /// <param name="instructions"></param>
        /// <param name="criteria"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SystemoneV1DecisionsPostRequestQuestionsNoulQuestion(
            global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.IList<object>> instructions,
            global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestionCriteria? criteria,
            string type = "noul")
        {
            this.Type = type;
            this.Instructions = instructions;
            this.Criteria = criteria;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemoneV1DecisionsPostRequestQuestionsNoulQuestion" /> class.
        /// </summary>
        public SystemoneV1DecisionsPostRequestQuestionsNoulQuestion()
        {
        }

    }
}