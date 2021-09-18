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
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.FulfillmentOutbound
{
    /// <summary>
    /// Address
    /// </summary>
    [DataContract]
    public partial class Address : IEquatable<Address>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Address() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="Name">Recipient&#39;s name. (required).</param>
        /// <param name="Line1">Recipient&#39;s street address information. (required).</param>
        /// <param name="Line2">Additional street address information, if required..</param>
        /// <param name="Line3">Additional street address information, if required..</param>
        /// <param name="DistrictOrCounty">Recipient&#39;s district or county..</param>
        /// <param name="City">Recipient&#39;s city..</param>
        /// <param name="StateOrProvinceCode">Recipient&#39;s state or province code. (required).</param>
        /// <param name="CountryCode">Recipient&#39;s country code. (required).</param>
        /// <param name="PostalCode">The postal code (required for shipments to the U.S.)..</param>
        /// <param name="PhoneNumber">Recipient&#39;s phone number..</param>
        public Address(string Name = default(string), string Line1 = default(string), string Line2 = default(string), string Line3 = default(string), string DistrictOrCounty = default(string), string City = default(string), string StateOrProvinceCode = default(string), string CountryCode = default(string), string PostalCode = default(string), string PhoneNumber = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Address and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Line1" is required (not null)
            if (Line1 == null)
            {
                throw new InvalidDataException("Line1 is a required property for Address and cannot be null");
            }
            else
            {
                this.Line1 = Line1;
            }
            // to ensure "StateOrProvinceCode" is required (not null)
            if (StateOrProvinceCode == null)
            {
                throw new InvalidDataException("StateOrProvinceCode is a required property for Address and cannot be null");
            }
            else
            {
                this.StateOrProvinceCode = StateOrProvinceCode;
            }
            // to ensure "CountryCode" is required (not null)
            if (CountryCode == null)
            {
                throw new InvalidDataException("CountryCode is a required property for Address and cannot be null");
            }
            else
            {
                this.CountryCode = CountryCode;
            }
            this.Line2 = Line2;
            this.Line3 = Line3;
            this.DistrictOrCounty = DistrictOrCounty;
            this.City = City;
            this.PostalCode = PostalCode;
            this.PhoneNumber = PhoneNumber;
        }

        /// <summary>
        /// Recipient&#39;s name.
        /// </summary>
        /// <value>Recipient&#39;s name.</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Recipient&#39;s street address information.
        /// </summary>
        /// <value>Recipient&#39;s street address information.</value>
        [DataMember(Name = "Line1", EmitDefaultValue = false)]
        public string Line1 { get; set; }

        /// <summary>
        /// Additional street address information, if required.
        /// </summary>
        /// <value>Additional street address information, if required.</value>
        [DataMember(Name = "Line2", EmitDefaultValue = false)]
        public string Line2 { get; set; }

        /// <summary>
        /// Additional street address information, if required.
        /// </summary>
        /// <value>Additional street address information, if required.</value>
        [DataMember(Name = "Line3", EmitDefaultValue = false)]
        public string Line3 { get; set; }

        /// <summary>
        /// Recipient&#39;s district or county.
        /// </summary>
        /// <value>Recipient&#39;s district or county.</value>
        [DataMember(Name = "DistrictOrCounty", EmitDefaultValue = false)]
        public string DistrictOrCounty { get; set; }

        /// <summary>
        /// Recipient&#39;s city.
        /// </summary>
        /// <value>Recipient&#39;s city.</value>
        [DataMember(Name = "City", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Recipient&#39;s state or province code.
        /// </summary>
        /// <value>Recipient&#39;s state or province code.</value>
        [DataMember(Name = "StateOrProvinceCode", EmitDefaultValue = false)]
        public string StateOrProvinceCode { get; set; }

        /// <summary>
        /// Recipient&#39;s country code.
        /// </summary>
        /// <value>Recipient&#39;s country code.</value>
        [DataMember(Name = "CountryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The postal code (required for shipments to the U.S.).
        /// </summary>
        /// <value>The postal code (required for shipments to the U.S.).</value>
        [DataMember(Name = "PostalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Recipient&#39;s phone number.
        /// </summary>
        /// <value>Recipient&#39;s phone number.</value>
        [DataMember(Name = "PhoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Line1: ").Append(Line1).Append("\n");
            sb.Append("  Line2: ").Append(Line2).Append("\n");
            sb.Append("  Line3: ").Append(Line3).Append("\n");
            sb.Append("  DistrictOrCounty: ").Append(DistrictOrCounty).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  StateOrProvinceCode: ").Append(StateOrProvinceCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            return this.Equals(input as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="input">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address input)
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
                    this.Line1 == input.Line1 ||
                    (this.Line1 != null &&
                    this.Line1.Equals(input.Line1))
                ) &&
                (
                    this.Line2 == input.Line2 ||
                    (this.Line2 != null &&
                    this.Line2.Equals(input.Line2))
                ) &&
                (
                    this.Line3 == input.Line3 ||
                    (this.Line3 != null &&
                    this.Line3.Equals(input.Line3))
                ) &&
                (
                    this.DistrictOrCounty == input.DistrictOrCounty ||
                    (this.DistrictOrCounty != null &&
                    this.DistrictOrCounty.Equals(input.DistrictOrCounty))
                ) &&
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) &&
                (
                    this.StateOrProvinceCode == input.StateOrProvinceCode ||
                    (this.StateOrProvinceCode != null &&
                    this.StateOrProvinceCode.Equals(input.StateOrProvinceCode))
                ) &&
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) &&
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) &&
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
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
                if (this.Line1 != null)
                    hashCode = hashCode * 59 + this.Line1.GetHashCode();
                if (this.Line2 != null)
                    hashCode = hashCode * 59 + this.Line2.GetHashCode();
                if (this.Line3 != null)
                    hashCode = hashCode * 59 + this.Line3.GetHashCode();
                if (this.DistrictOrCounty != null)
                    hashCode = hashCode * 59 + this.DistrictOrCounty.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.StateOrProvinceCode != null)
                    hashCode = hashCode * 59 + this.StateOrProvinceCode.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 50.", new[] { "Name" });
            }

            // Line1 (string) maxLength
            if (this.Line1 != null && this.Line1.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Line1, length must be less than 60.", new[] { "Line1" });
            }

            // Line2 (string) maxLength
            if (this.Line2 != null && this.Line2.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Line2, length must be less than 60.", new[] { "Line2" });
            }

            // Line3 (string) maxLength
            if (this.Line3 != null && this.Line3.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Line3, length must be less than 60.", new[] { "Line3" });
            }

            // DistrictOrCounty (string) maxLength
            if (this.DistrictOrCounty != null && this.DistrictOrCounty.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DistrictOrCounty, length must be less than 150.", new[] { "DistrictOrCounty" });
            }

            // City (string) maxLength
            if (this.City != null && this.City.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 50.", new[] { "City" });
            }

            // StateOrProvinceCode (string) maxLength
            if (this.StateOrProvinceCode != null && this.StateOrProvinceCode.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StateOrProvinceCode, length must be less than 150.", new[] { "StateOrProvinceCode" });
            }

            // CountryCode (string) maxLength
            if (this.CountryCode != null && this.CountryCode.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, length must be less than 2.", new[] { "CountryCode" });
            }

            // PostalCode (string) maxLength
            if (this.PostalCode != null && this.PostalCode.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than 20.", new[] { "PostalCode" });
            }

            // PhoneNumber (string) maxLength
            if (this.PhoneNumber != null && this.PhoneNumber.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PhoneNumber, length must be less than 20.", new[] { "PhoneNumber" });
            }

            yield break;
        }
    }

}
