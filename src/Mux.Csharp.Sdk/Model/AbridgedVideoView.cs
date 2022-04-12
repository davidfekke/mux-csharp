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
    /// AbridgedVideoView
    /// </summary>
    [DataContract(Name = "AbridgedVideoView")]
    public partial class AbridgedVideoView : IEquatable<AbridgedVideoView>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbridgedVideoView" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="viewerOsFamily">viewerOsFamily.</param>
        /// <param name="viewerApplicationName">viewerApplicationName.</param>
        /// <param name="videoTitle">videoTitle.</param>
        /// <param name="totalRowCount">totalRowCount.</param>
        /// <param name="playerErrorMessage">playerErrorMessage.</param>
        /// <param name="playerErrorCode">playerErrorCode.</param>
        /// <param name="errorTypeId">errorTypeId.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="viewStart">viewStart.</param>
        /// <param name="viewEnd">viewEnd.</param>
        public AbridgedVideoView(string id = default(string), string viewerOsFamily = default(string), string viewerApplicationName = default(string), string videoTitle = default(string), long totalRowCount = default(long), string playerErrorMessage = default(string), string playerErrorCode = default(string), int? errorTypeId = default(int?), string countryCode = default(string), string viewStart = default(string), string viewEnd = default(string))
        {
            this.Id = id;
            this.ViewerOsFamily = viewerOsFamily;
            this.ViewerApplicationName = viewerApplicationName;
            this.VideoTitle = videoTitle;
            this.TotalRowCount = totalRowCount;
            this.PlayerErrorMessage = playerErrorMessage;
            this.PlayerErrorCode = playerErrorCode;
            this.ErrorTypeId = errorTypeId;
            this.CountryCode = countryCode;
            this.ViewStart = viewStart;
            this.ViewEnd = viewEnd;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ViewerOsFamily
        /// </summary>
        [DataMember(Name = "viewer_os_family", EmitDefaultValue = true)]
        public string ViewerOsFamily { get; set; }

        /// <summary>
        /// Gets or Sets ViewerApplicationName
        /// </summary>
        [DataMember(Name = "viewer_application_name", EmitDefaultValue = true)]
        public string ViewerApplicationName { get; set; }

        /// <summary>
        /// Gets or Sets VideoTitle
        /// </summary>
        [DataMember(Name = "video_title", EmitDefaultValue = true)]
        public string VideoTitle { get; set; }

        /// <summary>
        /// Gets or Sets TotalRowCount
        /// </summary>
        [DataMember(Name = "total_row_count", EmitDefaultValue = false)]
        public long TotalRowCount { get; set; }

        /// <summary>
        /// Gets or Sets PlayerErrorMessage
        /// </summary>
        [DataMember(Name = "player_error_message", EmitDefaultValue = true)]
        public string PlayerErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets PlayerErrorCode
        /// </summary>
        [DataMember(Name = "player_error_code", EmitDefaultValue = true)]
        public string PlayerErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets ErrorTypeId
        /// </summary>
        [DataMember(Name = "error_type_id", EmitDefaultValue = true)]
        public int? ErrorTypeId { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name = "country_code", EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets ViewStart
        /// </summary>
        [DataMember(Name = "view_start", EmitDefaultValue = false)]
        public string ViewStart { get; set; }

        /// <summary>
        /// Gets or Sets ViewEnd
        /// </summary>
        [DataMember(Name = "view_end", EmitDefaultValue = false)]
        public string ViewEnd { get; set; }

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
            sb.Append("class AbridgedVideoView {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ViewerOsFamily: ").Append(ViewerOsFamily).Append("\n");
            sb.Append("  ViewerApplicationName: ").Append(ViewerApplicationName).Append("\n");
            sb.Append("  VideoTitle: ").Append(VideoTitle).Append("\n");
            sb.Append("  TotalRowCount: ").Append(TotalRowCount).Append("\n");
            sb.Append("  PlayerErrorMessage: ").Append(PlayerErrorMessage).Append("\n");
            sb.Append("  PlayerErrorCode: ").Append(PlayerErrorCode).Append("\n");
            sb.Append("  ErrorTypeId: ").Append(ErrorTypeId).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  ViewStart: ").Append(ViewStart).Append("\n");
            sb.Append("  ViewEnd: ").Append(ViewEnd).Append("\n");
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
            return this.Equals(input as AbridgedVideoView);
        }

        /// <summary>
        /// Returns true if AbridgedVideoView instances are equal
        /// </summary>
        /// <param name="input">Instance of AbridgedVideoView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbridgedVideoView input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ViewerOsFamily == input.ViewerOsFamily ||
                    (this.ViewerOsFamily != null &&
                    this.ViewerOsFamily.Equals(input.ViewerOsFamily))
                ) && 
                (
                    this.ViewerApplicationName == input.ViewerApplicationName ||
                    (this.ViewerApplicationName != null &&
                    this.ViewerApplicationName.Equals(input.ViewerApplicationName))
                ) && 
                (
                    this.VideoTitle == input.VideoTitle ||
                    (this.VideoTitle != null &&
                    this.VideoTitle.Equals(input.VideoTitle))
                ) && 
                (
                    this.TotalRowCount == input.TotalRowCount ||
                    this.TotalRowCount.Equals(input.TotalRowCount)
                ) && 
                (
                    this.PlayerErrorMessage == input.PlayerErrorMessage ||
                    (this.PlayerErrorMessage != null &&
                    this.PlayerErrorMessage.Equals(input.PlayerErrorMessage))
                ) && 
                (
                    this.PlayerErrorCode == input.PlayerErrorCode ||
                    (this.PlayerErrorCode != null &&
                    this.PlayerErrorCode.Equals(input.PlayerErrorCode))
                ) && 
                (
                    this.ErrorTypeId == input.ErrorTypeId ||
                    (this.ErrorTypeId != null &&
                    this.ErrorTypeId.Equals(input.ErrorTypeId))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.ViewStart == input.ViewStart ||
                    (this.ViewStart != null &&
                    this.ViewStart.Equals(input.ViewStart))
                ) && 
                (
                    this.ViewEnd == input.ViewEnd ||
                    (this.ViewEnd != null &&
                    this.ViewEnd.Equals(input.ViewEnd))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.ViewerOsFamily != null)
                {
                    hashCode = (hashCode * 59) + this.ViewerOsFamily.GetHashCode();
                }
                if (this.ViewerApplicationName != null)
                {
                    hashCode = (hashCode * 59) + this.ViewerApplicationName.GetHashCode();
                }
                if (this.VideoTitle != null)
                {
                    hashCode = (hashCode * 59) + this.VideoTitle.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalRowCount.GetHashCode();
                if (this.PlayerErrorMessage != null)
                {
                    hashCode = (hashCode * 59) + this.PlayerErrorMessage.GetHashCode();
                }
                if (this.PlayerErrorCode != null)
                {
                    hashCode = (hashCode * 59) + this.PlayerErrorCode.GetHashCode();
                }
                if (this.ErrorTypeId != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorTypeId.GetHashCode();
                }
                if (this.CountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.CountryCode.GetHashCode();
                }
                if (this.ViewStart != null)
                {
                    hashCode = (hashCode * 59) + this.ViewStart.GetHashCode();
                }
                if (this.ViewEnd != null)
                {
                    hashCode = (hashCode * 59) + this.ViewEnd.GetHashCode();
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