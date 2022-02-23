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
    /// #### The response retuenrd when fields are added to a document using a FlowID.
    /// </summary>
    [DataContract(Name = "DocPrepperAddFieldsFlowIDResponse")]
    public partial class DocPrepperAddFieldsFlowIDResponse : IEquatable<DocPrepperAddFieldsFlowIDResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets FieldTypeField
        /// </summary>
        [DataMember(Name = "FieldTypeField", IsRequired = true, EmitDefaultValue = true)]
        public FieldType FieldTypeField { get; set; }
//    
//    
//        /// <summary>
//        /// Initializes a new instance of the <see cref="DocPrepperAddFieldsFlowIDResponse" /> class.
//        /// </summary>
//        [JsonConstructorAttribute]
//        
//        protected DocPrepperAddFieldsFlowIDResponse() { }
//        
//        
//    
//    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocPrepperAddFieldsFlowIDResponse" /> class.
        /// </summary>
        /// <param name="docIDField">Document ID. (required).</param>
        /// <param name="fieldTypeField">fieldTypeField (required).</param>
        /// <param name="heightField">The height of the field. (required).</param>
        /// <param name="pageNumberField">Field page number. (required).</param>
        /// <param name="prepperFieldIDField">Document prepper field ID. (required).</param>
        /// <param name="resultField">Displays the result of the call. (required).</param>
        /// <param name="userIDField">SigniFlow User ID (required).</param>
        /// <param name="widthField">The width of the field. (required).</param>
        /// <param name="xCoordinateField">X-coordinates of the field. (required).</param>
        /// <param name="yCoordinateField">Y-coordinates of the field. (required).</param>
        public DocPrepperAddFieldsFlowIDResponse(decimal docIDField = default(decimal), FieldType fieldTypeField = default(FieldType), string heightField = default(string), decimal pageNumberField = default(decimal), decimal prepperFieldIDField = default(decimal), string resultField = default(string), decimal userIDField = default(decimal), string widthField = default(string), string xCoordinateField = default(string), string yCoordinateField = default(string))
        {
            this.DocIDField = docIDField;
            this.FieldTypeField = fieldTypeField;
            // to ensure "heightField" is required (not null)
            this.HeightField = heightField ?? throw new ArgumentNullException("heightField is a required property for DocPrepperAddFieldsFlowIDResponse and cannot be null");
            this.PageNumberField = pageNumberField;
            this.PrepperFieldIDField = prepperFieldIDField;
            // to ensure "resultField" is required (not null)
            this.ResultField = resultField ?? throw new ArgumentNullException("resultField is a required property for DocPrepperAddFieldsFlowIDResponse and cannot be null");
            this.UserIDField = userIDField;
            // to ensure "widthField" is required (not null)
            this.WidthField = widthField ?? throw new ArgumentNullException("widthField is a required property for DocPrepperAddFieldsFlowIDResponse and cannot be null");
            // to ensure "xCoordinateField" is required (not null)
            this.XCoordinateField = xCoordinateField ?? throw new ArgumentNullException("xCoordinateField is a required property for DocPrepperAddFieldsFlowIDResponse and cannot be null");
            // to ensure "yCoordinateField" is required (not null)
            this.YCoordinateField = yCoordinateField ?? throw new ArgumentNullException("yCoordinateField is a required property for DocPrepperAddFieldsFlowIDResponse and cannot be null");
        }

        /// <summary>
        /// Document ID.
        /// </summary>
        /// <value>Document ID.</value>
        [DataMember(Name = "DocIDField", IsRequired = true, EmitDefaultValue = true)]
        public decimal DocIDField { get; set; }

        /// <summary>
        /// The height of the field.
        /// </summary>
        /// <value>The height of the field.</value>
        [DataMember(Name = "HeightField", IsRequired = true, EmitDefaultValue = true)]
        public string HeightField { get; set; }

        /// <summary>
        /// Field page number.
        /// </summary>
        /// <value>Field page number.</value>
        [DataMember(Name = "PageNumberField", IsRequired = true, EmitDefaultValue = true)]
        public decimal PageNumberField { get; set; }

        /// <summary>
        /// Document prepper field ID.
        /// </summary>
        /// <value>Document prepper field ID.</value>
        [DataMember(Name = "PrepperFieldIDField", IsRequired = true, EmitDefaultValue = true)]
        public decimal PrepperFieldIDField { get; set; }

        /// <summary>
        /// Displays the result of the call.
        /// </summary>
        /// <value>Displays the result of the call.</value>
        [DataMember(Name = "ResultField", IsRequired = true, EmitDefaultValue = true)]
        public string ResultField { get; set; }

        /// <summary>
        /// SigniFlow User ID
        /// </summary>
        /// <value>SigniFlow User ID</value>
        [DataMember(Name = "UserIDField", IsRequired = true, EmitDefaultValue = true)]
        public decimal UserIDField { get; set; }

        /// <summary>
        /// The width of the field.
        /// </summary>
        /// <value>The width of the field.</value>
        [DataMember(Name = "WidthField", IsRequired = true, EmitDefaultValue = true)]
        public string WidthField { get; set; }

        /// <summary>
        /// X-coordinates of the field.
        /// </summary>
        /// <value>X-coordinates of the field.</value>
        [DataMember(Name = "XCoordinateField", IsRequired = true, EmitDefaultValue = true)]
        public string XCoordinateField { get; set; }

        /// <summary>
        /// Y-coordinates of the field.
        /// </summary>
        /// <value>Y-coordinates of the field.</value>
        [DataMember(Name = "YCoordinateField", IsRequired = true, EmitDefaultValue = true)]
        public string YCoordinateField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocPrepperAddFieldsFlowIDResponse {\n");
            sb.Append("  DocIDField: ").Append(DocIDField).Append("\n");
            sb.Append("  FieldTypeField: ").Append(FieldTypeField).Append("\n");
            sb.Append("  HeightField: ").Append(HeightField).Append("\n");
            sb.Append("  PageNumberField: ").Append(PageNumberField).Append("\n");
            sb.Append("  PrepperFieldIDField: ").Append(PrepperFieldIDField).Append("\n");
            sb.Append("  ResultField: ").Append(ResultField).Append("\n");
            sb.Append("  UserIDField: ").Append(UserIDField).Append("\n");
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
            return this.Equals(input as DocPrepperAddFieldsFlowIDResponse);
        }

        /// <summary>
        /// Returns true if DocPrepperAddFieldsFlowIDResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DocPrepperAddFieldsFlowIDResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocPrepperAddFieldsFlowIDResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocIDField == input.DocIDField ||
                    this.DocIDField.Equals(input.DocIDField)
                ) && 
                (
                    this.FieldTypeField == input.FieldTypeField ||
                    this.FieldTypeField.Equals(input.FieldTypeField)
                ) && 
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
                    this.PrepperFieldIDField == input.PrepperFieldIDField ||
                    this.PrepperFieldIDField.Equals(input.PrepperFieldIDField)
                ) && 
                (
                    this.ResultField == input.ResultField ||
                    (this.ResultField != null &&
                    this.ResultField.Equals(input.ResultField))
                ) && 
                (
                    this.UserIDField == input.UserIDField ||
                    this.UserIDField.Equals(input.UserIDField)
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
                hashCode = hashCode * 59 + this.DocIDField.GetHashCode();
                hashCode = hashCode * 59 + this.FieldTypeField.GetHashCode();
                if (this.HeightField != null)
                    hashCode = hashCode * 59 + this.HeightField.GetHashCode();
                hashCode = hashCode * 59 + this.PageNumberField.GetHashCode();
                hashCode = hashCode * 59 + this.PrepperFieldIDField.GetHashCode();
                if (this.ResultField != null)
                    hashCode = hashCode * 59 + this.ResultField.GetHashCode();
                hashCode = hashCode * 59 + this.UserIDField.GetHashCode();
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

            // ResultField (string) minLength
            if(this.ResultField != null && this.ResultField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResultField, length must be greater than 1.", new [] { "ResultField" });
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
