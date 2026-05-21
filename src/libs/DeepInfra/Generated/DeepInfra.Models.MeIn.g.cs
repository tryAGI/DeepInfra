
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MeIn
    {
        /// <summary>
        /// Personal name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// First name of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// Country of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_business_account")]
        public bool? IsBusinessAccount { get; set; }

        /// <summary>
        /// Company name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        public string? Company { get; set; }

        /// <summary>
        /// Company website address
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// Job title of the user, e.g. 'Software Engineer'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// String with length between 1 and 39 characters. Only alphanumeric characters and dashes allowed. Must contain no leading, trailing or consecutive dashes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Short description of the use case for the account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_case")]
        public string? UseCase { get; set; }

        /// <summary>
        /// Short description of how the user found out about DeepInfra
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribution")]
        public string? Attribution { get; set; }

        /// <summary>
        /// Set to false to opt out of marketing emails
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketing_emails")]
        public bool? MarketingEmails { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country code of the user selected country
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MeIn" /> class.
        /// </summary>
        /// <param name="name">
        /// Personal name
        /// </param>
        /// <param name="firstName">
        /// First name of the user
        /// </param>
        /// <param name="lastName">
        /// Last name of the user
        /// </param>
        /// <param name="country">
        /// Country of the user
        /// </param>
        /// <param name="email"></param>
        /// <param name="isBusinessAccount"></param>
        /// <param name="company">
        /// Company name
        /// </param>
        /// <param name="website">
        /// Company website address
        /// </param>
        /// <param name="title">
        /// Job title of the user, e.g. 'Software Engineer'
        /// </param>
        /// <param name="displayName">
        /// String with length between 1 and 39 characters. Only alphanumeric characters and dashes allowed. Must contain no leading, trailing or consecutive dashes.
        /// </param>
        /// <param name="useCase">
        /// Short description of the use case for the account
        /// </param>
        /// <param name="attribution">
        /// Short description of how the user found out about DeepInfra
        /// </param>
        /// <param name="marketingEmails">
        /// Set to false to opt out of marketing emails
        /// </param>
        /// <param name="countryCode">
        /// ISO 3166-1 alpha-2 country code of the user selected country
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MeIn(
            string? name,
            string? firstName,
            string? lastName,
            string? country,
            string? email,
            bool? isBusinessAccount,
            string? company,
            string? website,
            string? title,
            string? displayName,
            string? useCase,
            string? attribution,
            bool? marketingEmails,
            string? countryCode)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;
            this.Email = email;
            this.IsBusinessAccount = isBusinessAccount;
            this.Company = company;
            this.Website = website;
            this.Title = title;
            this.DisplayName = displayName;
            this.UseCase = useCase;
            this.Attribution = attribution;
            this.MarketingEmails = marketingEmails;
            this.CountryCode = countryCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeIn" /> class.
        /// </summary>
        public MeIn()
        {
        }

    }
}