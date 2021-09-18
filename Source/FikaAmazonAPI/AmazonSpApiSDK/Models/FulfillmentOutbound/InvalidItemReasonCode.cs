/* 
 * Selling Partner API for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace AmazonSpApiSDK.Models.FulfillmentOutbound
{
    /// <summary>
    /// A code for why the item is invalid for return.
    /// </summary>
    /// <value>A code for why the item is invalid for return.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum InvalidItemReasonCode
    {

        /// <summary>
        /// Enum InvalidValues for value: InvalidValues
        /// </summary>
        [EnumMember(Value = "InvalidValues")]
        InvalidValues = 1,

        /// <summary>
        /// Enum DuplicateRequest for value: DuplicateRequest
        /// </summary>
        [EnumMember(Value = "DuplicateRequest")]
        DuplicateRequest = 2,

        /// <summary>
        /// Enum NoCompletedShipItems for value: NoCompletedShipItems
        /// </summary>
        [EnumMember(Value = "NoCompletedShipItems")]
        NoCompletedShipItems = 3,

        /// <summary>
        /// Enum NoReturnableQuantity for value: NoReturnableQuantity
        /// </summary>
        [EnumMember(Value = "NoReturnableQuantity")]
        NoReturnableQuantity = 4
    }

}
