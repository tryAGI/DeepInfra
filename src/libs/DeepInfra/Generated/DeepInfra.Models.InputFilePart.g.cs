
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InputFilePart
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"input_file"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "input_file";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_data")]
        public string? FileData { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFilePart" /> class.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="filename"></param>
        /// <param name="fileData"></param>
        /// <param name="fileUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputFilePart(
            string? fileId,
            string? filename,
            string? fileData,
            string? fileUrl,
            string type = "input_file")
        {
            this.Type = type;
            this.FileId = fileId;
            this.Filename = filename;
            this.FileData = fileData;
            this.FileUrl = fileUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFilePart" /> class.
        /// </summary>
        public InputFilePart()
        {
        }

    }
}