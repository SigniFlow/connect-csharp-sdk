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
    /// #### The response returned when requesting the document tag field position.
    /// </summary>
    [DataContract(Name = "GetDocumentTagFieldPositionResponse")]
    public partial class GetDocumentTagFieldPositionResponse : IEquatable<GetDocumentTagFieldPositionResponse>, IValidatableObject
    {
//    
//    
//        /// <summary>
//        /// Initializes a new instance of the <see cref="GetDocumentTagFieldPositionResponse" /> class.
//        /// </summary>
//        [JsonConstructorAttribute]
//        
//        protected GetDocumentTagFieldPositionResponse() { }
//        
//        
//    
//    
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentTagFieldPositionResponse" /> class.
        /// </summary>
        /// <param name="documentTagFieldsPositionField">documentTagFieldsPositionField (required).</param>
        /// <param name="resultField">Displays the result of the call. (required).</param>
        public GetDocumentTagFieldPositionResponse(List<GetDocumentTagFieldPositionResponseDocumentTagFieldsPositionField> documentTagFieldsPositionField = default(List<GetDocumentTagFieldPositionResponseDocumentTagFieldsPositionField>), string resultField = default(string))
        {
            // to ensure "documentTagFieldsPositionField" is required (not null)
            this.DocumentTagFieldsPositionField = documentTagFieldsPositionField ?? throw new ArgumentNullException("documentTagFieldsPositionField is a required property for GetDocumentTagFieldPositionResponse and cannot be null");
            // to ensure "resultField" is required (not null)
            this.ResultField = resultField ?? throw new ArgumentNullException("resultField is a required property for GetDocumentTagFieldPositionResponse and cannot be null");
        }

        /// <summary>
        /// Gets or Sets DocumentTagFieldsPositionField
        /// </summary>
        [DataMember(Name = "DocumentTagFieldsPositionField", IsRequired = true, EmitDefaultValue = true)]
        public List<GetDocumentTagFieldPositionResponseDocumentTagFieldsPositionField> DocumentTagFieldsPositionField { get; set; }

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
            sb.Append("class GetDocumentTagFieldPositionResponse {\n");
            sb.Append("  DocumentTagFieldsPositionField: ").Append(DocumentTagFieldsPositionField).Append("\n");
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
            return this.Equals(input as GetDocumentTagFieldPositionResponse);
        }

        /// <summary>
        /// Returns true if GetDocumentTagFieldPositionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDocumentTagFieldPositionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocumentTagFieldPositionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentTagFieldsPositionField == input.DocumentTagFieldsPositionField ||
                    this.DocumentTagFieldsPositionField != null &&
                    input.DocumentTagFieldsPositionField != null &&
                    this.DocumentTagFieldsPositionField.SequenceEqual(input.DocumentTagFieldsPositionField)
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
                if (this.DocumentTagFieldsPositionField != null)
                    hashCode = hashCode * 59 + this.DocumentTagFieldsPositionField.GetHashCode();
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
            // ResultField (string) minLength
            if(this.ResultField != null && this.ResultField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResultField, length must be greater than 1.", new [] { "ResultField" });
            }

            yield break;
        }
    }

}
