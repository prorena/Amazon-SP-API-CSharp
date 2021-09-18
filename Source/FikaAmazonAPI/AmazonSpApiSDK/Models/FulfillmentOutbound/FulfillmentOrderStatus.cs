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
    /// The current status of the fulfillment order.
    /// </summary>
    /// <value>The current status of the fulfillment order.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum FulfillmentOrderStatus
    {

        /// <summary>
        /// Enum New for value: New
        /// </summary>
        [EnumMember(Value = "New")]
        New = 1,

        /// <summary>
        /// Enum Received for value: Received
        /// </summary>
        [EnumMember(Value = "Received")]
        Received = 2,

        /// <summary>
        /// Enum Planning for value: Planning
        /// </summary>
        [EnumMember(Value = "Planning")]
        Planning = 3,

        /// <summary>
        /// Enum Processing for value: Processing
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing = 4,

        /// <summary>
        /// Enum Cancelled for value: Cancelled
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled = 5,

        /// <summary>
        /// Enum Complete for value: Complete
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete = 6,

        /// <summary>
        /// Enum CompletePartialled for value: CompletePartialled
        /// </summary>
        [EnumMember(Value = "CompletePartialled")]
        CompletePartialled = 7,

        /// <summary>
        /// Enum Unfulfillable for value: Unfulfillable
        /// </summary>
        [EnumMember(Value = "Unfulfillable")]
        Unfulfillable = 8,

        /// <summary>
        /// Enum Invalid for value: Invalid
        /// </summary>
        [EnumMember(Value = "Invalid")]
        Invalid = 9
    }

}
