/*
 * SigniFlow API
 *
 * API for signing ceremonies
 *
 * The version of the OpenAPI document: 1.0.0
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
    /// SigningCeremonyWithTokenRequest
    /// </summary>
    [DataContract(Name = "SigningCeremonyWithTokenRequest")]
    public partial class SigningCeremonyWithTokenRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SigningCeremonyWithTokenRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SigningCeremonyWithTokenRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SigningCeremonyWithTokenRequest" /> class.
        /// </summary>
        /// <param name="docField">Base64 encoded document or string content (required).</param>
        /// <param name="docNameField">Name of the document to be signed (required).</param>
        /// <param name="signerEmailField">Email of the signer (required).</param>
        /// <param name="signerFullNameField">Full name of the signer (required).</param>
        /// <param name="signerIdentificationNumberField">Identification number of the signer.</param>
        /// <param name="signerLocationField">Location of the signer (required).</param>
        /// <param name="userName">Email of the creator (required).</param>
        /// <param name="signerMobileNumberField">Mobile number of the signer (required).</param>
        /// <param name="signerReasonField">Reason for the signer’s certification (required).</param>
        /// <param name="signerTrustOriginField">The origin of trust for the signer (required).</param>
        /// <param name="signerTrustReferenceField">Reference for the trust origin (required).</param>
        /// <param name="tokenField">tokenField (required).</param>
        public SigningCeremonyWithTokenRequest(string docField = default(string), string docNameField = default(string), string signerEmailField = default(string), string signerFullNameField = default(string), string signerIdentificationNumberField = default(string), string signerLocationField = default(string), string signerMobileNumberField = default(string), string signerReasonField = default(string), string signerTrustOriginField = default(string), string signerTrustReferenceField = default(string), string userName = default(string), TokenField tokenField = default(TokenField))
        {
            // to ensure "docField" is required (not null)
            if (docField == null)
            {
                throw new ArgumentNullException("docField is a required property for SigningCeremonyWithTokenRequest and cannot be null");
            }
            this.DocField = docField;
            // to ensure "docNameField" is required (not null)
            if (docNameField == null)
            {
                throw new ArgumentNullException("docNameField is a required property for SigningCeremonyWithTokenRequest and cannot be null");
            }
            this.DocNameField = docNameField;
            // to ensure "signerEmailField" is required (not null)
            if (signerEmailField == null)
            {
                throw new ArgumentNullException("signerEmailField is a required property for SigningCeremonyWithTokenRequest and cannot be null");
            }
            this.SignerEmailField = signerEmailField;
            // to ensure "userName" is required (not null)
            if (userName == null)
            {
                throw new ArgumentNullException("docField is a required property for SigningCeremonyWithTokenRequest and cannot be null");
            }
            this.UserNameField = userName;
            // to ensure "signerFullNameField" is required (not null)
            if (signerFullNameField == null)
            {
                throw new ArgumentNullException("signerFullNameField is a required property for SigningCeremonyWithTokenRequest and cannot be null");
            }
            this.SignerFullNameField = signerFullNameField;
            // to ensure "signerLocationField" is required (not null)
            if (signerLocationField == null)
            {
                throw new ArgumentNullException("signerLocationField is a required property for SigningCeremonyWithTokenRequest and cannot be null");
            }
            this.SignerLocationField = signerLocationField;
            // to ensure "signerMobileNumberField" is required (not null)
            if (signerMobileNumberField == null)
            {
                throw new ArgumentNullException("signerMobileNumberField is a required property for SigningCeremonyWithTokenRequest and cannot be null");
            }
            this.SignerMobileNumberField = signerMobileNumberField;
            // to ensure "signerReasonField" is required (not null)
            if (signerReasonField == null)
            {
                throw new ArgumentNullException("signerReasonField is a required property for SigningCeremonyWithTokenRequest and cannot be null");
            }
            this.SignerReasonField = signerReasonField;
            // to ensure "signerTrustOriginField" is required (not null)
            if (signerTrustOriginField == null)
            {
                throw new ArgumentNullException("signerTrustOriginField is a required property for SigningCeremonyWithTokenRequest and cannot be null");
            }
            this.SignerTrustOriginField = signerTrustOriginField;
            // to ensure "signerTrustReferenceField" is required (not null)
            if (signerTrustReferenceField == null)
            {
                throw new ArgumentNullException("signerTrustReferenceField is a required property for SigningCeremonyWithTokenRequest and cannot be null");
            }
            this.SignerTrustReferenceField = signerTrustReferenceField;
            // to ensure "tokenField" is required (not null)
            if (tokenField == null)
            {
                throw new ArgumentNullException("tokenField is a required property for SigningCeremonyWithTokenRequest and cannot be null");
            }
            this.TokenField = tokenField;
            this.SignerIdentificationNumberField = signerIdentificationNumberField;
        }

        /// <summary>
        /// Base64 encoded document or string content
        /// </summary>
        /// <value>Base64 encoded document or string content</value>
        [DataMember(Name = "DocField", IsRequired = true, EmitDefaultValue = true)]
        public string DocField { get; set; }

        /// <summary>
        /// Name of the document to be signed
        /// </summary>
        /// <value>Name of the document to be signed</value>
        [DataMember(Name = "DocNameField", IsRequired = true, EmitDefaultValue = true)]
        public string DocNameField { get; set; }

        /// <summary>
        /// Email of the signer
        /// </summary>
        /// <value>Email of the signer</value>
        [DataMember(Name = "SignerEmailField", IsRequired = true, EmitDefaultValue = true)]
        public string SignerEmailField { get; set; }

        /// <summary>
        /// Full name of the signer
        /// </summary>
        /// <value>Full name of the signer</value>
        [DataMember(Name = "SignerFullNameField", IsRequired = true, EmitDefaultValue = true)]
        public string SignerFullNameField { get; set; }

        /// <summary>
        /// Identification number of the signer
        /// </summary>
        /// <value>Identification number of the signer</value>
        [DataMember(Name = "SignerIdentificationNumberField", EmitDefaultValue = true)]
        public string SignerIdentificationNumberField { get; set; }

        /// <summary>
        /// value>Email Of the creator
        /// </summary>
        /// <value>Email Of the creator</value>
        [DataMember(Name = "UserNameField", EmitDefaultValue = true)]
        public string UserNameField { get; set; }

        /// <summary>
        /// Location of the signer
        /// </summary>
        /// <value>Location of the signer</value>
        [DataMember(Name = "SignerLocationField", IsRequired = true, EmitDefaultValue = true)]
        public string SignerLocationField { get; set; }

        /// <summary>
        /// Mobile number of the signer
        /// </summary>
        /// <value>Mobile number of the signer</value>
        [DataMember(Name = "SignerMobileNumberField", IsRequired = true, EmitDefaultValue = true)]
        public string SignerMobileNumberField { get; set; }

        /// <summary>
        /// Reason for the signer’s certification
        /// </summary>
        /// <value>Reason for the signer’s certification</value>
        [DataMember(Name = "SignerReasonField", IsRequired = true, EmitDefaultValue = true)]
        public string SignerReasonField { get; set; }

        /// <summary>
        /// The origin of trust for the signer
        /// </summary>
        /// <value>The origin of trust for the signer</value>
        [DataMember(Name = "SignerTrustOriginField", IsRequired = true, EmitDefaultValue = true)]
        public string SignerTrustOriginField { get; set; }

        /// <summary>
        /// Reference for the trust origin
        /// </summary>
        /// <value>Reference for the trust origin</value>
        [DataMember(Name = "SignerTrustReferenceField", IsRequired = true, EmitDefaultValue = true)]
        public string SignerTrustReferenceField { get; set; }

        /// <summary>
        /// Gets or Sets TokenField
        /// </summary>
        [DataMember(Name = "TokenField", IsRequired = true, EmitDefaultValue = true)]
        public TokenField TokenField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SigningCeremonyWithTokenRequest {\n");
            sb.Append("  DocField: ").Append(DocField).Append("\n");
            sb.Append("  DocNameField: ").Append(DocNameField).Append("\n");
            sb.Append("  UserNameField: ").Append(UserNameField).Append("\n");
            sb.Append("  SignerEmailField: ").Append(SignerEmailField).Append("\n");
            sb.Append("  SignerFullNameField: ").Append(SignerFullNameField).Append("\n");
            sb.Append("  SignerIdentificationNumberField: ").Append(SignerIdentificationNumberField).Append("\n");
            sb.Append("  SignerLocationField: ").Append(SignerLocationField).Append("\n");
            sb.Append("  SignerMobileNumberField: ").Append(SignerMobileNumberField).Append("\n");
            sb.Append("  SignerReasonField: ").Append(SignerReasonField).Append("\n");
            sb.Append("  SignerTrustOriginField: ").Append(SignerTrustOriginField).Append("\n");
            sb.Append("  SignerTrustReferenceField: ").Append(SignerTrustReferenceField).Append("\n");
            sb.Append("  TokenField: ").Append(TokenField).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}