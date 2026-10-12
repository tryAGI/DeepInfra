
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIEmbeddingsInTask
    {
        /// <summary>
        ///
        /// </summary>
        Classification,
        /// <summary>
        ///
        /// </summary>
        Clustering,
        /// <summary>
        ///
        /// </summary>
        CodeRetrieval,
        /// <summary>
        ///
        /// </summary>
        Document,
        /// <summary>
        ///
        /// </summary>
        FactChecking,
        /// <summary>
        ///
        /// </summary>
        QuestionAnswering,
        /// <summary>
        ///
        /// </summary>
        SearchQuery,
        /// <summary>
        ///
        /// </summary>
        SentenceSimilarity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIEmbeddingsInTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIEmbeddingsInTask value)
        {
            return value switch
            {
                OpenAIEmbeddingsInTask.Classification => "classification",
                OpenAIEmbeddingsInTask.Clustering => "clustering",
                OpenAIEmbeddingsInTask.CodeRetrieval => "code_retrieval",
                OpenAIEmbeddingsInTask.Document => "document",
                OpenAIEmbeddingsInTask.FactChecking => "fact_checking",
                OpenAIEmbeddingsInTask.QuestionAnswering => "question_answering",
                OpenAIEmbeddingsInTask.SearchQuery => "search_query",
                OpenAIEmbeddingsInTask.SentenceSimilarity => "sentence_similarity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIEmbeddingsInTask? ToEnum(string value)
        {
            return value switch
            {
                "classification" => OpenAIEmbeddingsInTask.Classification,
                "clustering" => OpenAIEmbeddingsInTask.Clustering,
                "code_retrieval" => OpenAIEmbeddingsInTask.CodeRetrieval,
                "document" => OpenAIEmbeddingsInTask.Document,
                "fact_checking" => OpenAIEmbeddingsInTask.FactChecking,
                "question_answering" => OpenAIEmbeddingsInTask.QuestionAnswering,
                "search_query" => OpenAIEmbeddingsInTask.SearchQuery,
                "sentence_similarity" => OpenAIEmbeddingsInTask.SentenceSimilarity,
                _ => null,
            };
        }
    }
}