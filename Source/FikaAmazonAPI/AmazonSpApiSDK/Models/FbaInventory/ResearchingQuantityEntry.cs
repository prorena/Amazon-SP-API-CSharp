/* 
 * Selling Partner API for FBA Inventory
 *
 * The Selling Partner API for FBA Inventory lets you programmatically retrieve information about inventory in Amazon's fulfillment network.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.FbaInventory
{
    /// <summary>
    /// The misplaced or warehouse damaged inventory that is actively being confirmed at our fulfillment centers.
    /// </summary>
    [DataContract]
    public partial class ResearchingQuantityEntry : IEquatable<ResearchingQuantityEntry>, IValidatableObject
    {
        /// <summary>
        /// The duration of the research.
        /// </summary>
        /// <value>The duration of the research.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NameEnum
        {

            /// <summary>
            /// Enum ResearchingQuantityInShortTerm for value: researchingQuantityInShortTerm
            /// </summary>
            [EnumMember(Value = "researchingQuantityInShortTerm")]
            ResearchingQuantityInShortTerm = 1,

            /// <summary>
            /// Enum ResearchingQuantityInMidTerm for value: researchingQuantityInMidTerm
            /// </summary>
            [EnumMember(Value = "researchingQuantityInMidTerm")]
            ResearchingQuantityInMidTerm = 2,

            /// <summary>
            /// Enum ResearchingQuantityInLongTerm for value: researchingQuantityInLongTerm
            /// </summary>
            [EnumMember(Value = "researchingQuantityInLongTerm")]
            ResearchingQuantityInLongTerm = 3
        }

        /// <summary>
        /// The duration of the research.
        /// </summary>
        /// <value>The duration of the research.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public NameEnum Name { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchingQuantityEntry" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResearchingQuantityEntry() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchingQuantityEntry" /> class.
        /// </summary>
        /// <param name="Name">The duration of the research. (required).</param>
        /// <param name="Quantity">The number of units. (required).</param>
        public ResearchingQuantityEntry(NameEnum Name = default(NameEnum), int? Quantity = default(int?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ResearchingQuantityEntry and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for ResearchingQuantityEntry and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
        }


        /// <summary>
        /// The number of units.
        /// </summary>
        /// <value>The number of units.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResearchingQuantityEntry {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as ResearchingQuantityEntry);
        }

        /// <summary>
        /// Returns true if ResearchingQuantityEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of ResearchingQuantityEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResearchingQuantityEntry input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
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
