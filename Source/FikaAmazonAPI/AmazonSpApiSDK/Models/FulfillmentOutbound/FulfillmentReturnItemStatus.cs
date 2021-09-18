/* 
 * Selling Partner API for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

namespace AmazonSpApiSDK.Models.FulfillmentOutbound
{
    /// <summary>
    /// Indicates if the return item has been processed by a fulfillment center.
    /// </summary>
    /// <value>Indicates if the return item has been processed by a fulfillment center.</value>

    public enum FulfillmentReturnItemStatus
    {

        /// <summary>
        /// Enum New for value: New
        /// </summary>

        New,

        /// <summary>
        /// Enum Processed for value: Processed
        /// </summary>

        Processed
    }

}
