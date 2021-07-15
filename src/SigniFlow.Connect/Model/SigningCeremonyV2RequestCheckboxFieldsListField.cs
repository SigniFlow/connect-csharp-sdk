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
    /// SigningCeremonyV2RequestCheckboxFieldsListField
    /// </summary>
    [DataContract(Name = "SigningCeremonyV2Request_CheckboxFieldsListField")]
    public partial class SigningCeremonyV2RequestCheckboxFieldsListField : IEquatable<SigningCeremonyV2RequestCheckboxFieldsListField>, IValidatableObject
    {
//    
//    
//        /// <summary>
//        /// Initializes a new instance of the <see cref="SigningCeremonyV2RequestCheckboxFieldsListField" /> class.
//        /// </summary>
//        [JsonConstructorAttribute]
//        
//        protected SigningCeremonyV2RequestCheckboxFieldsListField() { }
//        
//        
//    
//    
        /// <summary>
        /// Initializes a new instance of the <see cref="SigningCeremonyV2RequestCheckboxFieldsListField" /> class.
        /// </summary>
        /// <param name="checkboxHField">Checkbox field height. (required).</param>
        /// <param name="checkboxPageField">The page on which the Checkbox field is located. (required).</param>
        /// <param name="checkboxWField">Checkbox field width. (required).</param>
        /// <param name="checkboxXField">Checkbox field x-coordinates. (required).</param>
        /// <param name="checkboxYField">Checkbox field y-coordinates. (required).</param>
        /// <param name="isCheckedField">Is the checkbos field checked. (required).</param>
        public SigningCeremonyV2RequestCheckboxFieldsListField(decimal checkboxHField = default(decimal), decimal checkboxPageField = default(decimal), decimal checkboxWField = default(decimal), decimal checkboxXField = default(decimal), decimal checkboxYField = default(decimal), bool isCheckedField = default(bool))
        {
            this.CheckboxHField = checkboxHField;
            this.CheckboxPageField = checkboxPageField;
            this.CheckboxWField = checkboxWField;
            this.CheckboxXField = checkboxXField;
            this.CheckboxYField = checkboxYField;
            this.IsCheckedField = isCheckedField;
        }

        /// <summary>
        /// Checkbox field height.
        /// </summary>
        /// <value>Checkbox field height.</value>
        [DataMember(Name = "CheckboxHField", IsRequired = true, EmitDefaultValue = true)]
        public decimal CheckboxHField { get; set; }

        /// <summary>
        /// The page on which the Checkbox field is located.
        /// </summary>
        /// <value>The page on which the Checkbox field is located.</value>
        [DataMember(Name = "CheckboxPageField", IsRequired = true, EmitDefaultValue = true)]
        public decimal CheckboxPageField { get; set; }

        /// <summary>
        /// Checkbox field width.
        /// </summary>
        /// <value>Checkbox field width.</value>
        [DataMember(Name = "CheckboxWField", IsRequired = true, EmitDefaultValue = true)]
        public decimal CheckboxWField { get; set; }

        /// <summary>
        /// Checkbox field x-coordinates.
        /// </summary>
        /// <value>Checkbox field x-coordinates.</value>
        [DataMember(Name = "CheckboxXField", IsRequired = true, EmitDefaultValue = true)]
        public decimal CheckboxXField { get; set; }

        /// <summary>
        /// Checkbox field y-coordinates.
        /// </summary>
        /// <value>Checkbox field y-coordinates.</value>
        [DataMember(Name = "CheckboxYField", IsRequired = true, EmitDefaultValue = true)]
        public decimal CheckboxYField { get; set; }

        /// <summary>
        /// Is the checkbos field checked.
        /// </summary>
        /// <value>Is the checkbos field checked.</value>
        [DataMember(Name = "IsCheckedField", IsRequired = true, EmitDefaultValue = true)]
        public bool IsCheckedField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SigningCeremonyV2RequestCheckboxFieldsListField {\n");
            sb.Append("  CheckboxHField: ").Append(CheckboxHField).Append("\n");
            sb.Append("  CheckboxPageField: ").Append(CheckboxPageField).Append("\n");
            sb.Append("  CheckboxWField: ").Append(CheckboxWField).Append("\n");
            sb.Append("  CheckboxXField: ").Append(CheckboxXField).Append("\n");
            sb.Append("  CheckboxYField: ").Append(CheckboxYField).Append("\n");
            sb.Append("  IsCheckedField: ").Append(IsCheckedField).Append("\n");
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
            return this.Equals(input as SigningCeremonyV2RequestCheckboxFieldsListField);
        }

        /// <summary>
        /// Returns true if SigningCeremonyV2RequestCheckboxFieldsListField instances are equal
        /// </summary>
        /// <param name="input">Instance of SigningCeremonyV2RequestCheckboxFieldsListField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SigningCeremonyV2RequestCheckboxFieldsListField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CheckboxHField == input.CheckboxHField ||
                    this.CheckboxHField.Equals(input.CheckboxHField)
                ) && 
                (
                    this.CheckboxPageField == input.CheckboxPageField ||
                    this.CheckboxPageField.Equals(input.CheckboxPageField)
                ) && 
                (
                    this.CheckboxWField == input.CheckboxWField ||
                    this.CheckboxWField.Equals(input.CheckboxWField)
                ) && 
                (
                    this.CheckboxXField == input.CheckboxXField ||
                    this.CheckboxXField.Equals(input.CheckboxXField)
                ) && 
                (
                    this.CheckboxYField == input.CheckboxYField ||
                    this.CheckboxYField.Equals(input.CheckboxYField)
                ) && 
                (
                    this.IsCheckedField == input.IsCheckedField ||
                    this.IsCheckedField.Equals(input.IsCheckedField)
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
                hashCode = hashCode * 59 + this.CheckboxHField.GetHashCode();
                hashCode = hashCode * 59 + this.CheckboxPageField.GetHashCode();
                hashCode = hashCode * 59 + this.CheckboxWField.GetHashCode();
                hashCode = hashCode * 59 + this.CheckboxXField.GetHashCode();
                hashCode = hashCode * 59 + this.CheckboxYField.GetHashCode();
                hashCode = hashCode * 59 + this.IsCheckedField.GetHashCode();
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
            yield break;
        }
    }

}
