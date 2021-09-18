/* 
 * Selling Partner API for Merchant Fulfillment
 *
 * The Selling Partner API for Merchant Fulfillment helps you build applications that let sellers purchase shipping for non-Prime and Prime orders using Amazon’s Buy Shipping Services.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.MerchantFulfillment
{
    /// <summary>
    /// The label format details and whether to include a packing slip.
    /// </summary>
    [DataContract]
    public partial class LabelFormatOption : IEquatable<LabelFormatOption>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets LabelFormat
        /// </summary>
        [DataMember(Name = "LabelFormat", EmitDefaultValue = false)]
        public LabelFormat? LabelFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelFormatOption" /> class.
        /// </summary>
        /// <param name="IncludePackingSlipWithLabel">When true, include a packing slip with the label..</param>
        /// <param name="LabelFormat">LabelFormat.</param>
        public LabelFormatOption(bool? IncludePackingSlipWithLabel = default(bool?), LabelFormat? LabelFormat = default(LabelFormat?))
        {
            this.IncludePackingSlipWithLabel = IncludePackingSlipWithLabel;
            this.LabelFormat = LabelFormat;
        }

        /// <summary>
        /// When true, include a packing slip with the label.
        /// </summary>
        /// <value>When true, include a packing slip with the label.</value>
        [DataMember(Name = "IncludePackingSlipWithLabel", EmitDefaultValue = false)]
        public bool? IncludePackingSlipWithLabel { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LabelFormatOption {\n");
            sb.Append("  IncludePackingSlipWithLabel: ").Append(IncludePackingSlipWithLabel).Append("\n");
            sb.Append("  LabelFormat: ").Append(LabelFormat).Append("\n");
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
            return this.Equals(input as LabelFormatOption);
        }

        /// <summary>
        /// Returns true if LabelFormatOption instances are equal
        /// </summary>
        /// <param name="input">Instance of LabelFormatOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LabelFormatOption input)
        {
            if (input == null)
                return false;

            return
                (
                    this.IncludePackingSlipWithLabel == input.IncludePackingSlipWithLabel ||
                    (this.IncludePackingSlipWithLabel != null &&
                    this.IncludePackingSlipWithLabel.Equals(input.IncludePackingSlipWithLabel))
                ) &&
                (
                    this.LabelFormat == input.LabelFormat ||
                    (this.LabelFormat != null &&
                    this.LabelFormat.Equals(input.LabelFormat))
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
                if (this.IncludePackingSlipWithLabel != null)
                    hashCode = hashCode * 59 + this.IncludePackingSlipWithLabel.GetHashCode();
                if (this.LabelFormat != null)
                    hashCode = hashCode * 59 + this.LabelFormat.GetHashCode();
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
