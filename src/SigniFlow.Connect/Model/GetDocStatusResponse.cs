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
    /// #### This is the response returned when a document status has been requested.
    /// </summary>
    [DataContract(Name = "GetDocStatusResponse")]
    public partial class GetDocStatusResponse : IEquatable<GetDocStatusResponse>, IValidatableObject
    {
//    
//    
//        /// <summary>
//        /// Initializes a new instance of the <see cref="GetDocStatusResponse" /> class.
//        /// </summary>
//        [JsonConstructorAttribute]
//        
//        protected GetDocStatusResponse() { }
//        
//        
//    
//    
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocStatusResponse" /> class.
        /// </summary>
        /// <param name="docStatusField">Status of the document. (required).</param>
        /// <param name="resultField">Displays the result of the call. (required).</param>
        public GetDocStatusResponse(string docStatusField = default(string), string resultField = default(string))
        {
            // to ensure "docStatusField" is required (not null)
            this.DocStatusField = docStatusField ?? throw new ArgumentNullException("docStatusField is a required property for GetDocStatusResponse and cannot be null");
            // to ensure "resultField" is required (not null)
            this.ResultField = resultField ?? throw new ArgumentNullException("resultField is a required property for GetDocStatusResponse and cannot be null");
        }

        /// <summary>
        /// Status of the document.
        /// </summary>
        /// <value>Status of the document.</value>
        [DataMember(Name = "DocStatusField", IsRequired = true, EmitDefaultValue = false)]
        public string DocStatusField { get; set; }

        /// <summary>
        /// Displays the result of the call.
        /// </summary>
        /// <value>Displays the result of the call.</value>
        [DataMember(Name = "ResultField", IsRequired = true, EmitDefaultValue = false)]
        public string ResultField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDocStatusResponse {\n");
            sb.Append("  DocStatusField: ").Append(DocStatusField).Append("\n");
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
            return this.Equals(input as GetDocStatusResponse);
        }

        /// <summary>
        /// Returns true if GetDocStatusResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDocStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocStatusResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocStatusField == input.DocStatusField ||
                    (this.DocStatusField != null &&
                    this.DocStatusField.Equals(input.DocStatusField))
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
                if (this.DocStatusField != null)
                    hashCode = hashCode * 59 + this.DocStatusField.GetHashCode();
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
            // DocStatusField (string) minLength
            if(this.DocStatusField != null && this.DocStatusField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DocStatusField, length must be greater than 1.", new [] { "DocStatusField" });
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
