/* 
 * The Selling Partner API for FBA inbound operations.
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInboundv20240320
{
    /// <summary>
    /// Tracking information for Less-Than-Truckload (LTL) and Small Parcel Delivery (SPD) shipments.
    /// </summary>
    [DataContract]
    public partial class TrackingDetails :  IEquatable<TrackingDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingDetails" /> class.
        /// </summary>
        /// <param name="ltlTrackingDetail">ltlTrackingDetail.</param>
        /// <param name="spdTrackingDetail">spdTrackingDetail.</param>
        public TrackingDetails(LtlTrackingDetail ltlTrackingDetail = default(LtlTrackingDetail), SpdTrackingDetail spdTrackingDetail = default(SpdTrackingDetail))
        {
            this.LtlTrackingDetail = ltlTrackingDetail;
            this.SpdTrackingDetail = spdTrackingDetail;
        }
        
        /// <summary>
        /// Gets or Sets LtlTrackingDetail
        /// </summary>
        [DataMember(Name="ltlTrackingDetail", EmitDefaultValue=false)]
        public LtlTrackingDetail LtlTrackingDetail { get; set; }

        /// <summary>
        /// Gets or Sets SpdTrackingDetail
        /// </summary>
        [DataMember(Name="spdTrackingDetail", EmitDefaultValue=false)]
        public SpdTrackingDetail SpdTrackingDetail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackingDetails {\n");
            sb.Append("  LtlTrackingDetail: ").Append(LtlTrackingDetail).Append("\n");
            sb.Append("  SpdTrackingDetail: ").Append(SpdTrackingDetail).Append("\n");
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
            return this.Equals(input as TrackingDetails);
        }

        /// <summary>
        /// Returns true if TrackingDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackingDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackingDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LtlTrackingDetail == input.LtlTrackingDetail ||
                    (this.LtlTrackingDetail != null &&
                    this.LtlTrackingDetail.Equals(input.LtlTrackingDetail))
                ) && 
                (
                    this.SpdTrackingDetail == input.SpdTrackingDetail ||
                    (this.SpdTrackingDetail != null &&
                    this.SpdTrackingDetail.Equals(input.SpdTrackingDetail))
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
                if (this.LtlTrackingDetail != null)
                    hashCode = hashCode * 59 + this.LtlTrackingDetail.GetHashCode();
                if (this.SpdTrackingDetail != null)
                    hashCode = hashCode * 59 + this.SpdTrackingDetail.GetHashCode();
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
