#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Questions : global::System.IEquatable<Questions>
    {
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion? Noul { get; init; }
#else
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion? Noul { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Noul))]
#endif
        public bool IsNoul => Noul != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNoul(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion? value)
        {
            value = Noul;
            return IsNoul;
        }

        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion PickNoul() => Noul is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Noul' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion? Choice { get; init; }
#else
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion? Choice { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Choice))]
#endif
        public bool IsChoice => Choice != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChoice(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion? value)
        {
            value = Choice;
            return IsChoice;
        }

        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion PickChoice() => Choice is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Choice' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion? Score { get; init; }
#else
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion? Score { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Score))]
#endif
        public bool IsScore => Score != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScore(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion? value)
        {
            value = Score;
            return IsScore;
        }

        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion PickScore() => Score is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Score' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Questions(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion value) => new Questions((global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion?(Questions @this) => @this.Noul;

        /// <summary>
        ///
        /// </summary>
        public Questions(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion? value)
        {
            Noul = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Questions FromNoul(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion? value) => new Questions(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Questions(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion value) => new Questions((global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion?(Questions @this) => @this.Choice;

        /// <summary>
        ///
        /// </summary>
        public Questions(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion? value)
        {
            Choice = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Questions FromChoice(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion? value) => new Questions(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Questions(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion value) => new Questions((global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion?(Questions @this) => @this.Score;

        /// <summary>
        ///
        /// </summary>
        public Questions(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion? value)
        {
            Score = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Questions FromScore(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion? value) => new Questions(value);

        /// <summary>
        ///
        /// </summary>
        public Questions(
            global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsDiscriminatorType? type,
            global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion? noul,
            global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion? choice,
            global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion? score
            )
        {
            Type = type;

            Noul = noul;
            Choice = choice;
            Score = score;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Score as object ??
            Choice as object ??
            Noul as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Noul?.ToString() ??
            Choice?.ToString() ??
            Score?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsNoul && !IsChoice && !IsScore || !IsNoul && IsChoice && !IsScore || !IsNoul && !IsChoice && IsScore;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion, TResult>? noul = null,
            global::System.Func<global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion, TResult>? choice = null,
            global::System.Func<global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion, TResult>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Noul is { } __value0 && noul != null)
            {
                return noul(__value0);
            }
            else if (Choice is { } __value1 && choice != null)
            {
                return choice(__value1);
            }
            else if (Score is { } __value2 && score != null)
            {
                return score(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion>? noul = null,

            global::System.Action<global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion>? choice = null,

            global::System.Action<global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Noul is { } __value0)
            {
                noul?.Invoke(__value0);
            }
            else if (Choice is { } __value1)
            {
                choice?.Invoke(__value1);
            }
            else if (Score is { } __value2)
            {
                score?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion>? noul = null,
            global::System.Action<global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion>? choice = null,
            global::System.Action<global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Noul is { } __value0)
            {
                noul?.Invoke(__value0);
            }
            else if (Choice is { } __value1)
            {
                choice?.Invoke(__value1);
            }
            else if (Score is { } __value2)
            {
                score?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Noul,
                typeof(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion),
                Choice,
                typeof(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion),
                Score,
                typeof(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion),
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
        public bool Equals(Questions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion?>.Default.Equals(Noul, other.Noul) &&
                global::System.Collections.Generic.EqualityComparer<global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion?>.Default.Equals(Choice, other.Choice) &&
                global::System.Collections.Generic.EqualityComparer<global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion?>.Default.Equals(Score, other.Score)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Questions obj1, Questions obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Questions>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Questions obj1, Questions obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Questions o && Equals(o);
        }
    }
}
