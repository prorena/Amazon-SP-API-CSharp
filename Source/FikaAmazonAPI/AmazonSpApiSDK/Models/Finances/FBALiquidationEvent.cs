/* 
 * Selling Partner API for Finances
 *
 * The Selling Partner API for Finances helps you obtain financial information relevant to a seller's business. You can obtain financial events for a given order, financial event group, or date range without having to wait until a statement period closes. You can also obtain financial event groups for a given date range.
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

namespace AmazonSpApiSDK.Models.Finances
{
    /// <summary>
    /// A payment event for Fulfillment by Amazon (FBA) inventory liquidation. This event is used only in the US marketplace.
    /// </summary>
    [DataContract]
    public partial class FBALiquidationEvent : IEquatable<FBALiquidationEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FBALiquidationEvent" /> class.
        /// </summary>
        /// <param name="PostedDate">The date and time when the financial event was posted..</param>
        /// <param name="OriginalRemovalOrderId">The identifier for the original removal order..</param>
        /// <param name="LiquidationProceedsAmount">The amount paid by the liquidator for the seller&#39;s inventory. The seller receives this amount minus LiquidationFeeAmount..</param>
        /// <param name="LiquidationFeeAmount">The fee charged to the seller by Amazon for liquidating the seller&#39;s FBA inventory..</param>
        public FBALiquidationEvent(DateTime? PostedDate = default(DateTime?), string OriginalRemovalOrderId = default(string), Currency LiquidationProceedsAmount = default(Currency), Currency LiquidationFeeAmount = default(Currency))
        {
            this.PostedDate = PostedDate;
            this.OriginalRemovalOrderId = OriginalRemovalOrderId;
            this.LiquidationProceedsAmount = LiquidationProceedsAmount;
            this.LiquidationFeeAmount = LiquidationFeeAmount;
        }

        /// <summary>
        /// The date and time when the financial event was posted.
        /// </summary>
        /// <value>The date and time when the financial event was posted.</value>
        [DataMember(Name = "PostedDate", EmitDefaultValue = false)]
        public DateTime? PostedDate { get; set; }

        /// <summary>
        /// The identifier for the original removal order.
        /// </summary>
        /// <value>The identifier for the original removal order.</value>
        [DataMember(Name = "OriginalRemovalOrderId", EmitDefaultValue = false)]
        public string OriginalRemovalOrderId { get; set; }

        /// <summary>
        /// The amount paid by the liquidator for the seller&#39;s inventory. The seller receives this amount minus LiquidationFeeAmount.
        /// </summary>
        /// <value>The amount paid by the liquidator for the seller&#39;s inventory. The seller receives this amount minus LiquidationFeeAmount.</value>
        [DataMember(Name = "LiquidationProceedsAmount", EmitDefaultValue = false)]
        public Currency LiquidationProceedsAmount { get; set; }

        /// <summary>
        /// The fee charged to the seller by Amazon for liquidating the seller&#39;s FBA inventory.
        /// </summary>
        /// <value>The fee charged to the seller by Amazon for liquidating the seller&#39;s FBA inventory.</value>
        [DataMember(Name = "LiquidationFeeAmount", EmitDefaultValue = false)]
        public Currency LiquidationFeeAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FBALiquidationEvent {\n");
            sb.Append("  PostedDate: ").Append(PostedDate).Append("\n");
            sb.Append("  OriginalRemovalOrderId: ").Append(OriginalRemovalOrderId).Append("\n");
            sb.Append("  LiquidationProceedsAmount: ").Append(LiquidationProceedsAmount).Append("\n");
            sb.Append("  LiquidationFeeAmount: ").Append(LiquidationFeeAmount).Append("\n");
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
            return this.Equals(input as FBALiquidationEvent);
        }

        /// <summary>
        /// Returns true if FBALiquidationEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of FBALiquidationEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FBALiquidationEvent input)
        {
            if (input == null)
                return false;

            return
                (
                    this.PostedDate == input.PostedDate ||
                    (this.PostedDate != null &&
                    this.PostedDate.Equals(input.PostedDate))
                ) &&
                (
                    this.OriginalRemovalOrderId == input.OriginalRemovalOrderId ||
                    (this.OriginalRemovalOrderId != null &&
                    this.OriginalRemovalOrderId.Equals(input.OriginalRemovalOrderId))
                ) &&
                (
                    this.LiquidationProceedsAmount == input.LiquidationProceedsAmount ||
                    (this.LiquidationProceedsAmount != null &&
                    this.LiquidationProceedsAmount.Equals(input.LiquidationProceedsAmount))
                ) &&
                (
                    this.LiquidationFeeAmount == input.LiquidationFeeAmount ||
                    (this.LiquidationFeeAmount != null &&
                    this.LiquidationFeeAmount.Equals(input.LiquidationFeeAmount))
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
                if (this.PostedDate != null)
                    hashCode = hashCode * 59 + this.PostedDate.GetHashCode();
                if (this.OriginalRemovalOrderId != null)
                    hashCode = hashCode * 59 + this.OriginalRemovalOrderId.GetHashCode();
                if (this.LiquidationProceedsAmount != null)
                    hashCode = hashCode * 59 + this.LiquidationProceedsAmount.GetHashCode();
                if (this.LiquidationFeeAmount != null)
                    hashCode = hashCode * 59 + this.LiquidationFeeAmount.GetHashCode();
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
