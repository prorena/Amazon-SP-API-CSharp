/* 
 * Selling Partner API for Direct Fulfillment Orders
 *
 * The Selling Partner API for Direct Fulfillment Orders provides programmatic access to a direct fulfillment vendor's order data.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorDirectFulfillmentOrders
{
    /// <summary>
    /// Shipment dates.
    /// </summary>
    [DataContract]
    public partial class ShipmentDates :  IEquatable<ShipmentDates>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentDates" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShipmentDates() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentDates" /> class.
        /// </summary>
        /// <param name="requiredShipDate">Time by which the vendor is required to ship the order. (required).</param>
        /// <param name="promisedDeliveryDate">Delivery date promised to the Amazon customer..</param>
        public ShipmentDates(DateTime? requiredShipDate = default(DateTime?), DateTime? promisedDeliveryDate = default(DateTime?))
        {
            // to ensure "requiredShipDate" is required (not null)
            if (requiredShipDate == null)
            {
                throw new InvalidDataException("requiredShipDate is a required property for ShipmentDates and cannot be null");
            }
            else
            {
                this.RequiredShipDate = requiredShipDate;
            }
            this.PromisedDeliveryDate = promisedDeliveryDate;
        }
        
        /// <summary>
        /// Time by which the vendor is required to ship the order.
        /// </summary>
        /// <value>Time by which the vendor is required to ship the order.</value>
        [DataMember(Name="requiredShipDate", EmitDefaultValue=false)]
        public DateTime? RequiredShipDate { get; set; }

        /// <summary>
        /// Delivery date promised to the Amazon customer.
        /// </summary>
        /// <value>Delivery date promised to the Amazon customer.</value>
        [DataMember(Name="promisedDeliveryDate", EmitDefaultValue=false)]
        public DateTime? PromisedDeliveryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipmentDates {\n");
            sb.Append("  RequiredShipDate: ").Append(RequiredShipDate).Append("\n");
            sb.Append("  PromisedDeliveryDate: ").Append(PromisedDeliveryDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as ShipmentDates);
        }

        /// <summary>
        /// Returns true if ShipmentDates instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentDates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentDates input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequiredShipDate == input.RequiredShipDate ||
                    (this.RequiredShipDate != null &&
                    this.RequiredShipDate.Equals(input.RequiredShipDate))
                ) && 
                (
                    this.PromisedDeliveryDate == input.PromisedDeliveryDate ||
                    (this.PromisedDeliveryDate != null &&
                    this.PromisedDeliveryDate.Equals(input.PromisedDeliveryDate))
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
                if (this.RequiredShipDate != null)
                    hashCode = hashCode * 59 + this.RequiredShipDate.GetHashCode();
                if (this.PromisedDeliveryDate != null)
                    hashCode = hashCode * 59 + this.PromisedDeliveryDate.GetHashCode();
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
