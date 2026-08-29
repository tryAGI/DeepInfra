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
        public global::DeepInfra.ChatCompletionContentPartText PickText() => IsText
            ? Text!
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
        public global::DeepInfra.ChatCompletionContentPartImage PickImageUrl() => IsImageUrl
            ? ImageUrl!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageUrl' but the value was {ToString()}.");
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
        public InputVariant2ItemVariant2Item(
            global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType? type,
            global::DeepInfra.ChatCompletionContentPartText? text,
            global::DeepInfra.ChatCompletionContentPartImage? imageUrl
            )
        {
            Type = type;

            Text = text;
            ImageUrl = imageUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ImageUrl as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ImageUrl?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImageUrl || !IsText && IsImageUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::DeepInfra.ChatCompletionContentPartText, TResult>? text = null,
            global::System.Func<global::DeepInfra.ChatCompletionContentPartImage, TResult>? imageUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::DeepInfra.ChatCompletionContentPartText>? text = null,

            global::System.Action<global::DeepInfra.ChatCompletionContentPartImage>? imageUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::DeepInfra.ChatCompletionContentPartText>? text = null,
            global::System.Action<global::DeepInfra.ChatCompletionContentPartImage>? imageUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
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
                global::System.Collections.Generic.EqualityComparer<global::DeepInfra.ChatCompletionContentPartImage?>.Default.Equals(ImageUrl, other.ImageUrl)
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
