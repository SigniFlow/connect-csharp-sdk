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
    /// FullWorkflowRequestWorkflowUserFieldsField
    /// </summary>
    [DataContract(Name = "FullWorkflowRequest_WorkflowUserFieldsField")]
    public partial class FullWorkflowRequestWorkflowUserFieldsField : IEquatable<FullWorkflowRequestWorkflowUserFieldsField>, IValidatableObject
    {
//    
//    
//        /// <summary>
//        /// Initializes a new instance of the <see cref="FullWorkflowRequestWorkflowUserFieldsField" /> class.
//        /// </summary>
//        [JsonConstructorAttribute]
//        
//        protected FullWorkflowRequestWorkflowUserFieldsField() { }
//        
//        
//    
//    
        /// <summary>
        /// Initializes a new instance of the <see cref="FullWorkflowRequestWorkflowUserFieldsField" /> class.
        /// </summary>
        /// <param name="fieldTypeField">Field type. (required).</param>
        /// <param name="fontFamilyField">The font family of the fields text. (required).</param>
        /// <param name="fontSizeField">The font size of the fields text. (required).</param>
        /// <param name="groupUserNumberField">The users in the group&#39;s user number. (required).</param>
        /// <param name="heightField">Field height. (required).</param>
        /// <param name="isInvisibleField">Is the field visible. (required).</param>
        /// <param name="pageNumberField">Field page number. (required).</param>
        /// <param name="tagNameField">Field tag name. (required).</param>
        /// <param name="valueField">Field value. (required).</param>
        /// <param name="widthField">Field width. (required).</param>
        /// <param name="xCoordinateField">The fields x-coordinates. (required).</param>
        /// <param name="xOffsetField">The fields x-coordinates offset. (required).</param>
        /// <param name="yCoordinateField">The fields y-coordinates. (required).</param>
        /// <param name="yOffsetField">The fields y-coordinates offset. (required).</param>
        public FullWorkflowRequestWorkflowUserFieldsField(decimal fieldTypeField = default(decimal), string fontFamilyField = default(string), decimal fontSizeField = default(decimal), decimal groupUserNumberField = default(decimal), string heightField = default(string), bool isInvisibleField = default(bool), decimal pageNumberField = default(decimal), string tagNameField = default(string), string valueField = default(string), string widthField = default(string), string xCoordinateField = default(string), decimal xOffsetField = default(decimal), string yCoordinateField = default(string), decimal yOffsetField = default(decimal))
        {
            this.FieldTypeField = fieldTypeField;
            // to ensure "fontFamilyField" is required (not null)
            this.FontFamilyField = fontFamilyField ?? throw new ArgumentNullException("fontFamilyField is a required property for FullWorkflowRequestWorkflowUserFieldsField and cannot be null");
            this.FontSizeField = fontSizeField;
            this.GroupUserNumberField = groupUserNumberField;
            // to ensure "heightField" is required (not null)
            this.HeightField = heightField ?? throw new ArgumentNullException("heightField is a required property for FullWorkflowRequestWorkflowUserFieldsField and cannot be null");
            this.IsInvisibleField = isInvisibleField;
            this.PageNumberField = pageNumberField;
            // to ensure "tagNameField" is required (not null)
            this.TagNameField = tagNameField ?? throw new ArgumentNullException("tagNameField is a required property for FullWorkflowRequestWorkflowUserFieldsField and cannot be null");
            // to ensure "valueField" is required (not null)
            this.ValueField = valueField ?? throw new ArgumentNullException("valueField is a required property for FullWorkflowRequestWorkflowUserFieldsField and cannot be null");
            // to ensure "widthField" is required (not null)
            this.WidthField = widthField ?? throw new ArgumentNullException("widthField is a required property for FullWorkflowRequestWorkflowUserFieldsField and cannot be null");
            // to ensure "xCoordinateField" is required (not null)
            this.XCoordinateField = xCoordinateField ?? throw new ArgumentNullException("xCoordinateField is a required property for FullWorkflowRequestWorkflowUserFieldsField and cannot be null");
            this.XOffsetField = xOffsetField;
            // to ensure "yCoordinateField" is required (not null)
            this.YCoordinateField = yCoordinateField ?? throw new ArgumentNullException("yCoordinateField is a required property for FullWorkflowRequestWorkflowUserFieldsField and cannot be null");
            this.YOffsetField = yOffsetField;
        }

        /// <summary>
        /// Field type.
        /// </summary>
        /// <value>Field type.</value>
        [DataMember(Name = "FieldTypeField", IsRequired = true, EmitDefaultValue = true)]
        public decimal FieldTypeField { get; set; }

        /// <summary>
        /// The font family of the fields text.
        /// </summary>
        /// <value>The font family of the fields text.</value>
        [DataMember(Name = "FontFamilyField", IsRequired = true, EmitDefaultValue = true)]
        public string FontFamilyField { get; set; }

        /// <summary>
        /// The font size of the fields text.
        /// </summary>
        /// <value>The font size of the fields text.</value>
        [DataMember(Name = "FontSizeField", IsRequired = true, EmitDefaultValue = true)]
        public decimal FontSizeField { get; set; }

        /// <summary>
        /// The users in the group&#39;s user number.
        /// </summary>
        /// <value>The users in the group&#39;s user number.</value>
        [DataMember(Name = "GroupUserNumberField", IsRequired = true, EmitDefaultValue = true)]
        public decimal GroupUserNumberField { get; set; }

        /// <summary>
        /// Field height.
        /// </summary>
        /// <value>Field height.</value>
        [DataMember(Name = "HeightField", IsRequired = true, EmitDefaultValue = true)]
        public string HeightField { get; set; }

        /// <summary>
        /// Is the field visible.
        /// </summary>
        /// <value>Is the field visible.</value>
        [DataMember(Name = "IsInvisibleField", IsRequired = true, EmitDefaultValue = true)]
        public bool IsInvisibleField { get; set; }

        /// <summary>
        /// Field page number.
        /// </summary>
        /// <value>Field page number.</value>
        [DataMember(Name = "PageNumberField", IsRequired = true, EmitDefaultValue = true)]
        public decimal PageNumberField { get; set; }

        /// <summary>
        /// Field tag name.
        /// </summary>
        /// <value>Field tag name.</value>
        [DataMember(Name = "TagNameField", IsRequired = true, EmitDefaultValue = true)]
        public string TagNameField { get; set; }

        /// <summary>
        /// Field value.
        /// </summary>
        /// <value>Field value.</value>
        [DataMember(Name = "ValueField", IsRequired = true, EmitDefaultValue = true)]
        public string ValueField { get; set; }

        /// <summary>
        /// Field width.
        /// </summary>
        /// <value>Field width.</value>
        [DataMember(Name = "WidthField", IsRequired = true, EmitDefaultValue = true)]
        public string WidthField { get; set; }

        /// <summary>
        /// The fields x-coordinates.
        /// </summary>
        /// <value>The fields x-coordinates.</value>
        [DataMember(Name = "XCoordinateField", IsRequired = true, EmitDefaultValue = true)]
        public string XCoordinateField { get; set; }

        /// <summary>
        /// The fields x-coordinates offset.
        /// </summary>
        /// <value>The fields x-coordinates offset.</value>
        [DataMember(Name = "XOffsetField", IsRequired = true, EmitDefaultValue = true)]
        public decimal XOffsetField { get; set; }

        /// <summary>
        /// The fields y-coordinates.
        /// </summary>
        /// <value>The fields y-coordinates.</value>
        [DataMember(Name = "YCoordinateField", IsRequired = true, EmitDefaultValue = true)]
        public string YCoordinateField { get; set; }

        /// <summary>
        /// The fields y-coordinates offset.
        /// </summary>
        /// <value>The fields y-coordinates offset.</value>
        [DataMember(Name = "YOffsetField", IsRequired = true, EmitDefaultValue = true)]
        public decimal YOffsetField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullWorkflowRequestWorkflowUserFieldsField {\n");
            sb.Append("  FieldTypeField: ").Append(FieldTypeField).Append("\n");
            sb.Append("  FontFamilyField: ").Append(FontFamilyField).Append("\n");
            sb.Append("  FontSizeField: ").Append(FontSizeField).Append("\n");
            sb.Append("  GroupUserNumberField: ").Append(GroupUserNumberField).Append("\n");
            sb.Append("  HeightField: ").Append(HeightField).Append("\n");
            sb.Append("  IsInvisibleField: ").Append(IsInvisibleField).Append("\n");
            sb.Append("  PageNumberField: ").Append(PageNumberField).Append("\n");
            sb.Append("  TagNameField: ").Append(TagNameField).Append("\n");
            sb.Append("  ValueField: ").Append(ValueField).Append("\n");
            sb.Append("  WidthField: ").Append(WidthField).Append("\n");
            sb.Append("  XCoordinateField: ").Append(XCoordinateField).Append("\n");
            sb.Append("  XOffsetField: ").Append(XOffsetField).Append("\n");
            sb.Append("  YCoordinateField: ").Append(YCoordinateField).Append("\n");
            sb.Append("  YOffsetField: ").Append(YOffsetField).Append("\n");
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
            return this.Equals(input as FullWorkflowRequestWorkflowUserFieldsField);
        }

        /// <summary>
        /// Returns true if FullWorkflowRequestWorkflowUserFieldsField instances are equal
        /// </summary>
        /// <param name="input">Instance of FullWorkflowRequestWorkflowUserFieldsField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FullWorkflowRequestWorkflowUserFieldsField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldTypeField == input.FieldTypeField ||
                    this.FieldTypeField.Equals(input.FieldTypeField)
                ) && 
                (
                    this.FontFamilyField == input.FontFamilyField ||
                    (this.FontFamilyField != null &&
                    this.FontFamilyField.Equals(input.FontFamilyField))
                ) && 
                (
                    this.FontSizeField == input.FontSizeField ||
                    this.FontSizeField.Equals(input.FontSizeField)
                ) && 
                (
                    this.GroupUserNumberField == input.GroupUserNumberField ||
                    this.GroupUserNumberField.Equals(input.GroupUserNumberField)
                ) && 
                (
                    this.HeightField == input.HeightField ||
                    (this.HeightField != null &&
                    this.HeightField.Equals(input.HeightField))
                ) && 
                (
                    this.IsInvisibleField == input.IsInvisibleField ||
                    this.IsInvisibleField.Equals(input.IsInvisibleField)
                ) && 
                (
                    this.PageNumberField == input.PageNumberField ||
                    this.PageNumberField.Equals(input.PageNumberField)
                ) && 
                (
                    this.TagNameField == input.TagNameField ||
                    (this.TagNameField != null &&
                    this.TagNameField.Equals(input.TagNameField))
                ) && 
                (
                    this.ValueField == input.ValueField ||
                    (this.ValueField != null &&
                    this.ValueField.Equals(input.ValueField))
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
                    this.XOffsetField == input.XOffsetField ||
                    this.XOffsetField.Equals(input.XOffsetField)
                ) && 
                (
                    this.YCoordinateField == input.YCoordinateField ||
                    (this.YCoordinateField != null &&
                    this.YCoordinateField.Equals(input.YCoordinateField))
                ) && 
                (
                    this.YOffsetField == input.YOffsetField ||
                    this.YOffsetField.Equals(input.YOffsetField)
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
                hashCode = hashCode * 59 + this.FieldTypeField.GetHashCode();
                if (this.FontFamilyField != null)
                    hashCode = hashCode * 59 + this.FontFamilyField.GetHashCode();
                hashCode = hashCode * 59 + this.FontSizeField.GetHashCode();
                hashCode = hashCode * 59 + this.GroupUserNumberField.GetHashCode();
                if (this.HeightField != null)
                    hashCode = hashCode * 59 + this.HeightField.GetHashCode();
                hashCode = hashCode * 59 + this.IsInvisibleField.GetHashCode();
                hashCode = hashCode * 59 + this.PageNumberField.GetHashCode();
                if (this.TagNameField != null)
                    hashCode = hashCode * 59 + this.TagNameField.GetHashCode();
                if (this.ValueField != null)
                    hashCode = hashCode * 59 + this.ValueField.GetHashCode();
                if (this.WidthField != null)
                    hashCode = hashCode * 59 + this.WidthField.GetHashCode();
                if (this.XCoordinateField != null)
                    hashCode = hashCode * 59 + this.XCoordinateField.GetHashCode();
                hashCode = hashCode * 59 + this.XOffsetField.GetHashCode();
                if (this.YCoordinateField != null)
                    hashCode = hashCode * 59 + this.YCoordinateField.GetHashCode();
                hashCode = hashCode * 59 + this.YOffsetField.GetHashCode();
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
            // FontFamilyField (string) minLength
            if(this.FontFamilyField != null && this.FontFamilyField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FontFamilyField, length must be greater than 1.", new [] { "FontFamilyField" });
            }

            // HeightField (string) minLength
            if(this.HeightField != null && this.HeightField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HeightField, length must be greater than 1.", new [] { "HeightField" });
            }

            // TagNameField (string) minLength
            if(this.TagNameField != null && this.TagNameField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TagNameField, length must be greater than 1.", new [] { "TagNameField" });
            }

            // ValueField (string) minLength
            if(this.ValueField != null && this.ValueField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ValueField, length must be greater than 1.", new [] { "ValueField" });
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
