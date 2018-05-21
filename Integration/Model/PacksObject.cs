/* 
 * Tpay.com Technical Documentation
 *
 *  <p class=\"changes-disclaimer\"> Demo transaction/masspayments api key: <input type=\"text\" id=\"transaction_key\" value=\"75f86137a6635df826e3efe2e66f7c9a946fdde1\" class=\"ui-form-control\"/><label for=\"transaction_key\" style=\"display: none;\" id=\"tr_api_label\">COPIED!</label><br/><br/> Demo cards api key: <input type=\"text\" id=\"cards_key\" value=\"ba9a05faa697f9b43f39b84933ff168e373c6496\" class=\"ui-form-control\"/><label for=\"cards_key\" style=\"display: none;\" id=\"cards_api_label\">COPIED!</label><br/><br/> Demo registration api key: <input type=\"text\" id=\"registration_key\" value=\"6c0f5ef6e4d6877abad7fcfb3b5de117ad8b772d\" class=\"ui-form-control\"/><label for=\"registration_key\" style=\"display: none;\" id=\"registration_api_label\">COPIED!</label><br/><br/> The terms seller and merchant are used interchangeably and they both refer to a person or a company registered at tpay.com to accept online payments. <br/> Whenever term merchant panel is used it refers to the part of tpay.com website located at <a href=\"https://secure.tpay.com/panel\" target=\"_blank\">secure.tpay.com/panel</a>. <br/><br/> For sandbox purposes use merchant demo account <br/><br/> ID - 1010, Password - demo<br/><br/>Remember that this is a shared account, so all data passed through will be publicly visible.</p>
 *
 * OpenAPI spec version: 1.1.1
 * Contact: pt@tpay.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Each pack object represents one created pack contents
    /// </summary>
    [DataContract]
    public partial class PacksObject :  IEquatable<PacksObject>, IValidatableObject
    {
        /// <summary>
        /// Package status
        /// </summary>
        /// <value>Package status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 1,
            
            /// <summary>
            /// Enum Auth for value: auth
            /// </summary>
            [EnumMember(Value = "auth")]
            Auth = 2
        }

        /// <summary>
        /// Package status
        /// </summary>
        /// <value>Package status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PacksObject" /> class.
        /// </summary>
        /// <param name="PackId">PackId.</param>
        /// <param name="Date">Date of package creation.</param>
        /// <param name="AuthDate">Date of package authorization (method authorize).</param>
        /// <param name="Status">Package status.</param>
        /// <param name="Count">Number of transfers in the package.</param>
        /// <param name="Sum">Sum of transfers in the package.</param>
        /// <param name="Cost">Additional cost of processing transfers in the package .</param>
        public PacksObject(PackId PackId = default(PackId), string Date = default(string), string AuthDate = default(string), StatusEnum? Status = default(StatusEnum?), int? Count = default(int?), decimal? Sum = default(decimal?), decimal? Cost = default(decimal?))
        {
            this.PackId = PackId;
            this.Date = Date;
            this.AuthDate = AuthDate;
            this.Status = Status;
            this.Count = Count;
            this.Sum = Sum;
            this.Cost = Cost;
        }
        
        /// <summary>
        /// Gets or Sets PackId
        /// </summary>
        [DataMember(Name="pack_id", EmitDefaultValue=false)]
        public PackId PackId { get; set; }

        /// <summary>
        /// Date of package creation
        /// </summary>
        /// <value>Date of package creation</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// Date of package authorization (method authorize)
        /// </summary>
        /// <value>Date of package authorization (method authorize)</value>
        [DataMember(Name="auth_date", EmitDefaultValue=false)]
        public string AuthDate { get; set; }


        /// <summary>
        /// Number of transfers in the package
        /// </summary>
        /// <value>Number of transfers in the package</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// Sum of transfers in the package
        /// </summary>
        /// <value>Sum of transfers in the package</value>
        [DataMember(Name="sum", EmitDefaultValue=false)]
        public decimal? Sum { get; set; }

        /// <summary>
        /// Additional cost of processing transfers in the package 
        /// </summary>
        /// <value>Additional cost of processing transfers in the package </value>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public decimal? Cost { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PacksObject {\n");
            sb.Append("  PackId: ").Append(PackId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  AuthDate: ").Append(AuthDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Sum: ").Append(Sum).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
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
            return this.Equals(input as PacksObject);
        }

        /// <summary>
        /// Returns true if PacksObject instances are equal
        /// </summary>
        /// <param name="input">Instance of PacksObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PacksObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PackId == input.PackId ||
                    (this.PackId != null &&
                    this.PackId.Equals(input.PackId))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.AuthDate == input.AuthDate ||
                    (this.AuthDate != null &&
                    this.AuthDate.Equals(input.AuthDate))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Sum == input.Sum ||
                    (this.Sum != null &&
                    this.Sum.Equals(input.Sum))
                ) && 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
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
                if (this.PackId != null)
                    hashCode = hashCode * 59 + this.PackId.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.AuthDate != null)
                    hashCode = hashCode * 59 + this.AuthDate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Sum != null)
                    hashCode = hashCode * 59 + this.Sum.GetHashCode();
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
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
            // Date (string) pattern
            Regex regexDate = new Regex(@"YYYY-MM-DD HH:mm:ss", RegexOptions.CultureInvariant);
            if (false == regexDate.Match(this.Date).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Date, must match a pattern of " + regexDate, new [] { "Date" });
            }

            // AuthDate (string) pattern
            Regex regexAuthDate = new Regex(@"YYYY-MM-DD HH:mm:ss", RegexOptions.CultureInvariant);
            if (false == regexAuthDate.Match(this.AuthDate).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AuthDate, must match a pattern of " + regexAuthDate, new [] { "AuthDate" });
            }

            yield break;
        }
    }

}