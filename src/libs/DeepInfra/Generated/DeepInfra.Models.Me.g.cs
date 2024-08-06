
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}