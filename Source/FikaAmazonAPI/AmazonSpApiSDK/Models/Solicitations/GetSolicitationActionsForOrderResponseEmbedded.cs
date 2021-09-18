/* 
 * Selling Partner API for Solicitations
 *
 * With the Solicitations API you can build applications that send non-critical solicitations to buyers. You can get a list of solicitation types that are available for an order that you specify, then call an operation that sends a solicitation to the buyer for that order. Buyers cannot respond to solicitations sent by this API, and these solicitations do not appear in the Messaging section of Seller Central or in the recipient's Message Center. The Solicitations API returns responses that are formed according to the <a href=https://tools.ietf.org/html/draft-kelly-json-hal-08>JSON Hypertext Application Language</a> (HAL) standard.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.Solicitations
{
    /// <summary>
    /// GetSolicitationActionsForOrderResponseEmbedded
    /// </summary>
    [DataContract]
    public partial class GetSolicitationActionsForOrderResponseEmbedded : IEquatable<GetSolicitationActionsForOrderResponseEmbedded>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSolicitationActionsForOrderResponseEmbedded" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSolicitationActionsForOrderResponseEmbedded() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSolicitationActionsForOrderResponseEmbedded" /> class.
        /// </summary>
        /// <param name="Actions">Actions (required).</param>
        public GetSolicitationActionsForOrderResponseEmbedded(List<GetSolicitationActionResponse> Actions = default(List<GetSolicitationActionResponse>))
        {
            // to ensure "Actions" is required (not null)
            if (Actions == null)
            {
                throw new InvalidDataException("Actions is a required property for GetSolicitationActionsForOrderResponseEmbedded and cannot be null");
            }
            else
            {
                this.Actions = Actions;
            }
        }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name = "actions", EmitDefaultValue = false)]
        public List<GetSolicitationActionResponse> Actions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetSolicitationActionsForOrderResponseEmbedded {\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
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
            return this.Equals(input as GetSolicitationActionsForOrderResponseEmbedded);
        }

        /// <summary>
        /// Returns true if GetSolicitationActionsForOrderResponseEmbedded instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSolicitationActionsForOrderResponseEmbedded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSolicitationActionsForOrderResponseEmbedded input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
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
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
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
