
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum ModelMetaInReportedType
    {
        /// <summary>
        /// 
        /// </summary>
        AutomaticSpeechRecognition,
        /// <summary>
        /// 
        /// </summary>
        ImageClassification,
        /// <summary>
        /// 
        /// </summary>
        QuestionAnswering,
        /// <summary>
        /// 
        /// </summary>
        TokenClassification,
        /// <summary>
        /// 
        /// </summary>
        TextToImage,
        /// <summary>
        /// 
        /// </summary>
        FillMask,
        /// <summary>
        /// 
        /// </summary>
        ZeroShotImageClassification,
        /// <summary>
        /// 
        /// </summary>
        Text2textGeneration,
        /// <summary>
        /// 
        /// </summary>
        TextGeneration,
        /// <summary>
        /// 
        /// </summary>
        TextClassification,
        /// <summary>
        /// 
        /// </summary>
        ObjectDetection,
        /// <summary>
        /// 
        /// </summary>
        Embeddings,
        /// <summary>
        /// 
        /// </summary>
        Dreambooth,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        TextToSpeech,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelMetaInReportedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelMetaInReportedType value)
        {
            return value switch
            {
                ModelMetaInReportedType.AutomaticSpeechRecognition => "automatic-speech-recognition",
                ModelMetaInReportedType.ImageClassification => "image-classification",
                ModelMetaInReportedType.QuestionAnswering => "question-answering",
                ModelMetaInReportedType.TokenClassification => "token-classification",
                ModelMetaInReportedType.TextToImage => "text-to-image",
                ModelMetaInReportedType.FillMask => "fill-mask",
                ModelMetaInReportedType.ZeroShotImageClassification => "zero-shot-image-classification",
                ModelMetaInReportedType.Text2textGeneration => "text2text-generation",
                ModelMetaInReportedType.TextGeneration => "text-generation",
                ModelMetaInReportedType.TextClassification => "text-classification",
                ModelMetaInReportedType.ObjectDetection => "object-detection",
                ModelMetaInReportedType.Embeddings => "embeddings",
                ModelMetaInReportedType.Dreambooth => "dreambooth",
                ModelMetaInReportedType.Custom => "custom",
                ModelMetaInReportedType.TextToSpeech => "text-to-speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelMetaInReportedType? ToEnum(string value)
        {
            return value switch
            {
                "automatic-speech-recognition" => ModelMetaInReportedType.AutomaticSpeechRecognition,
                "image-classification" => ModelMetaInReportedType.ImageClassification,
                "question-answering" => ModelMetaInReportedType.QuestionAnswering,
                "token-classification" => ModelMetaInReportedType.TokenClassification,
                "text-to-image" => ModelMetaInReportedType.TextToImage,
                "fill-mask" => ModelMetaInReportedType.FillMask,
                "zero-shot-image-classification" => ModelMetaInReportedType.ZeroShotImageClassification,
                "text2text-generation" => ModelMetaInReportedType.Text2textGeneration,
                "text-generation" => ModelMetaInReportedType.TextGeneration,
                "text-classification" => ModelMetaInReportedType.TextClassification,
                "object-detection" => ModelMetaInReportedType.ObjectDetection,
                "embeddings" => ModelMetaInReportedType.Embeddings,
                "dreambooth" => ModelMetaInReportedType.Dreambooth,
                "custom" => ModelMetaInReportedType.Custom,
                "text-to-speech" => ModelMetaInReportedType.TextToSpeech,
                _ => null,
            };
        }
    }
}