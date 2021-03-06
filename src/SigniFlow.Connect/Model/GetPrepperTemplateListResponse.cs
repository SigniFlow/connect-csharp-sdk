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
    /// #### The response returned when the document template list gets requested.
    /// </summary>
    [DataContract(Name = "GetPrepperTemplateListResponse")]
    public partial class GetPrepperTemplateListResponse : IEquatable<GetPrepperTemplateListResponse>, IValidatableObject
    {
//    
//    
//        /// <summary>
//        /// Initializes a new instance of the <see cref="GetPrepperTemplateListResponse" /> class.
//        /// </summary>
//        [JsonConstructorAttribute]
//        
//        protected GetPrepperTemplateListResponse() { }
//        
//        
//    
//    
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPrepperTemplateListResponse" /> class.
        /// </summary>
        /// <param name="resultField">Displays the result of the call. (required).</param>
        /// <param name="templateInformationValuesField">templateInformationValuesField (required).</param>
        public GetPrepperTemplateListResponse(string resultField = default(string), List<GetPrepperTemplateListResponseTemplateInformationValuesField> templateInformationValuesField = default(List<GetPrepperTemplateListResponseTemplateInformationValuesField>))
        {
            // to ensure "resultField" is required (not null)
            this.ResultField = resultField ?? throw new ArgumentNullException("resultField is a required property for GetPrepperTemplateListResponse and cannot be null");
            // to ensure "templateInformationValuesField" is required (not null)
            this.TemplateInformationValuesField = templateInformationValuesField ?? throw new ArgumentNullException("templateInformationValuesField is a required property for GetPrepperTemplateListResponse and cannot be null");
        }

        /// <summary>
        /// Displays the result of the call.
        /// </summary>
        /// <value>Displays the result of the call.</value>
        [DataMember(Name = "ResultField", IsRequired = true, EmitDefaultValue = true)]
        public string ResultField { get; set; }

        /// <summary>
        /// Gets or Sets TemplateInformationValuesField
        /// </summary>
        [DataMember(Name = "TemplateInformationValuesField", IsRequired = true, EmitDefaultValue = true)]
        public List<GetPrepperTemplateListResponseTemplateInformationValuesField> TemplateInformationValuesField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetPrepperTemplateListResponse {\n");
            sb.Append("  ResultField: ").Append(ResultField).Append("\n");
            sb.Append("  TemplateInformationValuesField: ").Append(TemplateInformationValuesField).Append("\n");
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
            return this.Equals(input as GetPrepperTemplateListResponse);
        }

        /// <summary>
        /// Returns true if GetPrepperTemplateListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPrepperTemplateListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPrepperTemplateListResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResultField == input.ResultField ||
                    (this.ResultField != null &&
                    this.ResultField.Equals(input.ResultField))
                ) && 
                (
                    this.TemplateInformationValuesField == input.TemplateInformationValuesField ||
                    this.TemplateInformationValuesField != null &&
                    input.TemplateInformationValuesField != null &&
                    this.TemplateInformationValuesField.SequenceEqual(input.TemplateInformationValuesField)
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
                if (this.ResultField != null)
                    hashCode = hashCode * 59 + this.ResultField.GetHashCode();
                if (this.TemplateInformationValuesField != null)
                    hashCode = hashCode * 59 + this.TemplateInformationValuesField.GetHashCode();
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
