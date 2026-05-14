using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace SigniFlow.Connect.Model
{
    [DataContract(Name = "UserField")]
    public class UserField: IEquatable<UserField>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UserField" /> class.
        /// </summary>
        public UserField(FieldType docFieldTypeField = default(FieldType),
            string fontFamilyField = default(string),
            int fontSizeField = default(int),
            int heightField = default(int),
            int widthField = default(int),
            decimal xCoordinateField = default(decimal),
            int xOffsetField = default(int),
            decimal yCoordinateField = default(decimal),
            int yOffsetField = default(int),
            int pageNumberField = default(int),
            string nameField = default(string),
            int validationIDField = default(int),
            int combCharacterAmountField = default(int),
            string valueField = default(string),
            bool isInvisibleField = default(bool),
            DateFormatField dateFormatField = default(DateFormatField)
            )
        {
            this.DocFieldTypeField = docFieldTypeField;
            this.FontFamilyField = fontFamilyField;
            this.FontSizeField = fontSizeField;
            this.HeightField = heightField.ToString();
            this.WidthField = widthField.ToString();
            this.XCoordinateField = xCoordinateField.ToString();
            this.XOffsetField = xOffsetField;
            this.YCoordinateField = yCoordinateField.ToString();
            this.YOffsetField = yOffsetField;
            this.PageNumberField = pageNumberField;
            this.NameField = nameField;
            this.ValidationIDField = validationIDField;
            this.CombCharacterAmountField = combCharacterAmountField;
            this.ValueField = valueField;
            this.IsInvisibleField = isInvisibleField;
            this.DateFormatField = dateFormatField;
        }

        [DataMember(Name = "DateFormatField", EmitDefaultValue = true)]
        public DateFormatField DateFormatField { get; set; }

        [DataMember(Name = "DocFieldTypeField", EmitDefaultValue = true)]
        public FieldType DocFieldTypeField { get; set; }
        
        [DataMember(Name = "FontFamilyField", EmitDefaultValue = true)]
        public string FontFamilyField {get; set;}
        
        [DataMember(Name = "FontSizeField", EmitDefaultValue = true)]
        public int FontSizeField { get; set; }
        
        [DataMember(Name = "HeightField", EmitDefaultValue = true)]
        public string HeightField { get; set; }
        
        [DataMember(Name = "WidthField", EmitDefaultValue = true)]
        public string WidthField { get; set; }
        
        [DataMember(Name = "XCoordinateField", EmitDefaultValue = true)]
        public string XCoordinateField { get; set; }
        
        [DataMember(Name = "XOffsetField", EmitDefaultValue = true)]
        public int XOffsetField { get; set; }
        
        [DataMember(Name = "YCoordinateField", EmitDefaultValue = true)]
        public string YCoordinateField { get; set; }
        
        [DataMember(Name = "YOffsetField", EmitDefaultValue = true)]
        public int YOffsetField { get; set; }
        
        [DataMember(Name = "PageNumberField", EmitDefaultValue = true)]
        public int PageNumberField { get; set; }
        
        [DataMember(Name = "NameField", EmitDefaultValue = true)]
        public string NameField { get; set; }
        
        [DataMember(Name = "ValidationIDField", EmitDefaultValue = true)]
        public int ValidationIDField { get; set; }
        
        [DataMember(Name = "CombCharacterAmountField", EmitDefaultValue = true)]
        public int CombCharacterAmountField { get; set; }
        
        [DataMember(Name = "ValueField", EmitDefaultValue = true)]
        public string ValueField { get; set; }
        
        [DataMember(Name = "IsInvisibleField", EmitDefaultValue = true)]
        public bool IsInvisibleField { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NominatedSignersFieldListField {\n");
            sb.Append("  DocFieldTypeField: ").Append(DocFieldTypeField).Append("\n");
            sb.Append("  FontFamilyField: ").Append(FontFamilyField).Append("\n");
            sb.Append("  FontSizeField: ").Append(FontSizeField).Append("\n");
            sb.Append("  HeightField: ").Append(HeightField).Append("\n");
            sb.Append("  WidthField: ").Append(WidthField).Append("\n");
            sb.Append("  XCoordinateField: ").Append(XCoordinateField).Append("\n");
            sb.Append("  XOffsetField: ").Append(XOffsetField).Append("\n");
            sb.Append("  YCoordinateField: ").Append(YCoordinateField).Append("\n");
            sb.Append("  YOffsetField: ").Append(YOffsetField).Append("\n");
            sb.Append("  PageNumberField: ").Append(PageNumberField).Append("\n");
            sb.Append("  NameField: ").Append(NameField).Append("\n");
            sb.Append("  ValidationIDField: ").Append(ValidationIDField).Append("\n");
            sb.Append("  CombCharacterAmountField: ").Append(CombCharacterAmountField).Append("\n");
            sb.Append("  ValueField: ").Append(ValueField).Append("\n");
            sb.Append("  IsInvisibleField: ").Append(IsInvisibleField).Append("\n");
            sb.Append("  DateFormatField: ").Append(DateFormatField != null ? JsonConvert.SerializeObject(DateFormatField) : "null").Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }


        public virtual string ToJson() => Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        
        public override bool Equals(object input) => this.Equals(input as UserField);

        public bool Equals(UserField input)
        {
            if (input == null)
                return false;

            return
                (
                    this.DocFieldTypeField == input.DocFieldTypeField ||
                    (this.DocFieldTypeField != null &&
                     this.DocFieldTypeField.Equals(input.DocFieldTypeField))
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
                    this.HeightField == input.HeightField ||
                    this.HeightField.Equals(input.HeightField)
                ) &&
                (
                    this.WidthField == input.WidthField ||
                    this.WidthField.Equals(input.WidthField)
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
                ) &&
                (
                    this.PageNumberField == input.PageNumberField ||
                    this.PageNumberField.Equals(input.PageNumberField)
                ) &&
                (
                    this.NameField == input.NameField ||
                    (this.NameField != null &&
                     this.NameField.Equals(input.NameField))
                ) &&
                (
                    this.ValidationIDField == input.ValidationIDField ||
                    this.ValidationIDField.Equals(input.ValidationIDField)
                ) &&
                (
                    this.CombCharacterAmountField == input.CombCharacterAmountField ||
                    this.CombCharacterAmountField.Equals(input.CombCharacterAmountField)
                ) &&
                (
                    this.ValueField == input.ValueField ||
                    (this.ValueField != null &&
                     this.ValueField.Equals(input.ValueField))
                )&&
                (
                    this.IsInvisibleField == input.IsInvisibleField||
                    this.IsInvisibleField.Equals(input.IsInvisibleField)
                )
                && (this.DateFormatField.Equals(input.DateFormatField));
        }
        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DocFieldTypeField != null)
                    hashCode = hashCode * 59 + this.DocFieldTypeField.GetHashCode();
                if (this.FontFamilyField != null)
                    hashCode = hashCode * 59 + this.FontFamilyField.GetHashCode();
                hashCode = hashCode * 59 + this.FontSizeField.GetHashCode();
                hashCode = hashCode * 59 + this.HeightField.GetHashCode();
                hashCode = hashCode * 59 + this.WidthField.GetHashCode();
                if (this.XCoordinateField != null)
                    hashCode = hashCode * 59 + this.XCoordinateField.GetHashCode();
                hashCode = hashCode * 59 + this.XOffsetField.GetHashCode();
                if (this.YCoordinateField != null)
                    hashCode = hashCode * 59 + this.YCoordinateField.GetHashCode();
                hashCode = hashCode * 59 + this.YOffsetField.GetHashCode();
                hashCode = hashCode * 59 + this.PageNumberField.GetHashCode();
                if (this.NameField != null)
                    hashCode = hashCode * 59 + this.NameField.GetHashCode();
                hashCode = hashCode * 59 + this.ValidationIDField.GetHashCode();
                hashCode = hashCode * 59 + this.CombCharacterAmountField.GetHashCode();
                if (this.ValueField != null)
                    hashCode = hashCode * 59 + this.ValueField.GetHashCode();
                return hashCode;
            }
        }
        
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
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