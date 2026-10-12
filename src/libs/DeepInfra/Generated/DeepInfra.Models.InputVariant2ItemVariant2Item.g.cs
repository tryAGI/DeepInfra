#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct InputVariant2ItemVariant2Item : global::System.IEquatable<InputVariant2ItemVariant2Item>
    {
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DeepInfra.ChatCompletionContentPartText? Text { get; init; }
#else
        public global::DeepInfra.ChatCompletionContentPartText? Text { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::DeepInfra.ChatCompletionContentPartText? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartText PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DeepInfra.ChatCompletionContentPartImage? ImageUrl { get; init; }
#else
        public global::DeepInfra.ChatCompletionContentPartImage? ImageUrl { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImageUrl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::DeepInfra.ChatCompletionContentPartImage? value)
        {
            value = ImageUrl;
            return IsImageUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartImage PickImageUrl() => ImageUrl is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageUrl' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DeepInfra.ChatCompletionContentPartAudio? AudioUrl1 { get; init; }
#else
        public global::DeepInfra.ChatCompletionContentPartAudio? AudioUrl1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioUrl1))]
#endif
        public bool IsAudioUrl1 => AudioUrl1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudioUrl1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::DeepInfra.ChatCompletionContentPartAudio? value)
        {
            value = AudioUrl1;
            return IsAudioUrl1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartAudio PickAudioUrl1() => AudioUrl1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioUrl1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DeepInfra.ChatCompletionContentPartAudioURL? AudioUrl2 { get; init; }
#else
        public global::DeepInfra.ChatCompletionContentPartAudioURL? AudioUrl2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioUrl2))]
#endif
        public bool IsAudioUrl2 => AudioUrl2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudioUrl2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::DeepInfra.ChatCompletionContentPartAudioURL? value)
        {
            value = AudioUrl2;
            return IsAudioUrl2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartAudioURL PickAudioUrl2() => AudioUrl2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioUrl2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DeepInfra.ChatCompletionContentPartVideo? VideoUrl { get; init; }
#else
        public global::DeepInfra.ChatCompletionContentPartVideo? VideoUrl { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoUrl))]
