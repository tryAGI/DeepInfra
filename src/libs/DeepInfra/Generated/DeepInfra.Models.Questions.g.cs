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
        public global::DeepInfra.SystemOneRequestQuestionsDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DeepInfra.NoulQuestion? Noul { get; init; }
#else
        public global::DeepInfra.NoulQuestion? Noul { get; }
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
            out global::DeepInfra.NoulQuestion? value)
        {
            value = Noul;
            return IsNoul;
        }

        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.NoulQuestion PickNoul() => IsNoul
            ? Noul!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Noul' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DeepInfra.ChoiceQuestion? Choice { get; init; }
#else
        public global::DeepInfra.ChoiceQuestion? Choice { get; }
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
            out global::DeepInfra.ChoiceQuestion? value)
        {
            value = Choice;
            return IsChoice;
        }

        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChoiceQuestion PickChoice() => IsChoice
            ? Choice!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Choice' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DeepInfra.ScoreQuestion? Score { get; init; }
#else
        public global::DeepInfra.ScoreQuestion? Score { get; }
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
            out global::DeepInfra.ScoreQuestion? value)
        {
            value = Score;
            return IsScore;
        }

        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ScoreQuestion PickScore() => IsScore
            ? Score!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Score' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Questions(global::DeepInfra.NoulQuestion value) => new Questions((global::DeepInfra.NoulQuestion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::DeepInfra.NoulQuestion?(Questions @this) => @this.Noul;

        /// <summary>
        ///
        /// </summary>
        public Questions(global::DeepInfra.NoulQuestion? value)
        {
            Noul = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Questions FromNoul(global::DeepInfra.NoulQuestion? value) => new Questions(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Questions(global::DeepInfra.ChoiceQuestion value) => new Questions((global::DeepInfra.ChoiceQuestion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::DeepInfra.ChoiceQuestion?(Questions @this) => @this.Choice;

        /// <summary>
        ///
        /// </summary>
        public Questions(global::DeepInfra.ChoiceQuestion? value)
        {
            Choice = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Questions FromChoice(global::DeepInfra.ChoiceQuestion? value) => new Questions(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Questions(global::DeepInfra.ScoreQuestion value) => new Questions((global::DeepInfra.ScoreQuestion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::DeepInfra.ScoreQuestion?(Questions @this) => @this.Score;

        /// <summary>
        ///
        /// </summary>
        public Questions(global::DeepInfra.ScoreQuestion? value)
        {
            Score = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Questions FromScore(global::DeepInfra.ScoreQuestion? value) => new Questions(value);

        /// <summary>
        ///
        /// </summary>
        public Questions(
            global::DeepInfra.SystemOneRequestQuestionsDiscriminatorType? type,
            global::DeepInfra.NoulQuestion? noul,
            global::DeepInfra.ChoiceQuestion? choice,
            global::DeepInfra.ScoreQuestion? score
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
            global::System.Func<global::DeepInfra.NoulQuestion, TResult>? noul = null,
            global::System.Func<global::DeepInfra.ChoiceQuestion, TResult>? choice = null,
            global::System.Func<global::DeepInfra.ScoreQuestion, TResult>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNoul && noul != null)
            {
                return noul(Noul!);
            }
            else if (IsChoice && choice != null)
            {
                return choice(Choice!);
            }
            else if (IsScore && score != null)
            {
                return score(Score!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::DeepInfra.NoulQuestion>? noul = null,

            global::System.Action<global::DeepInfra.ChoiceQuestion>? choice = null,

            global::System.Action<global::DeepInfra.ScoreQuestion>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNoul)
            {
                noul?.Invoke(Noul!);
            }
            else if (IsChoice)
            {
                choice?.Invoke(Choice!);
            }
            else if (IsScore)
            {
                score?.Invoke(Score!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::DeepInfra.NoulQuestion>? noul = null,
            global::System.Action<global::DeepInfra.ChoiceQuestion>? choice = null,
            global::System.Action<global::DeepInfra.ScoreQuestion>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNoul)
            {
                noul?.Invoke(Noul!);
            }
            else if (IsChoice)
            {
                choice?.Invoke(Choice!);
            }
            else if (IsScore)
            {
                score?.Invoke(Score!);
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
                typeof(global::DeepInfra.NoulQuestion),
                Choice,
                typeof(global::DeepInfra.ChoiceQuestion),
                Score,
                typeof(global::DeepInfra.ScoreQuestion),
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
                global::System.Collections.Generic.EqualityComparer<global::DeepInfra.NoulQuestion?>.Default.Equals(Noul, other.Noul) &&
                global::System.Collections.Generic.EqualityComparer<global::DeepInfra.ChoiceQuestion?>.Default.Equals(Choice, other.Choice) &&
                global::System.Collections.Generic.EqualityComparer<global::DeepInfra.ScoreQuestion?>.Default.Equals(Score, other.Score)
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
