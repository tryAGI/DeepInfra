#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Submit Feedback<br/>
        /// Submit feedback
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SubmitFeedbackAsync(
            global::DeepInfra.FeedbackIn request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Submit Feedback<br/>
        /// Submit feedback
        /// </summary>
        /// <param name="message">
        /// The message you'd like to send to deepinfra team
        /// </param>
        /// <param name="contactEmail">
        /// Optional contact email to reach you back
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SubmitFeedbackAsync(
            string message,
            string? contactEmail = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}