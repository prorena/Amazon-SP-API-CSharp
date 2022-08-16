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
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// The shipment status of the package.
    /// </summary>
    /// <value>The shipment status of the package.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PackageStatus
    {

        /// <summary>
        /// Enum SHIPPED for value: SHIPPED
        /// </summary>

        SHIPPED,

        /// <summary>
        /// Enum INTRANSIT for value: INTRANSIT
        /// </summary>

        [EnumMember(Value = "IN_TRANSIT")]
        INTRANSIT,

        /// <summary>
        /// Enum DELIVERED for value: DELIVERED
        /// </summary>

        DELIVERED,

        /// <summary>
        /// Enum CHECKEDIN for value: CHECKED_IN
        /// </summary>
        [EnumMember(Value = "CHECKED_IN")]
        CHECKEDIN,

        /// <summary>
        /// Enum RECEIVING for value: RECEIVING
        /// </summary>

        RECEIVING,

        /// <summary>
        /// Enum CLOSED for value: CLOSED
        /// </summary>

        CLOSED,

        /// <summary>
        /// Enum DELETED for value: DELETED
        /// </summary>

        DELETED
    }

}
