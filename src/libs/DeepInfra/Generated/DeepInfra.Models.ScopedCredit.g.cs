
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// A credit spendable only on certain models, with what is left of it.<br/>
    /// Backed by a capped discount rather than a balance, so `remaining_cents` is<br/>
    /// the cap minus what has been spent, and it stops moving once the term lapses.
    /// </summary>
    public sealed partial class ScopedCredit
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granted_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double GrantedCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RemainingCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granted_ts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int GrantedTs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_ts")]
        public int? ExpiresTs { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired")]
        public bool? Expired { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopedCredit" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="grantedCents"></param>
        /// <param name="remainingCents"></param>
        /// <param name="grantedTs"></param>
        /// <param name="description"></param>
        /// <param name="expiresTs"></param>
        /// <param name="expired">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScopedCredit(
            string name,
            double grantedCents,
            double remainingCents,
            int grantedTs,
            string? description,
            int? expiresTs,
            bool? expired)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.GrantedCents = grantedCents;
            this.RemainingCents = remainingCents;
            this.GrantedTs = grantedTs;
            this.ExpiresTs = expiresTs;
            this.Expired = expired;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopedCredit" /> class.
        /// </summary>
        public ScopedCredit()
        {
        }

    }
}