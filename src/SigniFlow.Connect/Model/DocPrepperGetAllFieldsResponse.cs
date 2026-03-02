using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;

namespace SigniFlow.Connect.Model
{
    [DataContract(Name = "DocPrepperGetAllFieldsResponse")]
    public class DocPrepperGetAllFieldsResponse: IEquatable<DocPrepperGetAllFieldsResponse>, IValidatableObject
    {
        public DocPrepperGetAllFieldsResponse(string resultField = default(string), List<PrepperFieldValuesField> prepperFieldValuesField = default(List<PrepperFieldValuesField>))
        {
            this.ResultField = resultField;
            this.PrepperFieldValuesField = prepperFieldValuesField;
        }
        
        /// <summary>
        /// Results of the call.
        /// </summary>
        [DataMember(Name = "ResultField", IsRequired = true, EmitDefaultValue = true)]
        public string ResultField { get; set; }
        
        /// <summary>
        /// Gets all prepper fields for the document.
        /// </summary>
        [DataMember(Name = "PrepperFieldValuesField", EmitDefaultValue = true)]
        public List<PrepperFieldValuesField> PrepperFieldValuesField { get; set; }

        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append("class DocPrepperGetAllFieldsResponse {\n");
            sb.Append("  ResultField: ").Append(ResultField).Append("\n");
            sb.Append("  PrepperFieldValuesField: ").Append(PrepperFieldValuesField).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Return the JSON string presentation of the object
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
            return this.Equals(obj as DocPrepperGetAllFieldsResponse);
        }

        /// <summary>
        /// Returns true if DocPrepperGetAllFieldsResponse instances are equal
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(DocPrepperGetAllFieldsResponse other)
        {
            if (other == null)
                return false;

            return 
                (
                    this.ResultField == other.ResultField ||
                    (this.ResultField != null &&
                    this.ResultField.Equals(other.ResultField))
                ) && 
                (
                    this.PrepperFieldValuesField == other.PrepperFieldValuesField ||
                    this.PrepperFieldValuesField != null &&
                    other.PrepperFieldValuesField != null &&
                    this.PrepperFieldValuesField.SequenceEqual(other.PrepperFieldValuesField)
                );
        }
        
        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ResultField != null)
                    hashCode = hashCode * 59 + this.ResultField.GetHashCode();
                if (this.PrepperFieldValuesField != null)
                    hashCode = hashCode * 59 + this.PrepperFieldValuesField.GetHashCode();
                return hashCode;
            }
        }
        
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}