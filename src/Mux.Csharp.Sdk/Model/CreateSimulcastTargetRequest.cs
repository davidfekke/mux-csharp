/*
 * Mux API
 *
 * Mux is how developers build online video. This API encompasses both Mux Video and Mux Data functionality to help you build your video-related projects better and faster than ever before.
 *
 * The version of the OpenAPI document: v1
 * Contact: devex@mux.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Mux.Csharp.Sdk.Client.OpenAPIDateConverter;

namespace Mux.Csharp.Sdk.Model
{
    /// <summary>
    /// CreateSimulcastTargetRequest
    /// </summary>
    [DataContract(Name = "CreateSimulcastTargetRequest")]
    public partial class CreateSimulcastTargetRequest : IEquatable<CreateSimulcastTargetRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSimulcastTargetRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateSimulcastTargetRequest()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSimulcastTargetRequest" /> class.
        /// </summary>
        /// <param name="passthrough">Arbitrary user-supplied metadata set by you when creating a simulcast target..</param>
        /// <param name="streamKey">Stream Key represents a stream identifier on the third party live streaming service to send the parent live stream to..</param>
        /// <param name="url">RTMP hostname including application name for the third party live streaming service. Example: &#x60;rtmp://live.example.com/app&#x60;. (required).</param>
        public CreateSimulcastTargetRequest(string passthrough = default(string), string streamKey = default(string), string url = default(string))
        {
            // to ensure "url" is required (not null)
            if (url == null) {
                throw new ArgumentNullException("url is a required property for CreateSimulcastTargetRequest and cannot be null");
            }
            this.Url = url;
            this.Passthrough = passthrough;
            this.StreamKey = streamKey;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Arbitrary user-supplied metadata set by you when creating a simulcast target.
        /// </summary>
        /// <value>Arbitrary user-supplied metadata set by you when creating a simulcast target.</value>
        [DataMember(Name = "passthrough", EmitDefaultValue = false)]
        public string Passthrough { get; set; }

        /// <summary>
        /// Stream Key represents a stream identifier on the third party live streaming service to send the parent live stream to.
        /// </summary>
        /// <value>Stream Key represents a stream identifier on the third party live streaming service to send the parent live stream to.</value>
        [DataMember(Name = "stream_key", EmitDefaultValue = false)]
        public string StreamKey { get; set; }

        /// <summary>
        /// RTMP hostname including application name for the third party live streaming service. Example: &#x60;rtmp://live.example.com/app&#x60;.
        /// </summary>
        /// <value>RTMP hostname including application name for the third party live streaming service. Example: &#x60;rtmp://live.example.com/app&#x60;.</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSimulcastTargetRequest {\n");
            sb.Append("  Passthrough: ").Append(Passthrough).Append("\n");
            sb.Append("  StreamKey: ").Append(StreamKey).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSimulcastTargetRequest);
        }

        /// <summary>
        /// Returns true if CreateSimulcastTargetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSimulcastTargetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSimulcastTargetRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Passthrough == input.Passthrough ||
                    (this.Passthrough != null &&
                    this.Passthrough.Equals(input.Passthrough))
                ) && 
                (
                    this.StreamKey == input.StreamKey ||
                    (this.StreamKey != null &&
                    this.StreamKey.Equals(input.StreamKey))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Passthrough != null)
                {
                    hashCode = (hashCode * 59) + this.Passthrough.GetHashCode();
                }
                if (this.StreamKey != null)
                {
                    hashCode = (hashCode * 59) + this.StreamKey.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
