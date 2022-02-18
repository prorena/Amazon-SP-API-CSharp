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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// Carrier, tracking number, and status information for the package.
    /// </summary>
    [DataContract]
    public partial class NonPartneredSmallParcelPackageOutput : IEquatable<NonPartneredSmallParcelPackageOutput>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets PackageStatus
        /// </summary>
        [DataMember(Name = "PackageStatus", EmitDefaultValue = false)]
        public PackageStatus PackageStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NonPartneredSmallParcelPackageOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public NonPartneredSmallParcelPackageOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NonPartneredSmallParcelPackageOutput" /> class.
        /// </summary>
        /// <param name="CarrierName">The carrier that you are using for the inbound shipment. (required).</param>
        /// <param name="TrackingId">TrackingId (required).</param>
        /// <param name="PackageStatus">PackageStatus (required).</param>
        public NonPartneredSmallParcelPackageOutput(string CarrierName = default(string), string TrackingId = default(string), PackageStatus PackageStatus = default(PackageStatus))
        {
            // to ensure "CarrierName" is required (not null)
            if (CarrierName == null)
            {
                throw new InvalidDataException("CarrierName is a required property for NonPartneredSmallParcelPackageOutput and cannot be null");
            }
            else
            {
                this.CarrierName = CarrierName;
            }
            // to ensure "TrackingId" is required (not null)
            if (TrackingId == null)
            {
                throw new InvalidDataException("TrackingId is a required property for NonPartneredSmallParcelPackageOutput and cannot be null");
            }
            else
            {
                this.TrackingId = TrackingId;
            }
            // to ensure "PackageStatus" is required (not null)
            if (PackageStatus == null)
            {
                throw new InvalidDataException("PackageStatus is a required property for NonPartneredSmallParcelPackageOutput and cannot be null");
            }
            else
            {
                this.PackageStatus = PackageStatus;
            }
        }

        /// <summary>
        /// The carrier that you are using for the inbound shipment.
        /// </summary>
        /// <value>The carrier that you are using for the inbound shipment.</value>
        [DataMember(Name = "CarrierName", EmitDefaultValue = false)]
        public string CarrierName { get; set; }

        /// <summary>
        /// Gets or Sets TrackingId
        /// </summary>
        [DataMember(Name = "TrackingId", EmitDefaultValue = false)]
        public string TrackingId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NonPartneredSmallParcelPackageOutput {\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  TrackingId: ").Append(TrackingId).Append("\n");
            sb.Append("  PackageStatus: ").Append(PackageStatus).Append("\n");
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
            return this.Equals(input as NonPartneredSmallParcelPackageOutput);
        }

        /// <summary>
        /// Returns true if NonPartneredSmallParcelPackageOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of NonPartneredSmallParcelPackageOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NonPartneredSmallParcelPackageOutput input)
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
                    this.TrackingId == input.TrackingId ||
                    (this.TrackingId != null &&
                    this.TrackingId.Equals(input.TrackingId))
                ) &&
                (
                    this.PackageStatus == input.PackageStatus ||
                    (this.PackageStatus != null &&
                    this.PackageStatus.Equals(input.PackageStatus))
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
                if (this.TrackingId != null)
                    hashCode = hashCode * 59 + this.TrackingId.GetHashCode();
                if (this.PackageStatus != null)
                    hashCode = hashCode * 59 + this.PackageStatus.GetHashCode();
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
