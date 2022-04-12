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
    /// OverallValues
    /// </summary>
    [DataContract(Name = "OverallValues")]
    public partial class OverallValues : IEquatable<OverallValues>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OverallValues" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="totalWatchTime">totalWatchTime.</param>
        /// <param name="totalViews">totalViews.</param>
        /// <param name="globalValue">globalValue.</param>
        public OverallValues(double value = default(double), long totalWatchTime = default(long), long totalViews = default(long), double globalValue = default(double))
        {
            this.Value = value;
            this.TotalWatchTime = totalWatchTime;
            this.TotalViews = totalViews;
            this.GlobalValue = globalValue;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public double Value { get; set; }

        /// <summary>
        /// Gets or Sets TotalWatchTime
        /// </summary>
        [DataMember(Name = "total_watch_time", EmitDefaultValue = false)]
        public long TotalWatchTime { get; set; }

        /// <summary>
        /// Gets or Sets TotalViews
        /// </summary>
        [DataMember(Name = "total_views", EmitDefaultValue = false)]
        public long TotalViews { get; set; }

        /// <summary>
        /// Gets or Sets GlobalValue
        /// </summary>
        [DataMember(Name = "global_value", EmitDefaultValue = false)]
        public double GlobalValue { get; set; }

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
            sb.Append("class OverallValues {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  TotalWatchTime: ").Append(TotalWatchTime).Append("\n");
            sb.Append("  TotalViews: ").Append(TotalViews).Append("\n");
            sb.Append("  GlobalValue: ").Append(GlobalValue).Append("\n");
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
            return this.Equals(input as OverallValues);
        }

        /// <summary>
        /// Returns true if OverallValues instances are equal
        /// </summary>
        /// <param name="input">Instance of OverallValues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OverallValues input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.TotalWatchTime == input.TotalWatchTime ||
                    this.TotalWatchTime.Equals(input.TotalWatchTime)
                ) && 
                (
                    this.TotalViews == input.TotalViews ||
                    this.TotalViews.Equals(input.TotalViews)
                ) && 
                (
                    this.GlobalValue == input.GlobalValue ||
                    this.GlobalValue.Equals(input.GlobalValue)
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
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalWatchTime.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalViews.GetHashCode();
                hashCode = (hashCode * 59) + this.GlobalValue.GetHashCode();
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