#endif
        public bool IsVideoUrl => VideoUrl != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVideoUrl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::DeepInfra.ChatCompletionContentPartVideo? value)
        {
            value = VideoUrl;
            return IsVideoUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartVideo PickVideoUrl() => VideoUrl is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoUrl' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputVariant2ItemVariant2Item(global::DeepInfra.ChatCompletionContentPartText value) => new InputVariant2ItemVariant2Item((global::DeepInfra.ChatCompletionContentPartText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::DeepInfra.ChatCompletionContentPartText?(InputVariant2ItemVariant2Item @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public InputVariant2ItemVariant2Item(global::DeepInfra.ChatCompletionContentPartText? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputVariant2ItemVariant2Item FromText(global::DeepInfra.ChatCompletionContentPartText? value) => new InputVariant2ItemVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputVariant2ItemVariant2Item(global::DeepInfra.ChatCompletionContentPartImage value) => new InputVariant2ItemVariant2Item((global::DeepInfra.ChatCompletionContentPartImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::DeepInfra.ChatCompletionContentPartImage?(InputVariant2ItemVariant2Item @this) => @this.ImageUrl;

        /// <summary>
        ///
        /// </summary>
        public InputVariant2ItemVariant2Item(global::DeepInfra.ChatCompletionContentPartImage? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputVariant2ItemVariant2Item FromImageUrl(global::DeepInfra.ChatCompletionContentPartImage? value) => new InputVariant2ItemVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputVariant2ItemVariant2Item(global::DeepInfra.ChatCompletionContentPartAudio value) => new InputVariant2ItemVariant2Item((global::DeepInfra.ChatCompletionContentPartAudio?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::DeepInfra.ChatCompletionContentPartAudio?(InputVariant2ItemVariant2Item @this) => @this.AudioUrl1;

        /// <summary>
        ///
        /// </summary>
        public InputVariant2ItemVariant2Item(global::DeepInfra.ChatCompletionContentPartAudio? value)
        {
            AudioUrl1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputVariant2ItemVariant2Item FromAudioUrl1(global::DeepInfra.ChatCompletionContentPartAudio? value) => new InputVariant2ItemVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputVariant2ItemVariant2Item(global::DeepInfra.ChatCompletionContentPartAudioURL value) => new InputVariant2ItemVariant2Item((global::DeepInfra.ChatCompletionContentPartAudioURL?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::DeepInfra.ChatCompletionContentPartAudioURL?(InputVariant2ItemVariant2Item @this) => @this.AudioUrl2;

        /// <summary>
        ///
        /// </summary>
        public InputVariant2ItemVariant2Item(global::DeepInfra.ChatCompletionContentPartAudioURL? value)
        {
            AudioUrl2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputVariant2ItemVariant2Item FromAudioUrl2(global::DeepInfra.ChatCompletionContentPartAudioURL? value) => new InputVariant2ItemVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputVariant2ItemVariant2Item(global::DeepInfra.ChatCompletionContentPartVideo value) => new InputVariant2ItemVariant2Item((global::DeepInfra.ChatCompletionContentPartVideo?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::DeepInfra.ChatCompletionContentPartVideo?(InputVariant2ItemVariant2Item @this) => @this.VideoUrl;

        /// <summary>
        ///
        /// </summary>
        public InputVariant2ItemVariant2Item(global::DeepInfra.ChatCompletionContentPartVideo? value)
        {
            VideoUrl = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputVariant2ItemVariant2Item FromVideoUrl(global::DeepInfra.ChatCompletionContentPartVideo? value) => new InputVariant2ItemVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public InputVariant2ItemVariant2Item(
            global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType? type,
            global::DeepInfra.ChatCompletionContentPartText? text,
            global::DeepInfra.ChatCompletionContentPartImage? imageUrl,
            global::DeepInfra.ChatCompletionContentPartAudio? audioUrl1,
            global::DeepInfra.ChatCompletionContentPartAudioURL? audioUrl2,
            global::DeepInfra.ChatCompletionContentPartVideo? videoUrl
            )
        {
            Type = type;

            Text = text;
            ImageUrl = imageUrl;
            AudioUrl1 = audioUrl1;
            AudioUrl2 = audioUrl2;
            VideoUrl = videoUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            VideoUrl as object ??
            AudioUrl2 as object ??
            AudioUrl1 as object ??
            ImageUrl as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ImageUrl?.ToString() ??
            AudioUrl1?.ToString() ??
            AudioUrl2?.ToString() ??
            VideoUrl?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImageUrl && !IsAudioUrl1 && !IsAudioUrl2 && !IsVideoUrl || !IsText && IsImageUrl && !IsAudioUrl1 && !IsAudioUrl2 && !IsVideoUrl || !IsText && !IsImageUrl && IsAudioUrl1 && !IsAudioUrl2 && !IsVideoUrl || !IsText && !IsImageUrl && !IsAudioUrl1 && IsAudioUrl2 && !IsVideoUrl || !IsText && !IsImageUrl && !IsAudioUrl1 && !IsAudioUrl2 && IsVideoUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::DeepInfra.ChatCompletionContentPartText, TResult>? text = null,
            global::System.Func<global::DeepInfra.ChatCompletionContentPartImage, TResult>? imageUrl = null,
            global::System.Func<global::DeepInfra.ChatCompletionContentPartAudio, TResult>? audioUrl1 = null,
            global::System.Func<global::DeepInfra.ChatCompletionContentPartAudioURL, TResult>? audioUrl2 = null,
            global::System.Func<global::DeepInfra.ChatCompletionContentPartVideo, TResult>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }
            else if (ImageUrl is { } __value1 && imageUrl != null)
            {
                return imageUrl(__value1);
            }
            else if (AudioUrl1 is { } __value2 && audioUrl1 != null)
            {
                return audioUrl1(__value2);
            }
            else if (AudioUrl2 is { } __value3 && audioUrl2 != null)
            {
                return audioUrl2(__value3);
            }
            else if (VideoUrl is { } __value4 && videoUrl != null)
            {
                return videoUrl(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::DeepInfra.ChatCompletionContentPartText>? text = null,

            global::System.Action<global::DeepInfra.ChatCompletionContentPartImage>? imageUrl = null,

            global::System.Action<global::DeepInfra.ChatCompletionContentPartAudio>? audioUrl1 = null,

            global::System.Action<global::DeepInfra.ChatCompletionContentPartAudioURL>? audioUrl2 = null,

            global::System.Action<global::DeepInfra.ChatCompletionContentPartVideo>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (ImageUrl is { } __value1)
            {
                imageUrl?.Invoke(__value1);
            }
            else if (AudioUrl1 is { } __value2)
            {
                audioUrl1?.Invoke(__value2);
            }
            else if (AudioUrl2 is { } __value3)
            {
                audioUrl2?.Invoke(__value3);
            }
            else if (VideoUrl is { } __value4)
            {
                videoUrl?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::DeepInfra.ChatCompletionContentPartText>? text = null,
            global::System.Action<global::DeepInfra.ChatCompletionContentPartImage>? imageUrl = null,
            global::System.Action<global::DeepInfra.ChatCompletionContentPartAudio>? audioUrl1 = null,
            global::System.Action<global::DeepInfra.ChatCompletionContentPartAudioURL>? audioUrl2 = null,
            global::System.Action<global::DeepInfra.ChatCompletionContentPartVideo>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (ImageUrl is { } __value1)
            {
                imageUrl?.Invoke(__value1);
            }
            else if (AudioUrl1 is { } __value2)
            {
                audioUrl1?.Invoke(__value2);
            }
            else if (AudioUrl2 is { } __value3)
            {
                audioUrl2?.Invoke(__value3);
            }
            else if (VideoUrl is { } __value4)
            {
                videoUrl?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::DeepInfra.ChatCompletionContentPartText),
                ImageUrl,
                typeof(global::DeepInfra.ChatCompletionContentPartImage),
                AudioUrl1,
                typeof(global::DeepInfra.ChatCompletionContentPartAudio),
                AudioUrl2,
                typeof(global::DeepInfra.ChatCompletionContentPartAudioURL),
                VideoUrl,
                typeof(global::DeepInfra.ChatCompletionContentPartVideo),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(InputVariant2ItemVariant2Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::DeepInfra.ChatCompletionContentPartText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::DeepInfra.ChatCompletionContentPartImage?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::DeepInfra.ChatCompletionContentPartAudio?>.Default.Equals(AudioUrl1, other.AudioUrl1) &&
                global::System.Collections.Generic.EqualityComparer<global::DeepInfra.ChatCompletionContentPartAudioURL?>.Default.Equals(AudioUrl2, other.AudioUrl2) &&
                global::System.Collections.Generic.EqualityComparer<global::DeepInfra.ChatCompletionContentPartVideo?>.Default.Equals(VideoUrl, other.VideoUrl)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(InputVariant2ItemVariant2Item obj1, InputVariant2ItemVariant2Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputVariant2ItemVariant2Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InputVariant2ItemVariant2Item obj1, InputVariant2ItemVariant2Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputVariant2ItemVariant2Item o && Equals(o);
        }
    }
}
