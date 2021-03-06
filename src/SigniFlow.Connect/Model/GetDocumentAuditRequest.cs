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
    /// #### The request sent to get the audit information from a document.
    /// </summary>
    [DataContract(Name = "GetDocumentAuditRequest")]
    public partial class GetDocumentAuditRequest : IEquatable<GetDocumentAuditRequest>, IValidatableObject
    {
//    
//    
//        /// <summary>
//        /// Initializes a new instance of the <see cref="GetDocumentAuditRequest" /> class.
//        /// </summary>
//        [JsonConstructorAttribute]
//        
//        protected GetDocumentAuditRequest() { }
//        
//        
//    
//    
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentAuditRequest" /> class.
        /// </summary>
        /// <param name="docIDField">docIDField (required).</param>
        /// <param name="tokenField">tokenField (required).</param>
        public GetDocumentAuditRequest(string docIDField = default(string), TokenField tokenField = default(TokenField))
        {
            // to ensure "docIDField" is required (not null)
            this.DocIDField = docIDField ?? throw new ArgumentNullException("docIDField is a required property for GetDocumentAuditRequest and cannot be null");
            // to ensure "tokenField" is required (not null)
            this.TokenField = tokenField ?? throw new ArgumentNullException("tokenField is a required property for GetDocumentAuditRequest and cannot be null");
        }

        /// <summary>
        /// Gets or Sets DocIDField
        /// </summary>
        [DataMember(Name = "DocIDField", IsRequired = true, EmitDefaultValue = true)]
        public string DocIDField { get; set; }

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
            var sb = new StringBuilder();
            sb.Append("class GetDocumentAuditRequest {\n");
            sb.Append("  DocIDField: ").Append(DocIDField).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetDocumentAuditRequest);
        }

        /// <summary>
        /// Returns true if GetDocumentAuditRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDocumentAuditRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocumentAuditRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocIDField == input.DocIDField ||
                    (this.DocIDField != null &&
                    this.DocIDField.Equals(input.DocIDField))
                ) && 
                (
                    this.TokenField == input.TokenField ||
                    (this.TokenField != null &&
                    this.TokenField.Equals(input.TokenField))
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
                if (this.DocIDField != null)
                    hashCode = hashCode * 59 + this.DocIDField.GetHashCode();
                if (this.TokenField != null)
                    hashCode = hashCode * 59 + this.TokenField.GetHashCode();
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
            // DocIDField (string) minLength
            if(this.DocIDField != null && this.DocIDField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DocIDField, length must be greater than 1.", new [] { "DocIDField" });
            }

            yield break;
        }
    }

}
