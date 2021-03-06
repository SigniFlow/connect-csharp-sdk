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
    /// GetDocumentTagFieldBoxPositionResponseDocumentTagFieldsBoxPositionField
    /// </summary>
    [DataContract(Name = "GetDocumentTagFieldBoxPositionResponse_DocumentTagFieldsBoxPositionField")]
    public partial class GetDocumentTagFieldBoxPositionResponseDocumentTagFieldsBoxPositionField : IEquatable<GetDocumentTagFieldBoxPositionResponseDocumentTagFieldsBoxPositionField>, IValidatableObject
    {
//    
//    
//        /// <summary>
//        /// Initializes a new instance of the <see cref="GetDocumentTagFieldBoxPositionResponseDocumentTagFieldsBoxPositionField" /> class.
//        /// </summary>
//        [JsonConstructorAttribute]
//        
//        protected GetDocumentTagFieldBoxPositionResponseDocumentTagFieldsBoxPositionField() { }
//        
//        
//    
//    
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentTagFieldBoxPositionResponseDocumentTagFieldsBoxPositionField" /> class.
        /// </summary>
        /// <param name="heightField">The height of the field. (required).</param>
        /// <param name="pageNumberField">The page number where the field is. (required).</param>
        /// <param name="widthField">The width of the field. (required).</param>
        /// <param name="xCoordinateField">The x coordinates of the field. (required).</param>
        /// <param name="yCoordinateField">The y coordinates of the field (required).</param>
        public GetDocumentTagFieldBoxPositionResponseDocumentTagFieldsBoxPositionField(string heightField = default(string), decimal pageNumberField = default(decimal), string widthField = default(string), string xCoordinateField = default(string), string yCoordinateField = default(string))
        {
            // to ensure "heightField" is required (not null)
            this.HeightField = heightField ?? throw new ArgumentNullException("heightField is a required property for GetDocumentTagFieldBoxPositionResponseDocumentTagFieldsBoxPositionField and cannot be null");
            this.PageNumberField = pageNumberField;
            // to ensure "widthField" is required (not null)
            this.WidthField = widthField ?? throw new ArgumentNullException("widthField is a required property for GetDocumentTagFieldBoxPositionResponseDocumentTagFieldsBoxPositionField and cannot be null");
            // to ensure "xCoordinateField" is required (not null)
            this.XCoordinateField = xCoordinateField ?? throw new ArgumentNullException("xCoordinateField is a required property for GetDocumentTagFieldBoxPositionResponseDocumentTagFieldsBoxPositionField and cannot be null");
            // to ensure "yCoordinateField" is required (not null)
            this.YCoordinateField = yCoordinateField ?? throw new ArgumentNullException("yCoordinateField is a required property for GetDocumentTagFieldBoxPositionResponseDocumentTagFieldsBoxPositionField and cannot be null");
        }

        /// <summary>
        /// The height of the field.
        /// </summary>
        /// <value>The height of the field.</value>
        [DataMember(Name = "HeightField", IsRequired = true, EmitDefaultValue = true)]
        public string HeightField { get; set; }

        /// <summary>
        /// The page number where the field is.
        /// </summary>
        /// <value>The page number where the field is.</value>
        [DataMember(Name = "PageNumberField", IsRequired = true, EmitDefaultValue = true)]
        public decimal PageNumberField { get; set; }

        /// <summary>
        /// The width of the field.
        /// </summary>
        /// <value>The width of the field.</value>
        [DataMember(Name = "WidthField", IsRequired = true, EmitDefaultValue = true)]
        public string WidthField { get; set; }

        /// <summary>
        /// The x coordinates of the field.
        /// </summary>
        /// <value>The x coordinates of the field.</value>
        [DataMember(Name = "XCoordinateField", IsRequired = true, EmitDefaultValue = true)]
        public string XCoordinateField { get; set; }

        /// <summary>
        /// The y coordinates of the field
        /// </summary>
        /// <value>The y coordinates of the field</value>
        [DataMember(Name = "YCoordinateField", IsRequired = true, EmitDefaultValue = true)]
        public string YCoordinateField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDocumentTagFieldBoxPositionResponseDocumentTagFieldsBoxPositionField {\n");
            sb.Append("  HeightField: ").Append(HeightField).Append("\n");
            sb.Append("  PageNumberField: ").Append(PageNumberField).Append("\n");
            sb.Append("  WidthField: ").Append(WidthField).Append("\n");
            sb.Append("  XCoordinateField: ").Append(XCoordinateField).Append("\n");
            sb.Append("  YCoordinateField: ").Append(YCoordinateField).Append("\n");
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
            return this.Equals(input as GetDocumentTagFieldBoxPositionResponseDocumentTagFieldsBoxPositionField);
        }

        /// <summary>
        /// Returns true if GetDocumentTagFieldBoxPositionResponseDocumentTagFieldsBoxPositionField instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDocumentTagFieldBoxPositionResponseDocumentTagFieldsBoxPositionField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocumentTagFieldBoxPositionResponseDocumentTagFieldsBoxPositionField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HeightField == input.HeightField ||
                    (this.HeightField != null &&
                    this.HeightField.Equals(input.HeightField))
                ) && 
                (
                    this.PageNumberField == input.PageNumberField ||
                    this.PageNumberField.Equals(input.PageNumberField)
                ) && 
                (
                    this.WidthField == input.WidthField ||
                    (this.WidthField != null &&
                    this.WidthField.Equals(input.WidthField))
                ) && 
                (
                    this.XCoordinateField == input.XCoordinateField ||
                    (this.XCoordinateField != null &&
                    this.XCoordinateField.Equals(input.XCoordinateField))
                ) && 
                (
                    this.YCoordinateField == input.YCoordinateField ||
                    (this.YCoordinateField != null &&
                    this.YCoordinateField.Equals(input.YCoordinateField))
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
                if (this.HeightField != null)
                    hashCode = hashCode * 59 + this.HeightField.GetHashCode();
                hashCode = hashCode * 59 + this.PageNumberField.GetHashCode();
                if (this.WidthField != null)
                    hashCode = hashCode * 59 + this.WidthField.GetHashCode();
                if (this.XCoordinateField != null)
                    hashCode = hashCode * 59 + this.XCoordinateField.GetHashCode();
                if (this.YCoordinateField != null)
                    hashCode = hashCode * 59 + this.YCoordinateField.GetHashCode();
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
            // HeightField (string) minLength
            if(this.HeightField != null && this.HeightField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HeightField, length must be greater than 1.", new [] { "HeightField" });
            }

            // WidthField (string) minLength
            if(this.WidthField != null && this.WidthField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WidthField, length must be greater than 1.", new [] { "WidthField" });
            }

            // XCoordinateField (string) minLength
            if(this.XCoordinateField != null && this.XCoordinateField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for XCoordinateField, length must be greater than 1.", new [] { "XCoordinateField" });
            }

            // YCoordinateField (string) minLength
            if(this.YCoordinateField != null && this.YCoordinateField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for YCoordinateField, length must be greater than 1.", new [] { "YCoordinateField" });
            }

            yield break;
        }
    }

}
