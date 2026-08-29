
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OpenAIBatchesOut
    {
        /// <summary>
        /// The batch ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always batch.<br/>
        /// Default Value: batch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The API endpoint used for the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// Errors that occurred during the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::DeepInfra.BatchErrors? Errors { get; set; }

        /// <summary>
        /// The ID of the input file for the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputFileId { get; set; }

        /// <summary>
        /// The time frame within which the batch should be processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompletionWindow { get; set; }

        /// <summary>
        /// The current status of the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// The ID of the output file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_file_id")]
        public string? OutputFileId { get; set; }

        /// <summary>
        /// The ID of the error file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_file_id")]
        public string? ErrorFileId { get; set; }

        /// <summary>
        /// The Unix timestamp of when the batch was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The Unix timestamp of when the batch started processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_progress_at")]
        public int? InProgressAt { get; set; }

        /// <summary>
        /// The Unix timestamp of when the batch will expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset ExpiresAt { get; set; }

        /// <summary>
        /// The Unix timestamp of when the batch started finalizing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finalizing_at")]
        public int? FinalizingAt { get; set; }

        /// <summary>
        /// The Unix timestamp of when the batch completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public int? CompletedAt { get; set; }

        /// <summary>
        /// The Unix timestamp of when the batch failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_at")]
        public int? FailedAt { get; set; }

        /// <summary>
        /// The Unix timestamp of when the batch expired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired_at")]
        public int? ExpiredAt { get; set; }

        /// <summary>
        /// The Unix timestamp of when the batch started cancelling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelling_at")]
        public int? CancellingAt { get; set; }

        /// <summary>
        /// The Unix timestamp of when the batch was cancelled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled_at")]
        public int? CancelledAt { get; set; }

        /// <summary>
        /// Request counts for the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_counts")]
        public global::DeepInfra.BatchRequestCounts? RequestCounts { get; set; }

        /// <summary>
        /// Metadata associated with the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The model used for the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Token usage accumulated for the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::DeepInfra.BatchUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIBatchesOut" /> class.
        /// </summary>
        /// <param name="id">
        /// The batch ID.
        /// </param>
        /// <param name="endpoint">
        /// The API endpoint used for the batch.
        /// </param>
        /// <param name="inputFileId">
        /// The ID of the input file for the batch.
        /// </param>
        /// <param name="completionWindow">
        /// The time frame within which the batch should be processed.
        /// </param>
        /// <param name="status">
        /// The current status of the batch.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp of when the batch was created.
        /// </param>
        /// <param name="expiresAt">
        /// The Unix timestamp of when the batch will expire.
        /// </param>
        /// <param name="object">
        /// The object type, which is always batch.<br/>
        /// Default Value: batch
        /// </param>
        /// <param name="errors">
        /// Errors that occurred during the batch.
        /// </param>
        /// <param name="outputFileId">
        /// The ID of the output file.
        /// </param>
        /// <param name="errorFileId">
        /// The ID of the error file.
        /// </param>
        /// <param name="inProgressAt">
        /// The Unix timestamp of when the batch started processing.
        /// </param>
        /// <param name="finalizingAt">
        /// The Unix timestamp of when the batch started finalizing.
        /// </param>
        /// <param name="completedAt">
        /// The Unix timestamp of when the batch completed.
        /// </param>
        /// <param name="failedAt">
        /// The Unix timestamp of when the batch failed.
        /// </param>
        /// <param name="expiredAt">
        /// The Unix timestamp of when the batch expired.
        /// </param>
        /// <param name="cancellingAt">
        /// The Unix timestamp of when the batch started cancelling.
        /// </param>
        /// <param name="cancelledAt">
        /// The Unix timestamp of when the batch was cancelled.
        /// </param>
        /// <param name="requestCounts">
        /// Request counts for the batch.
        /// </param>
        /// <param name="metadata">
        /// Metadata associated with the batch.
        /// </param>
        /// <param name="model">
        /// The model used for the batch.
        /// </param>
        /// <param name="usage">
        /// Token usage accumulated for the batch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIBatchesOut(
            string id,
            string endpoint,
            string inputFileId,
            string completionWindow,
            string status,
            global::System.DateTimeOffset createdAt,
            global::System.DateTimeOffset expiresAt,
            string? @object,
            global::DeepInfra.BatchErrors? errors,
            string? outputFileId,
            string? errorFileId,
            int? inProgressAt,
            int? finalizingAt,
            int? completedAt,
            int? failedAt,
            int? expiredAt,
            int? cancellingAt,
            int? cancelledAt,
            global::DeepInfra.BatchRequestCounts? requestCounts,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? model,
            global::DeepInfra.BatchUsage? usage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Errors = errors;
            this.InputFileId = inputFileId ?? throw new global::System.ArgumentNullException(nameof(inputFileId));
            this.CompletionWindow = completionWindow ?? throw new global::System.ArgumentNullException(nameof(completionWindow));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.OutputFileId = outputFileId;
            this.ErrorFileId = errorFileId;
            this.CreatedAt = createdAt;
            this.InProgressAt = inProgressAt;
            this.ExpiresAt = expiresAt;
            this.FinalizingAt = finalizingAt;
            this.CompletedAt = completedAt;
            this.FailedAt = failedAt;
            this.ExpiredAt = expiredAt;
            this.CancellingAt = cancellingAt;
            this.CancelledAt = cancelledAt;
            this.RequestCounts = requestCounts;
            this.Metadata = metadata;
            this.Model = model;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIBatchesOut" /> class.
        /// </summary>
        public OpenAIBatchesOut()
        {
        }

    }
}