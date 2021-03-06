// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Media.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Media;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties for a Media Services REST API endpoint.
    /// </summary>
    public partial class ApiEndpoint
    {
        /// <summary>
        /// Initializes a new instance of the ApiEndpoint class.
        /// </summary>
        public ApiEndpoint()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiEndpoint class.
        /// </summary>
        /// <param name="endpoint">The Media Services REST endpoint.</param>
        /// <param name="majorVersion">The version of Media Services REST
        /// API.</param>
        public ApiEndpoint(string endpoint = default(string), string majorVersion = default(string))
        {
            Endpoint = endpoint;
            MajorVersion = majorVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Media Services REST endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "endpoint")]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or sets the version of Media Services REST API.
        /// </summary>
        [JsonProperty(PropertyName = "majorVersion")]
        public string MajorVersion { get; set; }

    }
}
