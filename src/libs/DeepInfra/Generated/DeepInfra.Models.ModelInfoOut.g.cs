
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelInfoOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reported_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReportedType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mf_description")]
        public string? MfDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Featured { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public bool? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("curl_inv")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurlInv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmdline_inv")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CmdlineInv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("txt_docs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TxtDocs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("out_example")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutExample { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("out_docs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutDocs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_token")]
        public string? MaskToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_schema")]
        public object? InSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("out_schema")]
        public object? OutSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_fields")]
        public global::System.Collections.Generic.IList<global::DeepInfra.ModelFieldInfo>? InFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.AnyOf<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits> Pricing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doc_blocks")]
        public global::System.Collections.Generic.IList<global::DeepInfra.ModelDocBlock>? DocBlocks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("short_doc_block")]
        public global::DeepInfra.ModelDocBlock? ShortDocBlock { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepInfra.SchemaVariant> Schemas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replaced_by")]
        public string? ReplacedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated")]
        public int? Deprecated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization")]
        public string? Quantization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mmlu")]
        public double? Mmlu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected")]
        public string? Expected { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("import_time")]
        public string? ImportTime { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_partner")]
        public bool? IsPartner { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_custom_deployable")]
        public bool? IsCustomDeployable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mf_name")]
        public string? MfName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mf_title")]
        public string? MfTitle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfoOut" /> class.
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="type"></param>
        /// <param name="tags"></param>
        /// <param name="reportedType"></param>
        /// <param name="version"></param>
        /// <param name="description"></param>
        /// <param name="mfDescription"></param>
        /// <param name="featured"></param>
        /// <param name="owner">
        /// Default Value: false
        /// </param>
        /// <param name="public"></param>
        /// <param name="curlInv"></param>
        /// <param name="cmdlineInv"></param>
        /// <param name="txtDocs"></param>
        /// <param name="outExample"></param>
        /// <param name="outDocs"></param>
        /// <param name="maskToken"></param>
        /// <param name="inSchema"></param>
        /// <param name="outSchema"></param>
        /// <param name="inFields"></param>
        /// <param name="pricing"></param>
        /// <param name="docBlocks"></param>
        /// <param name="shortDocBlock"></param>
        /// <param name="schemas"></param>
        /// <param name="meta"></param>
        /// <param name="maxTokens"></param>
        /// <param name="replacedBy"></param>
        /// <param name="deprecated"></param>
        /// <param name="quantization"></param>
        /// <param name="mmlu"></param>
        /// <param name="expected"></param>
        /// <param name="importTime"></param>
        /// <param name="isPartner">
        /// Default Value: false
        /// </param>
        /// <param name="isCustomDeployable">
        /// Default Value: false
        /// </param>
        /// <param name="mfName"></param>
        /// <param name="mfTitle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelInfoOut(
            string modelName,
            string type,
            global::System.Collections.Generic.IList<string> tags,
            string reportedType,
            string version,
            bool featured,
            bool @public,
            string curlInv,
            string cmdlineInv,
            string txtDocs,
            string outExample,
            string outDocs,
            global::DeepInfra.AnyOf<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits> pricing,
            global::System.Collections.Generic.IList<global::DeepInfra.SchemaVariant> schemas,
            string? description,
            string? mfDescription,
            bool? owner,
            string? maskToken,
            object? inSchema,
            object? outSchema,
            global::System.Collections.Generic.IList<global::DeepInfra.ModelFieldInfo>? inFields,
            global::System.Collections.Generic.IList<global::DeepInfra.ModelDocBlock>? docBlocks,
            global::DeepInfra.ModelDocBlock? shortDocBlock,
            object? meta,
            int? maxTokens,
            string? replacedBy,
            int? deprecated,
            string? quantization,
            double? mmlu,
            string? expected,
            string? importTime,
            bool? isPartner,
            bool? isCustomDeployable,
            string? mfName,
            string? mfTitle)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.ReportedType = reportedType ?? throw new global::System.ArgumentNullException(nameof(reportedType));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Featured = featured;
            this.Public = @public;
            this.CurlInv = curlInv ?? throw new global::System.ArgumentNullException(nameof(curlInv));
            this.CmdlineInv = cmdlineInv ?? throw new global::System.ArgumentNullException(nameof(cmdlineInv));
            this.TxtDocs = txtDocs ?? throw new global::System.ArgumentNullException(nameof(txtDocs));
            this.OutExample = outExample ?? throw new global::System.ArgumentNullException(nameof(outExample));
            this.OutDocs = outDocs ?? throw new global::System.ArgumentNullException(nameof(outDocs));
            this.Pricing = pricing;
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
            this.Description = description;
            this.MfDescription = mfDescription;
            this.Owner = owner;
            this.MaskToken = maskToken;
            this.InSchema = inSchema;
            this.OutSchema = outSchema;
            this.InFields = inFields;
            this.DocBlocks = docBlocks;
            this.ShortDocBlock = shortDocBlock;
            this.Meta = meta;
            this.MaxTokens = maxTokens;
            this.ReplacedBy = replacedBy;
            this.Deprecated = deprecated;
            this.Quantization = quantization;
            this.Mmlu = mmlu;
            this.Expected = expected;
            this.ImportTime = importTime;
            this.IsPartner = isPartner;
            this.IsCustomDeployable = isCustomDeployable;
            this.MfName = mfName;
            this.MfTitle = mfTitle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfoOut" /> class.
        /// </summary>
        public ModelInfoOut()
        {
        }
    }
}