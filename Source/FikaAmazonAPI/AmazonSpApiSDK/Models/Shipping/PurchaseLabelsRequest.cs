/* 
 * Selling Partner API for Shipping
 *
 * Provides programmatic access to Amazon Shipping APIs.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.Shipping
{
    /// <summary>
    /// The request schema for the purchaseLabels operation.
    /// </summary>
    [DataContract]
    public partial class PurchaseLabelsRequest : IEquatable<PurchaseLabelsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseLabelsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PurchaseLabelsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseLabelsRequest" /> class.
        /// </summary>
        /// <param name="RateId">RateId (required).</param>
        /// <param name="LabelSpecification">LabelSpecification (required).</param>
        public PurchaseLabelsRequest(RateId RateId = default(RateId), LabelSpecification LabelSpecification = default(LabelSpecification))
        {
            // to ensure "RateId" is required (not null)
            if (RateId == null)
            {
                throw new InvalidDataException("RateId is a required property for PurchaseLabelsRequest and cannot be null");
            }
            else
            {
                this.RateId = RateId;
            }
            // to ensure "LabelSpecification" is required (not null)
            if (LabelSpecification == null)
            {
                throw new InvalidDataException("LabelSpecification is a required property for PurchaseLabelsRequest and cannot be null");
            }
            else
            {
                this.LabelSpecification = LabelSpecification;
            }
        }

        /// <summary>
        /// Gets or Sets RateId
        /// </summary>
        [DataMember(Name = "rateId", EmitDefaultValue = false)]
        public RateId RateId { get; set; }

        /// <summary>
        /// Gets or Sets LabelSpecification
        /// </summary>
        [DataMember(Name = "labelSpecification", EmitDefaultValue = false)]
        public LabelSpecification LabelSpecification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseLabelsRequest {\n");
            sb.Append("  RateId: ").Append(RateId).Append("\n");
            sb.Append("  LabelSpecification: ").Append(LabelSpecification).Append("\n");
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
            return this.Equals(input as PurchaseLabelsRequest);
        }

        /// <summary>
        /// Returns true if PurchaseLabelsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseLabelsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseLabelsRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.RateId == input.RateId ||
                    (this.RateId != null &&
                    this.RateId.Equals(input.RateId))
                ) &&
                (
                    this.LabelSpecification == input.LabelSpecification ||
                    (this.LabelSpecification != null &&
                    this.LabelSpecification.Equals(input.LabelSpecification))
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
                if (this.RateId != null)
                    hashCode = hashCode * 59 + this.RateId.GetHashCode();
                if (this.LabelSpecification != null)
                    hashCode = hashCode * 59 + this.LabelSpecification.GetHashCode();
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
