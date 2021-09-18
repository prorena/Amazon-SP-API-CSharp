/* 
 * Selling Partner API for Orders
 *
 * The Selling Partner API for Orders helps you programmatically retrieve order information. These APIs let you develop fast, flexible, custom applications in areas like order synchronization, order research, and demand-based decision support tools.
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

namespace AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    /// Buyer information for custom orders from the Amazon Custom program.
    /// </summary>
    [DataContract]
    public partial class BuyerCustomizedInfoDetail : IEquatable<BuyerCustomizedInfoDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuyerCustomizedInfoDetail" /> class.
        /// </summary>
        /// <param name="CustomizedURL">The location of a zip file containing Amazon Custom data..</param>
        public BuyerCustomizedInfoDetail(string CustomizedURL = default(string))
        {
            this.CustomizedURL = CustomizedURL;
        }

        /// <summary>
        /// The location of a zip file containing Amazon Custom data.
        /// </summary>
        /// <value>The location of a zip file containing Amazon Custom data.</value>
        [DataMember(Name = "CustomizedURL", EmitDefaultValue = false)]
        public string CustomizedURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuyerCustomizedInfoDetail {\n");
            sb.Append("  CustomizedURL: ").Append(CustomizedURL).Append("\n");
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
            return this.Equals(input as BuyerCustomizedInfoDetail);
        }

        /// <summary>
        /// Returns true if BuyerCustomizedInfoDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of BuyerCustomizedInfoDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuyerCustomizedInfoDetail input)
        {
            if (input == null)
                return false;

            return
                (
                    this.CustomizedURL == input.CustomizedURL ||
                    (this.CustomizedURL != null &&
                    this.CustomizedURL.Equals(input.CustomizedURL))
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
                if (this.CustomizedURL != null)
                    hashCode = hashCode * 59 + this.CustomizedURL.GetHashCode();
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
