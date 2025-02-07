
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Me
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_verified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EmailVerified { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_email_verified")]
        public bool? RequireEmailVerified { get; set; }

        /// <summary>
        /// Name that is used to identifythe account on the website
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Authentication provider, e.g. 'github'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("picture")]
        public string? Picture { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_admin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAdmin { get; set; }

        /// <summary>
        /// Personal name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_business_account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsBusinessAccount { get; set; }

        /// <summary>
        /// Company name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Company { get; set; }

        /// <summary>
        /// Company website address
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Website { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_team_account")]
        public bool? IsTeamAccount { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_team_owner")]
        public bool? IsTeamOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_role")]
        public string? TeamRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_display_name")]
        public string? TeamDisplayName { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_team_upgrade_enabled")]
        public bool? IsTeamUpgradeEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Me" /> class.
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="email"></param>
        /// <param name="emailVerified"></param>
        /// <param name="requireEmailVerified">
        /// Default Value: false
        /// </param>
        /// <param name="displayName">
        /// Name that is used to identifythe account on the website
        /// </param>
        /// <param name="provider">
        /// Authentication provider, e.g. 'github'
        /// </param>
        /// <param name="picture"></param>
        /// <param name="isAdmin"></param>
        /// <param name="name">
        /// Personal name
        /// </param>
        /// <param name="isBusinessAccount"></param>
        /// <param name="company">
        /// Company name
        /// </param>
        /// <param name="website">
        /// Company website address
        /// </param>
        /// <param name="isTeamAccount">
        /// Default Value: false
        /// </param>
        /// <param name="isTeamOwner">
        /// Default Value: false
        /// </param>
        /// <param name="teamRole"></param>
        /// <param name="teamDisplayName"></param>
        /// <param name="isTeamUpgradeEnabled">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Me(
            string uid,
            bool emailVerified,
            string displayName,
            string provider,
            bool isAdmin,
            string name,
            bool isBusinessAccount,
            string company,
            string website,
            string? email,
            bool? requireEmailVerified,
            string? picture,
            bool? isTeamAccount,
            bool? isTeamOwner,
            string? teamRole,
            string? teamDisplayName,
            bool? isTeamUpgradeEnabled)
        {
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.EmailVerified = emailVerified;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.IsAdmin = isAdmin;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsBusinessAccount = isBusinessAccount;
            this.Company = company ?? throw new global::System.ArgumentNullException(nameof(company));
            this.Website = website ?? throw new global::System.ArgumentNullException(nameof(website));
            this.Email = email;
            this.RequireEmailVerified = requireEmailVerified;
            this.Picture = picture;
            this.IsTeamAccount = isTeamAccount;
            this.IsTeamOwner = isTeamOwner;
            this.TeamRole = teamRole;
            this.TeamDisplayName = teamDisplayName;
            this.IsTeamUpgradeEnabled = isTeamUpgradeEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Me" /> class.
        /// </summary>
        public Me()
        {
        }
    }
}