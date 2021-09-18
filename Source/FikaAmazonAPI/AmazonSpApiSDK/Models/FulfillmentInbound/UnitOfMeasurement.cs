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

namespace AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// Indicates the unit of measurement.
    /// </summary>
    /// <value>Indicates the unit of measurement.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum UnitOfMeasurement
    {

        /// <summary>
        /// Enum Inches for value: inches
        /// </summary>
        [EnumMember(Value = "inches")]
        Inches = 1,

        /// <summary>
        /// Enum Centimeters for value: centimeters
        /// </summary>
        [EnumMember(Value = "centimeters")]
        Centimeters = 2
    }

}
