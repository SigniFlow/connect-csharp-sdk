/*
 * SigniFlow OpenAPI Spec v1
 *
 * ## SigniFlow API used to automate esignature workflow creation and management. 
 *
 * The version of the OpenAPI document: 1.0
 * Contact: support@signiflow.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = SigniFlow.Connect.Client.OpenAPIDateConverter;

namespace SigniFlow.Connect.Model
{
    /// <summary>
    /// #### The response returned when the signing process is requested.
    /// </summary>
    [DataContract(Name = "SigningCeremonyV2Response")]
    public partial class SigningCeremonyV2Response : IEquatable<SigningCeremonyV2Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SigningCeremonyV2Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SigningCeremonyV2Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SigningCeremonyV2Response" /> class.
        /// </summary>
        /// <param name="ceremonyIDField">ceremonyIDField (required).</param>
        /// <param name="resultField">Displays the result of the call. (required).</param>
        /// <param name="signedDocumentField">signedDocumentField (required).</param>
        public SigningCeremonyV2Response(decimal ceremonyIDField = default(decimal), string resultField = default(string), string signedDocumentField = default(string))
        {
            this.CeremonyIDField = ceremonyIDField;
            // to ensure "resultField" is required (not null)
            this.ResultField = resultField ?? throw new ArgumentNullException("resultField is a required property for SigningCeremonyV2Response and cannot be null");
            // to ensure "signedDocumentField" is required (not null)
            this.SignedDocumentField = signedDocumentField ?? throw new ArgumentNullException("signedDocumentField is a required property for SigningCeremonyV2Response and cannot be null");
        }

        /// <summary>
        /// Gets or Sets CeremonyIDField
        /// </summary>
        [DataMember(Name = "CeremonyIDField", IsRequired = true, EmitDefaultValue = false)]
        public decimal CeremonyIDField { get; set; }

        /// <summary>
        /// Displays the result of the call.
        /// </summary>
        /// <value>Displays the result of the call.</value>
        [DataMember(Name = "ResultField", IsRequired = true, EmitDefaultValue = false)]
        public string ResultField { get; set; }

        /// <summary>
        /// Gets or Sets SignedDocumentField
        /// </summary>
        [DataMember(Name = "SignedDocumentField", IsRequired = true, EmitDefaultValue = false)]
        public string SignedDocumentField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SigningCeremonyV2Response {\n");
            sb.Append("  CeremonyIDField: ").Append(CeremonyIDField).Append("\n");
            sb.Append("  ResultField: ").Append(ResultField).Append("\n");
            sb.Append("  SignedDocumentField: ").Append(SignedDocumentField).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SigningCeremonyV2Response);
        }

        /// <summary>
        /// Returns true if SigningCeremonyV2Response instances are equal
        /// </summary>
        /// <param name="input">Instance of SigningCeremonyV2Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SigningCeremonyV2Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CeremonyIDField == input.CeremonyIDField ||
                    this.CeremonyIDField.Equals(input.CeremonyIDField)
                ) && 
                (
                    this.ResultField == input.ResultField ||
                    (this.ResultField != null &&
                    this.ResultField.Equals(input.ResultField))
                ) && 
                (
                    this.SignedDocumentField == input.SignedDocumentField ||
                    (this.SignedDocumentField != null &&
                    this.SignedDocumentField.Equals(input.SignedDocumentField))
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
                hashCode = hashCode * 59 + this.CeremonyIDField.GetHashCode();
                if (this.ResultField != null)
                    hashCode = hashCode * 59 + this.ResultField.GetHashCode();
                if (this.SignedDocumentField != null)
                    hashCode = hashCode * 59 + this.SignedDocumentField.GetHashCode();
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
            // ResultField (string) minLength
            if(this.ResultField != null && this.ResultField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResultField, length must be greater than 1.", new [] { "ResultField" });
            }

            // SignedDocumentField (string) minLength
            if(this.SignedDocumentField != null && this.SignedDocumentField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SignedDocumentField, length must be greater than 1.", new [] { "SignedDocumentField" });
            }

            yield break;
        }
    }

}
