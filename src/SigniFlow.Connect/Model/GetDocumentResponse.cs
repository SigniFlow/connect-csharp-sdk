/*
 * WorkFlow API
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
    /// #### The response returned when a user wants to download a document.
    /// </summary>
    [DataContract(Name = "GetDocumentResponse")]
    public partial class GetDocumentResponse : IEquatable<GetDocumentResponse>, IValidatableObject
    {
//    
//    
//        /// <summary>
//        /// Initializes a new instance of the <see cref="GetDocumentResponse" /> class.
//        /// </summary>
//        [JsonConstructorAttribute]
//        
//        protected GetDocumentResponse() { }
//        
//        
//    
//    
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentResponse" /> class.
        /// </summary>
        /// <param name="docField">Returns a base64 string as the document. (required).</param>
        /// <param name="docNameField">Document field name. (required).</param>
        /// <param name="extensionField">Document extension field. (required).</param>
        /// <param name="resultField">Displays the result of the call. (required).</param>
        public GetDocumentResponse(string docField = default(string), string docNameField = default(string), string extensionField = default(string), string resultField = default(string))
        {
            // to ensure "docField" is required (not null)
            this.DocField = docField ?? throw new ArgumentNullException("docField is a required property for GetDocumentResponse and cannot be null");
            // to ensure "docNameField" is required (not null)
            this.DocNameField = docNameField ?? throw new ArgumentNullException("docNameField is a required property for GetDocumentResponse and cannot be null");
            // to ensure "extensionField" is required (not null)
            this.ExtensionField = extensionField ?? throw new ArgumentNullException("extensionField is a required property for GetDocumentResponse and cannot be null");
            // to ensure "resultField" is required (not null)
            this.ResultField = resultField ?? throw new ArgumentNullException("resultField is a required property for GetDocumentResponse and cannot be null");
        }

        /// <summary>
        /// Returns a base64 string as the document.
        /// </summary>
        /// <value>Returns a base64 string as the document.</value>
        [DataMember(Name = "DocField", IsRequired = true, EmitDefaultValue = true)]
        public string DocField { get; set; }

        /// <summary>
        /// Document field name.
        /// </summary>
        /// <value>Document field name.</value>
        [DataMember(Name = "DocNameField", IsRequired = true, EmitDefaultValue = true)]
        public string DocNameField { get; set; }

        /// <summary>
        /// Document extension field.
        /// </summary>
        /// <value>Document extension field.</value>
        [DataMember(Name = "ExtensionField", IsRequired = true, EmitDefaultValue = true)]
        public string ExtensionField { get; set; }

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
            sb.Append("class GetDocumentResponse {\n");
            sb.Append("  DocField: ").Append(DocField).Append("\n");
            sb.Append("  DocNameField: ").Append(DocNameField).Append("\n");
            sb.Append("  ExtensionField: ").Append(ExtensionField).Append("\n");
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
            return this.Equals(input as GetDocumentResponse);
        }

        /// <summary>
        /// Returns true if GetDocumentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDocumentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocumentResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocField == input.DocField ||
                    (this.DocField != null &&
                    this.DocField.Equals(input.DocField))
                ) && 
                (
                    this.DocNameField == input.DocNameField ||
                    (this.DocNameField != null &&
                    this.DocNameField.Equals(input.DocNameField))
                ) && 
                (
                    this.ExtensionField == input.ExtensionField ||
                    (this.ExtensionField != null &&
                    this.ExtensionField.Equals(input.ExtensionField))
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
                if (this.DocField != null)
                    hashCode = hashCode * 59 + this.DocField.GetHashCode();
                if (this.DocNameField != null)
                    hashCode = hashCode * 59 + this.DocNameField.GetHashCode();
                if (this.ExtensionField != null)
                    hashCode = hashCode * 59 + this.ExtensionField.GetHashCode();
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
            // DocField (string) minLength
            if(this.DocField != null && this.DocField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DocField, length must be greater than 1.", new [] { "DocField" });
            }

            // DocNameField (string) minLength
            if(this.DocNameField != null && this.DocNameField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DocNameField, length must be greater than 1.", new [] { "DocNameField" });
            }

            // ExtensionField (string) minLength
            if(this.ExtensionField != null && this.ExtensionField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtensionField, length must be greater than 1.", new [] { "ExtensionField" });
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
