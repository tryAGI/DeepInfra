
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum InceptionMemberCheckStatus
    {
        /// <summary>
        ///
        /// </summary>
        BenefitApproved,
        /// <summary>
        ///
        /// </summary>
        BenefitNotApproved,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        InvalidWebsite,
        /// <summary>
        ///
        /// </summary>
        NotMember,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InceptionMemberCheckStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InceptionMemberCheckStatus value)
        {
            return value switch
            {
                InceptionMemberCheckStatus.BenefitApproved => "benefit_approved",
                InceptionMemberCheckStatus.BenefitNotApproved => "benefit_not_approved",
                InceptionMemberCheckStatus.Error => "error",
                InceptionMemberCheckStatus.InvalidWebsite => "invalid_website",
                InceptionMemberCheckStatus.NotMember => "not_member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InceptionMemberCheckStatus? ToEnum(string value)
        {
            return value switch
            {
                "benefit_approved" => InceptionMemberCheckStatus.BenefitApproved,
                "benefit_not_approved" => InceptionMemberCheckStatus.BenefitNotApproved,
                "error" => InceptionMemberCheckStatus.Error,
                "invalid_website" => InceptionMemberCheckStatus.InvalidWebsite,
                "not_member" => InceptionMemberCheckStatus.NotMember,
                _ => null,
            };
        }
    }
}