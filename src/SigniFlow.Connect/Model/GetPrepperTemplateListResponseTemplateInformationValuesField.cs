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
    /// GetPrepperTemplateListResponseTemplateInformationValuesField
    /// </summary>
    [DataContract(Name = "GetPrepperTemplateListResponse_TemplateInformationValuesField")]
    public partial class GetPrepperTemplateListResponseTemplateInformationValuesField : IEquatable<GetPrepperTemplateListResponseTemplateInformationValuesField>, IValidatableObject
    {
//    
//    
//        /// <summary>
//        /// Initializes a new instance of the <see cref="GetPrepperTemplateListResponseTemplateInformationValuesField" /> class.
//        /// </summary>
//        [JsonConstructorAttribute]
//        
//        protected GetPrepperTemplateListResponseTemplateInformationValuesField() { }
//        
//        
//    
//    
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPrepperTemplateListResponseTemplateInformationValuesField" /> class.
        /// </summary>
        /// <param name="nameField">nameField (required).</param>
        /// <param name="prepperTemplateIDField">prepperTemplateIDField (required).</param>
        /// <param name="templateDescriptionField">Template description. (required).</param>
        public GetPrepperTemplateListResponseTemplateInformationValuesField(string nameField = default(string), decimal prepperTemplateIDField = default(decimal), string templateDescriptionField = default(string))
        {
            // to ensure "nameField" is required (not null)
            this.NameField = nameField ?? throw new ArgumentNullException("nameField is a required property for GetPrepperTemplateListResponseTemplateInformationValuesField and cannot be null");
            this.PrepperTemplateIDField = prepperTemplateIDField;
            // to ensure "templateDescriptionField" is required (not null)
            this.TemplateDescriptionField = templateDescriptionField ?? throw new ArgumentNullException("templateDescriptionField is a required property for GetPrepperTemplateListResponseTemplateInformationValuesField and cannot be null");
        }

        /// <summary>
        /// Gets or Sets NameField
        /// </summary>
        [DataMember(Name = "NameField", IsRequired = true, EmitDefaultValue = true)]
        public string NameField { get; set; }

        /// <summary>
        /// Gets or Sets PrepperTemplateIDField
        /// </summary>
        [DataMember(Name = "PrepperTemplateIDField", IsRequired = true, EmitDefaultValue = true)]
        public decimal PrepperTemplateIDField { get; set; }

        /// <summary>
        /// Template description.
        /// </summary>
        /// <value>Template description.</value>
        [DataMember(Name = "TemplateDescriptionField", IsRequired = true, EmitDefaultValue = true)]
        public string TemplateDescriptionField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetPrepperTemplateListResponseTemplateInformationValuesField {\n");
            sb.Append("  NameField: ").Append(NameField).Append("\n");
            sb.Append("  PrepperTemplateIDField: ").Append(PrepperTemplateIDField).Append("\n");
            sb.Append("  TemplateDescriptionField: ").Append(TemplateDescriptionField).Append("\n");
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
            return this.Equals(input as GetPrepperTemplateListResponseTemplateInformationValuesField);
        }

        /// <summary>
        /// Returns true if GetPrepperTemplateListResponseTemplateInformationValuesField instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPrepperTemplateListResponseTemplateInformationValuesField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPrepperTemplateListResponseTemplateInformationValuesField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NameField == input.NameField ||
                    (this.NameField != null &&
                    this.NameField.Equals(input.NameField))
                ) && 
                (
                    this.PrepperTemplateIDField == input.PrepperTemplateIDField ||
                    this.PrepperTemplateIDField.Equals(input.PrepperTemplateIDField)
                ) && 
                (
                    this.TemplateDescriptionField == input.TemplateDescriptionField ||
                    (this.TemplateDescriptionField != null &&
                    this.TemplateDescriptionField.Equals(input.TemplateDescriptionField))
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
                if (this.NameField != null)
                    hashCode = hashCode * 59 + this.NameField.GetHashCode();
                hashCode = hashCode * 59 + this.PrepperTemplateIDField.GetHashCode();
                if (this.TemplateDescriptionField != null)
                    hashCode = hashCode * 59 + this.TemplateDescriptionField.GetHashCode();
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
            // NameField (string) minLength
            if(this.NameField != null && this.NameField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NameField, length must be greater than 1.", new [] { "NameField" });
            }

            // TemplateDescriptionField (string) minLength
            if(this.TemplateDescriptionField != null && this.TemplateDescriptionField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TemplateDescriptionField, length must be greater than 1.", new [] { "TemplateDescriptionField" });
            }

            yield break;
        }
    }

}
