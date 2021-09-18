/* 
 * Selling Partner API for FBA Small And Light
 *
 * The Selling Partner API for FBA Small and Light lets you help sellers manage their listings in the Small and Light program. The program reduces the cost of fulfilling orders for small and lightweight FBA inventory. You can enroll or remove items from the program and check item eligibility and enrollment status. You can also preview the estimated program fees charged to a seller for items sold while enrolled in the program.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.FbaSmallandLight
{
    /// <summary>
    /// Fee details for a specific fee.
    /// </summary>
    [DataContract]
    public partial class FeeLineItem : IEquatable<FeeLineItem>, IValidatableObject
    {
        /// <summary>
        /// The type of fee charged to the seller.
        /// </summary>
        /// <value>The type of fee charged to the seller.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FeeTypeEnum
        {

            /// <summary>
            /// Enum FBAWeightBasedFee for value: FBAWeightBasedFee
            /// </summary>
            [EnumMember(Value = "FBAWeightBasedFee")]
            FBAWeightBasedFee = 1,

            /// <summary>
            /// Enum FBAPerOrderFulfillmentFee for value: FBAPerOrderFulfillmentFee
            /// </summary>
            [EnumMember(Value = "FBAPerOrderFulfillmentFee")]
            FBAPerOrderFulfillmentFee = 2,

            /// <summary>
            /// Enum FBAPerUnitFulfillmentFee for value: FBAPerUnitFulfillmentFee
            /// </summary>
            [EnumMember(Value = "FBAPerUnitFulfillmentFee")]
            FBAPerUnitFulfillmentFee = 3,

            /// <summary>
            /// Enum Commission for value: Commission
            /// </summary>
            [EnumMember(Value = "Commission")]
            Commission = 4
        }

        /// <summary>
        /// The type of fee charged to the seller.
        /// </summary>
        /// <value>The type of fee charged to the seller.</value>
        [DataMember(Name = "feeType", EmitDefaultValue = false)]
        public FeeTypeEnum FeeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeLineItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeeLineItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeLineItem" /> class.
        /// </summary>
        /// <param name="FeeType">The type of fee charged to the seller. (required).</param>
        /// <param name="FeeCharge">Amount charged to the seller for the specific fee type. (required).</param>
        public FeeLineItem(FeeTypeEnum FeeType = default(FeeTypeEnum), MoneyType FeeCharge = default(MoneyType))
        {
            // to ensure "FeeType" is required (not null)
            if (FeeType == null)
            {
                throw new InvalidDataException("FeeType is a required property for FeeLineItem and cannot be null");
            }
            else
            {
                this.FeeType = FeeType;
            }
            // to ensure "FeeCharge" is required (not null)
            if (FeeCharge == null)
            {
                throw new InvalidDataException("FeeCharge is a required property for FeeLineItem and cannot be null");
            }
            else
            {
                this.FeeCharge = FeeCharge;
            }
        }


        /// <summary>
        /// Amount charged to the seller for the specific fee type.
        /// </summary>
        /// <value>Amount charged to the seller for the specific fee type.</value>
        [DataMember(Name = "feeCharge", EmitDefaultValue = false)]
        public MoneyType FeeCharge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeeLineItem {\n");
            sb.Append("  FeeType: ").Append(FeeType).Append("\n");
            sb.Append("  FeeCharge: ").Append(FeeCharge).Append("\n");
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
            return this.Equals(input as FeeLineItem);
        }

        /// <summary>
        /// Returns true if FeeLineItem instances are equal
        /// </summary>
        /// <param name="input">Instance of FeeLineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeeLineItem input)
        {
            if (input == null)
                return false;

            return
                (
                    this.FeeType == input.FeeType ||
                    (this.FeeType != null &&
                    this.FeeType.Equals(input.FeeType))
                ) &&
                (
                    this.FeeCharge == input.FeeCharge ||
                    (this.FeeCharge != null &&
                    this.FeeCharge.Equals(input.FeeCharge))
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
                if (this.FeeType != null)
                    hashCode = hashCode * 59 + this.FeeType.GetHashCode();
                if (this.FeeCharge != null)
                    hashCode = hashCode * 59 + this.FeeCharge.GetHashCode();
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
