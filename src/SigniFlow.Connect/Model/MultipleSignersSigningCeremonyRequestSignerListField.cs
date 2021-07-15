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
    /// MultipleSignersSigningCeremonyRequestSignerListField
    /// </summary>
    [DataContract(Name = "MultipleSignersSigningCeremonyRequest_SignerListField")]
    public partial class MultipleSignersSigningCeremonyRequestSignerListField : IEquatable<MultipleSignersSigningCeremonyRequestSignerListField>, IValidatableObject
    {
//    
//    
//        /// <summary>
//        /// Initializes a new instance of the <see cref="MultipleSignersSigningCeremonyRequestSignerListField" /> class.
//        /// </summary>
//        [JsonConstructorAttribute]
//        
//        protected MultipleSignersSigningCeremonyRequestSignerListField() { }
//        
//        
//    
//    
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleSignersSigningCeremonyRequestSignerListField" /> class.
        /// </summary>
        /// <param name="signatureHField">Signature field height. (required).</param>
        /// <param name="signatureImageField">Signature image (required).</param>
        /// <param name="signatureImageIncludeBorderField">Signature image with borders (required).</param>
        /// <param name="signatureImageIncludeReasonField">Signature image with a reason. (required).</param>
        /// <param name="signatureImageIncludeSignedByField">Signature image with the signer included. (required).</param>
        /// <param name="signatureImageIncludeSignedDateField">Signature image with signed by date. (required).</param>
        /// <param name="signatureImageTypeField">Signature image type. (required).</param>
        /// <param name="signaturePageField">The page where the signature is. (required).</param>
        /// <param name="signatureWField">Signature field width. (required).</param>
        /// <param name="signatureXField">Signature field x-coordinates. (required).</param>
        /// <param name="signatureYField">Signature field y-coordinates. (required).</param>
        /// <param name="signerEmailField">Signer email address (required).</param>
        /// <param name="signerFullNameField">Signer full name. (required).</param>
        /// <param name="signerIndentificationNumberField">Signer ID number. (required).</param>
        /// <param name="signerLocationField">Signer GPS location. (required).</param>
        /// <param name="signerMobileNumberField">SIgner mobile number (required).</param>
        /// <param name="signerReasonField">Reason for signature of the signer. (required).</param>
        /// <param name="signerTrustOriginField">This field is used to define the source of the Audit keep by the user calling the Signing Ceremony. (required).</param>
        /// <param name="signerTrustReferenceField">A unique identifier that links back to an audit stored by the user calling the Signing Ceremony. (required).</param>
        public MultipleSignersSigningCeremonyRequestSignerListField(decimal signatureHField = default(decimal), string signatureImageField = default(string), bool signatureImageIncludeBorderField = default(bool), bool signatureImageIncludeReasonField = default(bool), bool signatureImageIncludeSignedByField = default(bool), bool signatureImageIncludeSignedDateField = default(bool), decimal signatureImageTypeField = default(decimal), decimal signaturePageField = default(decimal), decimal signatureWField = default(decimal), decimal signatureXField = default(decimal), decimal signatureYField = default(decimal), string signerEmailField = default(string), string signerFullNameField = default(string), string signerIndentificationNumberField = default(string), string signerLocationField = default(string), string signerMobileNumberField = default(string), string signerReasonField = default(string), string signerTrustOriginField = default(string), string signerTrustReferenceField = default(string))
        {
            this.SignatureHField = signatureHField;
            // to ensure "signatureImageField" is required (not null)
            this.SignatureImageField = signatureImageField ?? throw new ArgumentNullException("signatureImageField is a required property for MultipleSignersSigningCeremonyRequestSignerListField and cannot be null");
            this.SignatureImageIncludeBorderField = signatureImageIncludeBorderField;
            this.SignatureImageIncludeReasonField = signatureImageIncludeReasonField;
            this.SignatureImageIncludeSignedByField = signatureImageIncludeSignedByField;
            this.SignatureImageIncludeSignedDateField = signatureImageIncludeSignedDateField;
            this.SignatureImageTypeField = signatureImageTypeField;
            this.SignaturePageField = signaturePageField;
            this.SignatureWField = signatureWField;
            this.SignatureXField = signatureXField;
            this.SignatureYField = signatureYField;
            // to ensure "signerEmailField" is required (not null)
            this.SignerEmailField = signerEmailField ?? throw new ArgumentNullException("signerEmailField is a required property for MultipleSignersSigningCeremonyRequestSignerListField and cannot be null");
            // to ensure "signerFullNameField" is required (not null)
            this.SignerFullNameField = signerFullNameField ?? throw new ArgumentNullException("signerFullNameField is a required property for MultipleSignersSigningCeremonyRequestSignerListField and cannot be null");
            // to ensure "signerIndentificationNumberField" is required (not null)
            this.SignerIndentificationNumberField = signerIndentificationNumberField ?? throw new ArgumentNullException("signerIndentificationNumberField is a required property for MultipleSignersSigningCeremonyRequestSignerListField and cannot be null");
            // to ensure "signerLocationField" is required (not null)
            this.SignerLocationField = signerLocationField ?? throw new ArgumentNullException("signerLocationField is a required property for MultipleSignersSigningCeremonyRequestSignerListField and cannot be null");
            // to ensure "signerMobileNumberField" is required (not null)
            this.SignerMobileNumberField = signerMobileNumberField ?? throw new ArgumentNullException("signerMobileNumberField is a required property for MultipleSignersSigningCeremonyRequestSignerListField and cannot be null");
            // to ensure "signerReasonField" is required (not null)
            this.SignerReasonField = signerReasonField ?? throw new ArgumentNullException("signerReasonField is a required property for MultipleSignersSigningCeremonyRequestSignerListField and cannot be null");
            // to ensure "signerTrustOriginField" is required (not null)
            this.SignerTrustOriginField = signerTrustOriginField ?? throw new ArgumentNullException("signerTrustOriginField is a required property for MultipleSignersSigningCeremonyRequestSignerListField and cannot be null");
            // to ensure "signerTrustReferenceField" is required (not null)
            this.SignerTrustReferenceField = signerTrustReferenceField ?? throw new ArgumentNullException("signerTrustReferenceField is a required property for MultipleSignersSigningCeremonyRequestSignerListField and cannot be null");
        }

        /// <summary>
        /// Signature field height.
        /// </summary>
        /// <value>Signature field height.</value>
        [DataMember(Name = "SignatureHField", IsRequired = true, EmitDefaultValue = true)]
        public decimal SignatureHField { get; set; }

        /// <summary>
        /// Signature image
        /// </summary>
        /// <value>Signature image</value>
        [DataMember(Name = "SignatureImageField", IsRequired = true, EmitDefaultValue = true)]
        public string SignatureImageField { get; set; }

        /// <summary>
        /// Signature image with borders
        /// </summary>
        /// <value>Signature image with borders</value>
        [DataMember(Name = "SignatureImageIncludeBorderField", IsRequired = true, EmitDefaultValue = true)]
        public bool SignatureImageIncludeBorderField { get; set; }

        /// <summary>
        /// Signature image with a reason.
        /// </summary>
        /// <value>Signature image with a reason.</value>
        [DataMember(Name = "SignatureImageIncludeReasonField", IsRequired = true, EmitDefaultValue = true)]
        public bool SignatureImageIncludeReasonField { get; set; }

        /// <summary>
        /// Signature image with the signer included.
        /// </summary>
        /// <value>Signature image with the signer included.</value>
        [DataMember(Name = "SignatureImageIncludeSignedByField", IsRequired = true, EmitDefaultValue = true)]
        public bool SignatureImageIncludeSignedByField { get; set; }

        /// <summary>
        /// Signature image with signed by date.
        /// </summary>
        /// <value>Signature image with signed by date.</value>
        [DataMember(Name = "SignatureImageIncludeSignedDateField", IsRequired = true, EmitDefaultValue = true)]
        public bool SignatureImageIncludeSignedDateField { get; set; }

        /// <summary>
        /// Signature image type.
        /// </summary>
        /// <value>Signature image type.</value>
        [DataMember(Name = "SignatureImageTypeField", IsRequired = true, EmitDefaultValue = true)]
        public decimal SignatureImageTypeField { get; set; }

        /// <summary>
        /// The page where the signature is.
        /// </summary>
        /// <value>The page where the signature is.</value>
        [DataMember(Name = "SignaturePageField", IsRequired = true, EmitDefaultValue = true)]
        public decimal SignaturePageField { get; set; }

        /// <summary>
        /// Signature field width.
        /// </summary>
        /// <value>Signature field width.</value>
        [DataMember(Name = "SignatureWField", IsRequired = true, EmitDefaultValue = true)]
        public decimal SignatureWField { get; set; }

        /// <summary>
        /// Signature field x-coordinates.
        /// </summary>
        /// <value>Signature field x-coordinates.</value>
        [DataMember(Name = "SignatureXField", IsRequired = true, EmitDefaultValue = true)]
        public decimal SignatureXField { get; set; }

        /// <summary>
        /// Signature field y-coordinates.
        /// </summary>
        /// <value>Signature field y-coordinates.</value>
        [DataMember(Name = "SignatureYField", IsRequired = true, EmitDefaultValue = true)]
        public decimal SignatureYField { get; set; }

        /// <summary>
        /// Signer email address
        /// </summary>
        /// <value>Signer email address</value>
        [DataMember(Name = "SignerEmailField", IsRequired = true, EmitDefaultValue = true)]
        public string SignerEmailField { get; set; }

        /// <summary>
        /// Signer full name.
        /// </summary>
        /// <value>Signer full name.</value>
        [DataMember(Name = "SignerFullNameField", IsRequired = true, EmitDefaultValue = true)]
        public string SignerFullNameField { get; set; }

        /// <summary>
        /// Signer ID number.
        /// </summary>
        /// <value>Signer ID number.</value>
        [DataMember(Name = "SignerIndentificationNumberField", IsRequired = true, EmitDefaultValue = true)]
        public string SignerIndentificationNumberField { get; set; }

        /// <summary>
        /// Signer GPS location.
        /// </summary>
        /// <value>Signer GPS location.</value>
        [DataMember(Name = "SignerLocationField", IsRequired = true, EmitDefaultValue = true)]
        public string SignerLocationField { get; set; }

        /// <summary>
        /// SIgner mobile number
        /// </summary>
        /// <value>SIgner mobile number</value>
        [DataMember(Name = "SignerMobileNumberField", IsRequired = true, EmitDefaultValue = true)]
        public string SignerMobileNumberField { get; set; }

        /// <summary>
        /// Reason for signature of the signer.
        /// </summary>
        /// <value>Reason for signature of the signer.</value>
        [DataMember(Name = "SignerReasonField", IsRequired = true, EmitDefaultValue = true)]
        public string SignerReasonField { get; set; }

        /// <summary>
        /// This field is used to define the source of the Audit keep by the user calling the Signing Ceremony.
        /// </summary>
        /// <value>This field is used to define the source of the Audit keep by the user calling the Signing Ceremony.</value>
        [DataMember(Name = "SignerTrustOriginField", IsRequired = true, EmitDefaultValue = true)]
        public string SignerTrustOriginField { get; set; }

        /// <summary>
        /// A unique identifier that links back to an audit stored by the user calling the Signing Ceremony.
        /// </summary>
        /// <value>A unique identifier that links back to an audit stored by the user calling the Signing Ceremony.</value>
        [DataMember(Name = "SignerTrustReferenceField", IsRequired = true, EmitDefaultValue = true)]
        public string SignerTrustReferenceField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultipleSignersSigningCeremonyRequestSignerListField {\n");
            sb.Append("  SignatureHField: ").Append(SignatureHField).Append("\n");
            sb.Append("  SignatureImageField: ").Append(SignatureImageField).Append("\n");
            sb.Append("  SignatureImageIncludeBorderField: ").Append(SignatureImageIncludeBorderField).Append("\n");
            sb.Append("  SignatureImageIncludeReasonField: ").Append(SignatureImageIncludeReasonField).Append("\n");
            sb.Append("  SignatureImageIncludeSignedByField: ").Append(SignatureImageIncludeSignedByField).Append("\n");
            sb.Append("  SignatureImageIncludeSignedDateField: ").Append(SignatureImageIncludeSignedDateField).Append("\n");
            sb.Append("  SignatureImageTypeField: ").Append(SignatureImageTypeField).Append("\n");
            sb.Append("  SignaturePageField: ").Append(SignaturePageField).Append("\n");
            sb.Append("  SignatureWField: ").Append(SignatureWField).Append("\n");
            sb.Append("  SignatureXField: ").Append(SignatureXField).Append("\n");
            sb.Append("  SignatureYField: ").Append(SignatureYField).Append("\n");
            sb.Append("  SignerEmailField: ").Append(SignerEmailField).Append("\n");
            sb.Append("  SignerFullNameField: ").Append(SignerFullNameField).Append("\n");
            sb.Append("  SignerIndentificationNumberField: ").Append(SignerIndentificationNumberField).Append("\n");
            sb.Append("  SignerLocationField: ").Append(SignerLocationField).Append("\n");
            sb.Append("  SignerMobileNumberField: ").Append(SignerMobileNumberField).Append("\n");
            sb.Append("  SignerReasonField: ").Append(SignerReasonField).Append("\n");
            sb.Append("  SignerTrustOriginField: ").Append(SignerTrustOriginField).Append("\n");
            sb.Append("  SignerTrustReferenceField: ").Append(SignerTrustReferenceField).Append("\n");
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
            return this.Equals(input as MultipleSignersSigningCeremonyRequestSignerListField);
        }

        /// <summary>
        /// Returns true if MultipleSignersSigningCeremonyRequestSignerListField instances are equal
        /// </summary>
        /// <param name="input">Instance of MultipleSignersSigningCeremonyRequestSignerListField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultipleSignersSigningCeremonyRequestSignerListField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SignatureHField == input.SignatureHField ||
                    this.SignatureHField.Equals(input.SignatureHField)
                ) && 
                (
                    this.SignatureImageField == input.SignatureImageField ||
                    (this.SignatureImageField != null &&
                    this.SignatureImageField.Equals(input.SignatureImageField))
                ) && 
                (
                    this.SignatureImageIncludeBorderField == input.SignatureImageIncludeBorderField ||
                    this.SignatureImageIncludeBorderField.Equals(input.SignatureImageIncludeBorderField)
                ) && 
                (
                    this.SignatureImageIncludeReasonField == input.SignatureImageIncludeReasonField ||
                    this.SignatureImageIncludeReasonField.Equals(input.SignatureImageIncludeReasonField)
                ) && 
                (
                    this.SignatureImageIncludeSignedByField == input.SignatureImageIncludeSignedByField ||
                    this.SignatureImageIncludeSignedByField.Equals(input.SignatureImageIncludeSignedByField)
                ) && 
                (
                    this.SignatureImageIncludeSignedDateField == input.SignatureImageIncludeSignedDateField ||
                    this.SignatureImageIncludeSignedDateField.Equals(input.SignatureImageIncludeSignedDateField)
                ) && 
                (
                    this.SignatureImageTypeField == input.SignatureImageTypeField ||
                    this.SignatureImageTypeField.Equals(input.SignatureImageTypeField)
                ) && 
                (
                    this.SignaturePageField == input.SignaturePageField ||
                    this.SignaturePageField.Equals(input.SignaturePageField)
                ) && 
                (
                    this.SignatureWField == input.SignatureWField ||
                    this.SignatureWField.Equals(input.SignatureWField)
                ) && 
                (
                    this.SignatureXField == input.SignatureXField ||
                    this.SignatureXField.Equals(input.SignatureXField)
                ) && 
                (
                    this.SignatureYField == input.SignatureYField ||
                    this.SignatureYField.Equals(input.SignatureYField)
                ) && 
                (
                    this.SignerEmailField == input.SignerEmailField ||
                    (this.SignerEmailField != null &&
                    this.SignerEmailField.Equals(input.SignerEmailField))
                ) && 
                (
                    this.SignerFullNameField == input.SignerFullNameField ||
                    (this.SignerFullNameField != null &&
                    this.SignerFullNameField.Equals(input.SignerFullNameField))
                ) && 
                (
                    this.SignerIndentificationNumberField == input.SignerIndentificationNumberField ||
                    (this.SignerIndentificationNumberField != null &&
                    this.SignerIndentificationNumberField.Equals(input.SignerIndentificationNumberField))
                ) && 
                (
                    this.SignerLocationField == input.SignerLocationField ||
                    (this.SignerLocationField != null &&
                    this.SignerLocationField.Equals(input.SignerLocationField))
                ) && 
                (
                    this.SignerMobileNumberField == input.SignerMobileNumberField ||
                    (this.SignerMobileNumberField != null &&
                    this.SignerMobileNumberField.Equals(input.SignerMobileNumberField))
                ) && 
                (
                    this.SignerReasonField == input.SignerReasonField ||
                    (this.SignerReasonField != null &&
                    this.SignerReasonField.Equals(input.SignerReasonField))
                ) && 
                (
                    this.SignerTrustOriginField == input.SignerTrustOriginField ||
                    (this.SignerTrustOriginField != null &&
                    this.SignerTrustOriginField.Equals(input.SignerTrustOriginField))
                ) && 
                (
                    this.SignerTrustReferenceField == input.SignerTrustReferenceField ||
                    (this.SignerTrustReferenceField != null &&
                    this.SignerTrustReferenceField.Equals(input.SignerTrustReferenceField))
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
                hashCode = hashCode * 59 + this.SignatureHField.GetHashCode();
                if (this.SignatureImageField != null)
                    hashCode = hashCode * 59 + this.SignatureImageField.GetHashCode();
                hashCode = hashCode * 59 + this.SignatureImageIncludeBorderField.GetHashCode();
                hashCode = hashCode * 59 + this.SignatureImageIncludeReasonField.GetHashCode();
                hashCode = hashCode * 59 + this.SignatureImageIncludeSignedByField.GetHashCode();
                hashCode = hashCode * 59 + this.SignatureImageIncludeSignedDateField.GetHashCode();
                hashCode = hashCode * 59 + this.SignatureImageTypeField.GetHashCode();
                hashCode = hashCode * 59 + this.SignaturePageField.GetHashCode();
                hashCode = hashCode * 59 + this.SignatureWField.GetHashCode();
                hashCode = hashCode * 59 + this.SignatureXField.GetHashCode();
                hashCode = hashCode * 59 + this.SignatureYField.GetHashCode();
                if (this.SignerEmailField != null)
                    hashCode = hashCode * 59 + this.SignerEmailField.GetHashCode();
                if (this.SignerFullNameField != null)
                    hashCode = hashCode * 59 + this.SignerFullNameField.GetHashCode();
                if (this.SignerIndentificationNumberField != null)
                    hashCode = hashCode * 59 + this.SignerIndentificationNumberField.GetHashCode();
                if (this.SignerLocationField != null)
                    hashCode = hashCode * 59 + this.SignerLocationField.GetHashCode();
                if (this.SignerMobileNumberField != null)
                    hashCode = hashCode * 59 + this.SignerMobileNumberField.GetHashCode();
                if (this.SignerReasonField != null)
                    hashCode = hashCode * 59 + this.SignerReasonField.GetHashCode();
                if (this.SignerTrustOriginField != null)
                    hashCode = hashCode * 59 + this.SignerTrustOriginField.GetHashCode();
                if (this.SignerTrustReferenceField != null)
                    hashCode = hashCode * 59 + this.SignerTrustReferenceField.GetHashCode();
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
            // SignatureImageField (string) minLength
            if(this.SignatureImageField != null && this.SignatureImageField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SignatureImageField, length must be greater than 1.", new [] { "SignatureImageField" });
            }

            // SignerEmailField (string) minLength
            if(this.SignerEmailField != null && this.SignerEmailField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SignerEmailField, length must be greater than 1.", new [] { "SignerEmailField" });
            }

            // SignerFullNameField (string) minLength
            if(this.SignerFullNameField != null && this.SignerFullNameField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SignerFullNameField, length must be greater than 1.", new [] { "SignerFullNameField" });
            }

            // SignerIndentificationNumberField (string) minLength
            if(this.SignerIndentificationNumberField != null && this.SignerIndentificationNumberField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SignerIndentificationNumberField, length must be greater than 1.", new [] { "SignerIndentificationNumberField" });
            }

            // SignerLocationField (string) minLength
            if(this.SignerLocationField != null && this.SignerLocationField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SignerLocationField, length must be greater than 1.", new [] { "SignerLocationField" });
            }

            // SignerMobileNumberField (string) minLength
            if(this.SignerMobileNumberField != null && this.SignerMobileNumberField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SignerMobileNumberField, length must be greater than 1.", new [] { "SignerMobileNumberField" });
            }

            // SignerReasonField (string) minLength
            if(this.SignerReasonField != null && this.SignerReasonField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SignerReasonField, length must be greater than 1.", new [] { "SignerReasonField" });
            }

            // SignerTrustOriginField (string) minLength
            if(this.SignerTrustOriginField != null && this.SignerTrustOriginField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SignerTrustOriginField, length must be greater than 1.", new [] { "SignerTrustOriginField" });
            }

            // SignerTrustReferenceField (string) minLength
            if(this.SignerTrustReferenceField != null && this.SignerTrustReferenceField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SignerTrustReferenceField, length must be greater than 1.", new [] { "SignerTrustReferenceField" });
            }

            yield break;
        }
    }

}
