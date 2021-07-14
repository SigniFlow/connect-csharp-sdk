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
    /// #### The response returned when requesting and audit document.
    /// </summary>
    [DataContract(Name = "GetAuditDocumentResponse")]
    public partial class GetAuditDocumentResponse : IEquatable<GetAuditDocumentResponse>, IValidatableObject
    {
//    
//    
//        /// <summary>
//        /// Initializes a new instance of the <see cref="GetAuditDocumentResponse" /> class.
//        /// </summary>
//        [JsonConstructorAttribute]
//        
//        protected GetAuditDocumentResponse() { }
//        
//        
//    
//    
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuditDocumentResponse" /> class.
        /// </summary>
        /// <param name="auditDocumentField">auditDocumentField (required).</param>
        /// <param name="resultField">Displays the result of the call. (required).</param>
        public GetAuditDocumentResponse(string auditDocumentField = default(string), string resultField = default(string))
        {
            // to ensure "auditDocumentField" is required (not null)
            this.AuditDocumentField = auditDocumentField ?? throw new ArgumentNullException("auditDocumentField is a required property for GetAuditDocumentResponse and cannot be null");
            // to ensure "resultField" is required (not null)
            this.ResultField = resultField ?? throw new ArgumentNullException("resultField is a required property for GetAuditDocumentResponse and cannot be null");
        }

        /// <summary>
        /// Gets or Sets AuditDocumentField
        /// </summary>
        [DataMember(Name = "AuditDocumentField", IsRequired = true, EmitDefaultValue = true)]
        public string AuditDocumentField { get; set; }

        /// <summary>
        /// Displays the result of the call.
        /// </summary>
        /// <value>Displays the result of the call.</value>
        [DataMember(Name = "ResultField", IsRequired = true, EmitDefaultValue = true)]
        public string ResultField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAuditDocumentResponse {\n");
            sb.Append("  AuditDocumentField: ").Append(AuditDocumentField).Append("\n");
            sb.Append("  ResultField: ").Append(ResultField).Append("\n");
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
            return this.Equals(input as GetAuditDocumentResponse);
        }

        /// <summary>
        /// Returns true if GetAuditDocumentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAuditDocumentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAuditDocumentResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuditDocumentField == input.AuditDocumentField ||
                    (this.AuditDocumentField != null &&
                    this.AuditDocumentField.Equals(input.AuditDocumentField))
                ) && 
                (
                    this.ResultField == input.ResultField ||
                    (this.ResultField != null &&
                    this.ResultField.Equals(input.ResultField))
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
                if (this.AuditDocumentField != null)
                    hashCode = hashCode * 59 + this.AuditDocumentField.GetHashCode();
                if (this.ResultField != null)
                    hashCode = hashCode * 59 + this.ResultField.GetHashCode();
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
            // AuditDocumentField (string) minLength
            if(this.AuditDocumentField != null && this.AuditDocumentField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AuditDocumentField, length must be greater than 1.", new [] { "AuditDocumentField" });
            }

            // ResultField (string) minLength
            if(this.ResultField != null && this.ResultField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResultField, length must be greater than 1.", new [] { "ResultField" });
            }

            yield break;
        }
    }

}
