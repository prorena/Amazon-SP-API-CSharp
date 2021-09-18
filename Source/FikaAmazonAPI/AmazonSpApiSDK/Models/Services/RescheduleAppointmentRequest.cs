/* 
 * Selling Partner API for Services
 *
 * With the Services API, you can build applications that help service providers get and modify their service orders.
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
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.Services
{
    /// <summary>
    /// Input for rescheduled appointment operation.
    /// </summary>
    [DataContract]
    public partial class RescheduleAppointmentRequest : IEquatable<RescheduleAppointmentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RescheduleAppointmentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RescheduleAppointmentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RescheduleAppointmentRequest" /> class.
        /// </summary>
        /// <param name="AppointmentTime">Input appointment time details. (required).</param>
        /// <param name="RescheduleReasonCode">Input appointment reschedule reason. (required).</param>
        public RescheduleAppointmentRequest(AppointmentTimeInput AppointmentTime = default(AppointmentTimeInput), RescheduleReasonCode RescheduleReasonCode = default(RescheduleReasonCode))
        {
            // to ensure "AppointmentTime" is required (not null)
            if (AppointmentTime == null)
            {
                throw new InvalidDataException("AppointmentTime is a required property for RescheduleAppointmentRequest and cannot be null");
            }
            else
            {
                this.AppointmentTime = AppointmentTime;
            }
            // to ensure "RescheduleReasonCode" is required (not null)
            if (RescheduleReasonCode == null)
            {
                throw new InvalidDataException("RescheduleReasonCode is a required property for RescheduleAppointmentRequest and cannot be null");
            }
            else
            {
                this.RescheduleReasonCode = RescheduleReasonCode;
            }
        }

        /// <summary>
        /// Input appointment time details.
        /// </summary>
        /// <value>Input appointment time details.</value>
        [DataMember(Name = "appointmentTime", EmitDefaultValue = false)]
        public AppointmentTimeInput AppointmentTime { get; set; }

        /// <summary>
        /// Input appointment reschedule reason.
        /// </summary>
        /// <value>Input appointment reschedule reason.</value>
        [DataMember(Name = "rescheduleReasonCode", EmitDefaultValue = false)]
        public RescheduleReasonCode RescheduleReasonCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RescheduleAppointmentRequest {\n");
            sb.Append("  AppointmentTime: ").Append(AppointmentTime).Append("\n");
            sb.Append("  RescheduleReasonCode: ").Append(RescheduleReasonCode).Append("\n");
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
            return this.Equals(input as RescheduleAppointmentRequest);
        }

        /// <summary>
        /// Returns true if RescheduleAppointmentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RescheduleAppointmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RescheduleAppointmentRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AppointmentTime == input.AppointmentTime ||
                    (this.AppointmentTime != null &&
                    this.AppointmentTime.Equals(input.AppointmentTime))
                ) &&
                (
                    this.RescheduleReasonCode == input.RescheduleReasonCode ||
                    (this.RescheduleReasonCode != null &&
                    this.RescheduleReasonCode.Equals(input.RescheduleReasonCode))
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
                if (this.AppointmentTime != null)
                    hashCode = hashCode * 59 + this.AppointmentTime.GetHashCode();
                if (this.RescheduleReasonCode != null)
                    hashCode = hashCode * 59 + this.RescheduleReasonCode.GetHashCode();
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
