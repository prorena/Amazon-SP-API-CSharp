/* 
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
 *
 * OpenAPI spec version: v0
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

namespace AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// Information that you provide to Amazon about a Less Than Truckload/Full Truckload (LTL/FTL) shipment by a carrier that has not partnered with Amazon.
    /// </summary>
    [DataContract]
    public partial class NonPartneredLtlDataInput : IEquatable<NonPartneredLtlDataInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NonPartneredLtlDataInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NonPartneredLtlDataInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NonPartneredLtlDataInput" /> class.
        /// </summary>
        /// <param name="CarrierName">The carrier that you are using for the inbound shipment. (required).</param>
        /// <param name="ProNumber">ProNumber (required).</param>
        public NonPartneredLtlDataInput(string CarrierName = default(string), ProNumber ProNumber = default(ProNumber))
        {
            // to ensure "CarrierName" is required (not null)
            if (CarrierName == null)
            {
                throw new InvalidDataException("CarrierName is a required property for NonPartneredLtlDataInput and cannot be null");
            }
            else
            {
                this.CarrierName = CarrierName;
            }
            // to ensure "ProNumber" is required (not null)
            if (ProNumber == null)
            {
                throw new InvalidDataException("ProNumber is a required property for NonPartneredLtlDataInput and cannot be null");
            }
            else
            {
                this.ProNumber = ProNumber;
            }
        }

        /// <summary>
        /// The carrier that you are using for the inbound shipment.
        /// </summary>
        /// <value>The carrier that you are using for the inbound shipment.</value>
        [DataMember(Name = "CarrierName", EmitDefaultValue = false)]
        public string CarrierName { get; set; }

        /// <summary>
        /// Gets or Sets ProNumber
        /// </summary>
        [DataMember(Name = "ProNumber", EmitDefaultValue = false)]
        public ProNumber ProNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NonPartneredLtlDataInput {\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  ProNumber: ").Append(ProNumber).Append("\n");
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
            return this.Equals(input as NonPartneredLtlDataInput);
        }

        /// <summary>
        /// Returns true if NonPartneredLtlDataInput instances are equal
        /// </summary>
        /// <param name="input">Instance of NonPartneredLtlDataInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NonPartneredLtlDataInput input)
        {
            if (input == null)
                return false;

            return
                (
                    this.CarrierName == input.CarrierName ||
                    (this.CarrierName != null &&
                    this.CarrierName.Equals(input.CarrierName))
                ) &&
                (
                    this.ProNumber == input.ProNumber ||
                    (this.ProNumber != null &&
                    this.ProNumber.Equals(input.ProNumber))
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
                if (this.CarrierName != null)
                    hashCode = hashCode * 59 + this.CarrierName.GetHashCode();
                if (this.ProNumber != null)
                    hashCode = hashCode * 59 + this.ProNumber.GetHashCode();
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
