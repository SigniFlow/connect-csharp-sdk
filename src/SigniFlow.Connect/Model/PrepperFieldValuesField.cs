using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace SigniFlow.Connect.Model
{
    [DataContract(Name = "PrepperFieldValuesField")]
    public class PrepperFieldValuesField: IEquatable<PrepperFieldValuesField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrepperFieldValuesField" /> class.
        /// </summary>
        /// <param name="docIDField"></param>
        /// <param name="fieldNameField"></param>
        /// <param name="fieldTypeField"></param>
        /// <param name="fieldValueField"></param>
        /// <param name="heightField"></param>
        /// <param name="pageNumberField"></param>
        /// <param name="prepperFieldIDField"></param>
        /// <param name="userFullNameField"></param>
        /// <param name="userIDField"></param>
        /// <param name="widthField"></param>
        /// <param name="xCoordinateField"></param>
        /// <param name="yCoordinateField"></param>
        public PrepperFieldValuesField(int docIDField = default(int), 
            string fieldNameField = default(string),
            string fieldTypeField = default(string),
            string fieldValueField = default(string),
            string heightField = default(string),
            int pageNumberField = default(int),
            int prepperFieldIDField = default(int),
            string userFullNameField = default(string),
            int userIDField = default(int),
            string widthField = default(string),
            string xCoordinateField = default(string),
            string yCoordinateField = default(string))
        {
            this.DocIDField = docIDField;
            this.FieldNameField = fieldNameField;
            this.FieldTypeField = fieldTypeField;
            this.FieldValueField = fieldValueField;
            this.HeightField = heightField;
            this.PageNumberField = pageNumberField;
            this.PrepperFieldIDField = prepperFieldIDField;
            this.UserFullNameField = userFullNameField;
            this.UserIDField = userIDField;
            this.WidthField = widthField;
            this.XCoordinateField = xCoordinateField;
            this.YCoordinateField = yCoordinateField;
        }
        
        /// <summary>
        /// Document ID field.
        /// </summary>
        [DataMember(Name = "DocIDField", IsRequired = true, EmitDefaultValue = true)]
        public int DocIDField { get; set; }
        
        /// <summary>
        /// Field Name field.
        /// </summary>
        [DataMember(Name = "FieldNameField", IsRequired = true, EmitDefaultValue = true)]
        public string FieldNameField { get; set; }
        
        /// <summary>
        /// Field Type field.
        /// </summary>
        [DataMember(Name = "FieldTypeField", IsRequired = true, EmitDefaultValue = true)]
        public string FieldTypeField { get; set; }
        
        /// <summary>
        /// Field Value field.
        /// </summary>
        [DataMember(Name = "FieldValueField", IsRequired = true, EmitDefaultValue = true)]
        public string FieldValueField { get; set; }
        
        /// <summary>
        /// Height field.
        /// </summary>
        [DataMember(Name = "HeightField", IsRequired = true, EmitDefaultValue = true)]
        public string HeightField { get; set; }
        
        /// <summary>
        /// Page Number field.
        /// </summary>
        [DataMember(Name = "PageNumberField", IsRequired = true, EmitDefaultValue = true)]
        public int PageNumberField { get; set; }
        
        /// <summary>
        /// Prepper Field ID field.
        /// </summary>
        [DataMember(Name = "PrepperFieldIDField", IsRequired = true, EmitDefaultValue = true)]
        public int PrepperFieldIDField { get; set; }
        
        /// <summary>
        /// User Full Name field.
        /// </summary>
        [DataMember(Name = "UserFullNameField", IsRequired = true, EmitDefaultValue = true)]
        public string UserFullNameField { get; set; }
        
        /// <summary>
        /// User ID field.
        /// </summary>
        [DataMember(Name = "UserIDField", IsRequired = true, EmitDefaultValue = true)]
        public int UserIDField { get; set; }
        
        /// <summary>
        /// Width field.
        /// </summary>
        [DataMember(Name = "WidthField", IsRequired = true, EmitDefaultValue = true)]
        public string WidthField { get; set; }
        
        /// <summary>
        /// X Coordinate field.
        /// </summary>
        [DataMember(Name = "XCoordinateField", IsRequired = true, EmitDefaultValue = true)]
        public string XCoordinateField { get; set; }
        
        /// <summary>
        /// Y Coordinate field.
        /// </summary>
        [DataMember(Name = "YCoordinateField", IsRequired = true, EmitDefaultValue = true)]
        public string YCoordinateField { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append("class PrepperFieldValuesField {\n");
            sb.Append("  DocIDField: ").Append(DocIDField).Append("\n");
            sb.Append("  FieldNameField: ").Append(FieldNameField).Append("\n");
            sb.Append("  FieldTypeField: ").Append(FieldTypeField).Append("\n");
            sb.Append("  FieldValueField: ").Append(FieldValueField).Append("\n");
            sb.Append("  HeightField: ").Append(HeightField).Append("\n");
            sb.Append("  PageNumberField: ").Append(PageNumberField).Append("\n");
            sb.Append("  PrepperFieldIDField: ").Append(PrepperFieldIDField).Append("\n");
            sb.Append("  UserFullNameField: ").Append(UserFullNameField).Append("\n");
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
        /// <returns></returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as PrepperFieldValuesField);
        }
        
        /// <summary>
        /// Returns true if PrepperFieldValuesField instances are equal
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Equals(PrepperFieldValuesField other)
        {
            if (other == null)
                return false;
            
            return 
                (
                    this.DocIDField == other.DocIDField ||
                    this.DocIDField.Equals(other.DocIDField)
                ) && 
                (
                    this.FieldNameField == other.FieldNameField ||
                    (this.FieldNameField != null &&
                    this.FieldNameField.Equals(other.FieldNameField))
                ) && 
                (
                    this.FieldTypeField == other.FieldTypeField ||
                    (this.FieldTypeField != null &&
                    this.FieldTypeField.Equals(other.FieldTypeField))
                ) && 
                (
                    this.FieldValueField == other.FieldValueField ||
                    (this.FieldValueField != null &&
                    this.FieldValueField.Equals(other.FieldValueField))
                ) && 
                (
                    this.HeightField == other.HeightField ||
                    (this.HeightField != null &&
                    this.HeightField.Equals(other.HeightField))
                ) && 
                (
                    this.PageNumberField == other.PageNumberField ||
                    this.PageNumberField.Equals(other.PageNumberField)
                ) && 
                (
                    this.PrepperFieldIDField == other.PrepperFieldIDField ||
                    this.PrepperFieldIDField.Equals(other.PrepperFieldIDField)
                ) && 
                (
                    this.UserFullNameField == other.UserFullNameField ||
                    (this.UserFullNameField != null &&
                    this.UserFullNameField.Equals(other.UserFullNameField))
                ) && 
                (
                    this.UserIDField == other.UserIDField ||
                    this.UserIDField.Equals(other.UserIDField)
                ) && 
                (
                    this.WidthField == other.WidthField ||
                    (this.WidthField != null &&
                    this.WidthField.Equals(other.WidthField))
                ) && 
                (
                    this.XCoordinateField == other.XCoordinateField ||
                    (this.XCoordinateField != null &&
                    this.XCoordinateField.Equals(other.XCoordinateField))
                ) && 
                (
                    this.YCoordinateField == other.YCoordinateField ||
                    (this.YCoordinateField != null &&
                    this.YCoordinateField.Equals(other.YCoordinateField))
                );
        }
        
        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.DocIDField != null)
                    hashCode = hashCode * 59 + this.DocIDField.GetHashCode();
                if (this.FieldNameField != null)
                    hashCode = hashCode * 59 + this.FieldNameField.GetHashCode();
                if (this.FieldTypeField != null)
                    hashCode = hashCode * 59 + this.FieldTypeField.GetHashCode();
                if (this.FieldValueField != null)
                    hashCode = hashCode * 59 + this.FieldValueField.GetHashCode();
                if (this.HeightField != null)
                    hashCode = hashCode * 59 + this.HeightField.GetHashCode();
                if (this.PageNumberField != null)
                    hashCode = hashCode * 59 + this.PageNumberField.GetHashCode();
                if (this.PrepperFieldIDField != null)
                    hashCode = hashCode * 59 + this.PrepperFieldIDField.GetHashCode();
                if (this.UserFullNameField != null)
                    hashCode = hashCode * 59 + this.UserFullNameField.GetHashCode();
                if (this.UserIDField != null)
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
        /// <param name="validationContext"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}