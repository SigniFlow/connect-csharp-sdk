using System.Net;
using Polly;

namespace SigniFlow.Connect.Client
{
    /// <summary>
    /// Configuration class to set the polly retry policies to be applied to the requests.
    /// </summary>
    public class RetryConfiguration
    {
        /// <summary>
        /// Retry policy
        /// </summary>
        public static Policy<HttpWebResponse> RetryPolicy { get; set; }

        /// <summary>
        /// Async retry policy
        /// </summary>
        public static AsyncPolicy<HttpWebResponse> AsyncRetryPolicy { get; set; }
    }
}
