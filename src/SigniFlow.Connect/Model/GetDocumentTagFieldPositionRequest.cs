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
    /// #### The request sent to get the document tag field position.
    /// </summary>
    [DataContract(Name = "GetDocumentTagFieldPositionRequest")]
    public partial class GetDocumentTagFieldPositionRequest : IEquatable<GetDocumentTagFieldPositionRequest>, IValidatableObject
    {
//    
//    
//        /// <summary>
//        /// Initializes a new instance of the <see cref="GetDocumentTagFieldPositionRequest" /> class.
//        /// </summary>
//        [JsonConstructorAttribute]
//        
//        protected GetDocumentTagFieldPositionRequest() { }
//        
//        
//    
//    
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentTagFieldPositionRequest" /> class.
        /// </summary>
        /// <param name="docIDField">Document ID (required).</param>
        /// <param name="tagNameField">The white text on the document that the API needs to identify. (required).</param>
        /// <param name="tokenField">tokenField (required).</param>
        public GetDocumentTagFieldPositionRequest(decimal docIDField = default(decimal), string tagNameField = default(string), TokenField tokenField = default(TokenField))
        {
            this.DocIDField = docIDField;
            // to ensure "tagNameField" is required (not null)
            this.TagNameField = tagNameField ?? throw new ArgumentNullException("tagNameField is a required property for GetDocumentTagFieldPositionRequest and cannot be null");
            // to ensure "tokenField" is required (not null)
            this.TokenField = tokenField ?? throw new ArgumentNullException("tokenField is a required property for GetDocumentTagFieldPositionRequest and cannot be null");
        }

        /// <summary>
        /// Document ID
        /// </summary>
        /// <value>Document ID</value>
        [DataMember(Name = "DocIDField", IsRequired = true, EmitDefaultValue = true)]
        public decimal DocIDField { get; set; }

        /// <summary>
        /// The white text on the document that the API needs to identify.
        /// </summary>
        /// <value>The white text on the document that the API needs to identify.</value>
        [DataMember(Name = "TagNameField", IsRequired = true, EmitDefaultValue = true)]
        public string TagNameField { get; set; }

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
            sb.Append("class GetDocumentTagFieldPositionRequest {\n");
            sb.Append("  DocIDField: ").Append(DocIDField).Append("\n");
            sb.Append("  TagNameField: ").Append(TagNameField).Append("\n");
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
            return this.Equals(input as GetDocumentTagFieldPositionRequest);
        }

        /// <summary>
        /// Returns true if GetDocumentTagFieldPositionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDocumentTagFieldPositionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocumentTagFieldPositionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocIDField == input.DocIDField ||
                    this.DocIDField.Equals(input.DocIDField)
                ) && 
                (
                    this.TagNameField == input.TagNameField ||
                    (this.TagNameField != null &&
                    this.TagNameField.Equals(input.TagNameField))
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
                hashCode = hashCode * 59 + this.DocIDField.GetHashCode();
                if (this.TagNameField != null)
                    hashCode = hashCode * 59 + this.TagNameField.GetHashCode();
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
            // TagNameField (string) minLength
            if(this.TagNameField != null && this.TagNameField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TagNameField, length must be greater than 1.", new [] { "TagNameField" });
            }

            yield break;
        }
    }

}
