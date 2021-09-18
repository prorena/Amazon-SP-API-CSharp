/* 
 * Selling Partner API for Sales
 *
 * The Selling Partner API for Sales provides APIs related to sales performance.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.Sales
{
    /// <summary>
    /// The response schema for the getOrderMetrics operation.
    /// </summary>
    [DataContract]
    public partial class GetOrderMetricsResponse : IEquatable<GetOrderMetricsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderMetricsResponse" /> class.
        /// </summary>
        /// <param name="Payload">The payload for the getOrderMetrics operation..</param>
        /// <param name="Errors">Encountered errors for the getOrderMetrics operation..</param>
        public GetOrderMetricsResponse(OrderMetricsList Payload = default(OrderMetricsList), ErrorList Errors = default(ErrorList))
        {
            this.Payload = Payload;
            this.Errors = Errors;
        }
        public GetOrderMetricsResponse()
        {
            this.Payload = default(OrderMetricsList);
            this.Errors = default(ErrorList);
        }

        /// <summary>
        /// The payload for the getOrderMetrics operation.
        /// </summary>
        /// <value>The payload for the getOrderMetrics operation.</value>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public OrderMetricsList Payload { get; set; }

        /// <summary>
        /// Encountered errors for the getOrderMetrics operation.
        /// </summary>
        /// <value>Encountered errors for the getOrderMetrics operation.</value>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public ErrorList Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetOrderMetricsResponse {\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetOrderMetricsResponse);
        }

        /// <summary>
        /// Returns true if GetOrderMetricsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetOrderMetricsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetOrderMetricsResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
                ) &&
                (
                    this.Errors == input.Errors ||
                    (this.Errors != null &&
                    this.Errors.Equals(input.Errors))
                );
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
                if (this.Payload != null)
                    hashCode = hashCode * 59 + this.Payload.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
