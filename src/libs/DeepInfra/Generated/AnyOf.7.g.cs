using System.Linq;

#nullable enable

namespace System
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnyOf<T1, T2, T3, T4, T5, T6, T7> : global::System.IEquatable<AnyOf<T1, T2, T3, T4, T5, T6, T7>>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T1? Value1 { get; init; }
#else
        public T1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7>(T1 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T1?(AnyOf<T1, T2, T3, T4, T5, T6, T7> @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public AnyOf(T1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T2? Value2 { get; init; }
#else
        public T2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7>(T2 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T2?(AnyOf<T1, T2, T3, T4, T5, T6, T7> @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public AnyOf(T2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T3? Value3 { get; init; }
#else
        public T3? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7>(T3 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T3?(AnyOf<T1, T2, T3, T4, T5, T6, T7> @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public AnyOf(T3? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T4? Value4 { get; init; }
#else
        public T4? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7>(T4 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T4?(AnyOf<T1, T2, T3, T4, T5, T6, T7> @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public AnyOf(T4? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T5? Value5 { get; init; }
#else
        public T5? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7>(T5 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T5?(AnyOf<T1, T2, T3, T4, T5, T6, T7> @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public AnyOf(T5? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T6? Value6 { get; init; }
#else
        public T6? Value6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7>(T6 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T6?(AnyOf<T1, T2, T3, T4, T5, T6, T7> @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public AnyOf(T6? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T7? Value7 { get; init; }
#else
        public T7? Value7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value7))]
#endif
        public bool IsValue7 => Value7 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7>(T7 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T7?(AnyOf<T1, T2, T3, T4, T5, T6, T7> @this) => @this.Value7;

        /// <summary>
        /// 
        /// </summary>
        public AnyOf(T7? value)
        {
            Value7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnyOf(
            T1? value1,
            T2? value2,
            T3? value3,
            T4? value4,
            T5? value5,
            T6? value6,
            T7? value7
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
            Value7 = value7;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value7 as object ??
            Value6 as object ??
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4 || IsValue5 || IsValue6 || IsValue7;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(T1),
                Value2,
                typeof(T2),
                Value3,
                typeof(T3),
                Value4,
                typeof(T4),
                Value5,
                typeof(T5),
                Value6,
                typeof(T6),
                Value7,
                typeof(T7),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(AnyOf<T1, T2, T3, T4, T5, T6, T7> other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<T1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<T2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<T3?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<T4?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<T5?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<T6?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<T7?>.Default.Equals(Value7, other.Value7) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnyOf<T1, T2, T3, T4, T5, T6, T7> obj1, AnyOf<T1, T2, T3, T4, T5, T6, T7> obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnyOf<T1, T2, T3, T4, T5, T6, T7>>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnyOf<T1, T2, T3, T4, T5, T6, T7> obj1, AnyOf<T1, T2, T3, T4, T5, T6, T7> obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnyOf<T1, T2, T3, T4, T5, T6, T7> o && Equals(o);
        }
    }
}