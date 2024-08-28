
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
        /// <summary>
        /// 
        /// </summary>
        CreateVoiceHttp,
        /// <summary>
        /// 
        /// </summary>
        CreateVoicePython,
        /// <summary>
        /// 
        /// </summary>
        CreateVoiceJs,
        /// <summary>
        /// 
        /// </summary>
        ReadVoiceHttp,
        /// <summary>
        /// 
        /// </summary>
        ReadVoicePython,
        /// <summary>
        /// 
        /// </summary>
        ReadVoiceJs,
        /// <summary>
        /// 
        /// </summary>
        UpdateVoiceHttp,
        /// <summary>
        /// 
        /// </summary>
        UpdateVoicePython,
        /// <summary>
        /// 
        /// </summary>
        UpdateVoiceJs,
        /// <summary>
        /// 
        /// </summary>
        DeleteVoiceHttp,
        /// <summary>
        /// 
        /// </summary>
        DeleteVoicePython,
        /// <summary>
        /// 
        /// </summary>
        DeleteVoiceJs,
        /// <summary>
        /// 
        /// </summary>
        ListVoicesHttp,
        /// <summary>
        /// 
        /// </summary>
        ListVoicesPython,
        /// <summary>
        /// 
        /// </summary>
        ListVoicesJs,
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
                ModelDocBlockKey.CreateVoiceHttp => "create-voice-http",
                ModelDocBlockKey.CreateVoicePython => "create-voice-python",
                ModelDocBlockKey.CreateVoiceJs => "create-voice-js",
                ModelDocBlockKey.ReadVoiceHttp => "read-voice-http",
                ModelDocBlockKey.ReadVoicePython => "read-voice-python",
                ModelDocBlockKey.ReadVoiceJs => "read-voice-js",
                ModelDocBlockKey.UpdateVoiceHttp => "update-voice-http",
                ModelDocBlockKey.UpdateVoicePython => "update-voice-python",
                ModelDocBlockKey.UpdateVoiceJs => "update-voice-js",
                ModelDocBlockKey.DeleteVoiceHttp => "delete-voice-http",
                ModelDocBlockKey.DeleteVoicePython => "delete-voice-python",
                ModelDocBlockKey.DeleteVoiceJs => "delete-voice-js",
                ModelDocBlockKey.ListVoicesHttp => "list-voices-http",
                ModelDocBlockKey.ListVoicesPython => "list-voices-python",
                ModelDocBlockKey.ListVoicesJs => "list-voices-js",
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
                "create-voice-http" => ModelDocBlockKey.CreateVoiceHttp,
                "create-voice-python" => ModelDocBlockKey.CreateVoicePython,
                "create-voice-js" => ModelDocBlockKey.CreateVoiceJs,
                "read-voice-http" => ModelDocBlockKey.ReadVoiceHttp,
                "read-voice-python" => ModelDocBlockKey.ReadVoicePython,
                "read-voice-js" => ModelDocBlockKey.ReadVoiceJs,
                "update-voice-http" => ModelDocBlockKey.UpdateVoiceHttp,
                "update-voice-python" => ModelDocBlockKey.UpdateVoicePython,
                "update-voice-js" => ModelDocBlockKey.UpdateVoiceJs,
                "delete-voice-http" => ModelDocBlockKey.DeleteVoiceHttp,
                "delete-voice-python" => ModelDocBlockKey.DeleteVoicePython,
                "delete-voice-js" => ModelDocBlockKey.DeleteVoiceJs,
                "list-voices-http" => ModelDocBlockKey.ListVoicesHttp,
                "list-voices-python" => ModelDocBlockKey.ListVoicesPython,
                "list-voices-js" => ModelDocBlockKey.ListVoicesJs,
                _ => null,
            };
        }
    }
}