
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum ModelDocBlockKey
    {
        /// <summary>
        /// 
        /// </summary>
        Http,
        /// <summary>
        /// 
        /// </summary>
        Deepctl,
        /// <summary>
        /// 
        /// </summary>
        JsTextGen,
        /// <summary>
        /// 
        /// </summary>
        JsEmb,
        /// <summary>
        /// 
        /// </summary>
        JsTextToImg,
        /// <summary>
        /// 
        /// </summary>
        JsSpeechToText,
        /// <summary>
        /// 
        /// </summary>
        OpenaiPython,
        /// <summary>
        /// 
        /// </summary>
        OpenaiHttp,
        /// <summary>
        /// 
        /// </summary>
        OpenaiJs,
        /// <summary>
        /// 
        /// </summary>
        OpenaiCompPython,
        /// <summary>
        /// 
        /// </summary>
        OpenaiCompHttp,
        /// <summary>
        /// 
        /// </summary>
        OpenaiCompJs,
        /// <summary>
        /// 
        /// </summary>
        OpenaiEmbPy,
        /// <summary>
        /// 
        /// </summary>
        OpenaiEmbHttp,
        /// <summary>
        /// 
        /// </summary>
        OpenaiEmbJs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelDocBlockKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelDocBlockKey value)
        {
            return value switch
            {
                ModelDocBlockKey.Http => "http",
                ModelDocBlockKey.Deepctl => "deepctl",
                ModelDocBlockKey.JsTextGen => "js-text-gen",
                ModelDocBlockKey.JsEmb => "js-emb",
                ModelDocBlockKey.JsTextToImg => "js-text-to-img",
                ModelDocBlockKey.JsSpeechToText => "js-speech-to-text",
                ModelDocBlockKey.OpenaiPython => "openai-python",
                ModelDocBlockKey.OpenaiHttp => "openai-http",
                ModelDocBlockKey.OpenaiJs => "openai-js",
                ModelDocBlockKey.OpenaiCompPython => "openai-comp-python",
                ModelDocBlockKey.OpenaiCompHttp => "openai-comp-http",
                ModelDocBlockKey.OpenaiCompJs => "openai-comp-js",
                ModelDocBlockKey.OpenaiEmbPy => "openai-emb-py",
                ModelDocBlockKey.OpenaiEmbHttp => "openai-emb-http",
                ModelDocBlockKey.OpenaiEmbJs => "openai-emb-js",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelDocBlockKey? ToEnum(string value)
        {
            return value switch
            {
                "http" => ModelDocBlockKey.Http,
                "deepctl" => ModelDocBlockKey.Deepctl,
                "js-text-gen" => ModelDocBlockKey.JsTextGen,
                "js-emb" => ModelDocBlockKey.JsEmb,
                "js-text-to-img" => ModelDocBlockKey.JsTextToImg,
                "js-speech-to-text" => ModelDocBlockKey.JsSpeechToText,
                "openai-python" => ModelDocBlockKey.OpenaiPython,
                "openai-http" => ModelDocBlockKey.OpenaiHttp,
                "openai-js" => ModelDocBlockKey.OpenaiJs,
                "openai-comp-python" => ModelDocBlockKey.OpenaiCompPython,
                "openai-comp-http" => ModelDocBlockKey.OpenaiCompHttp,
                "openai-comp-js" => ModelDocBlockKey.OpenaiCompJs,
                "openai-emb-py" => ModelDocBlockKey.OpenaiEmbPy,
                "openai-emb-http" => ModelDocBlockKey.OpenaiEmbHttp,
                "openai-emb-js" => ModelDocBlockKey.OpenaiEmbJs,
                _ => null,
            };
        }
    }
}