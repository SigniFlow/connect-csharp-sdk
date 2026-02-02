using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace SigniFlow.Connect.Model
{
    /// <summary>
    ///  ### A request sent to get all fields of a document.
    /// </summary>
    [DataContract(Name =  "SendReminderRequest")]
    public partial class DocPrepperGetAllFieldsRequest : IEquatable<DocPrepperGetAllFieldsRequest>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DocPrepperGetAllFieldsRequest" /> class.
        /// </summary>
        /// <param name="docIDField"></param>
        /// <param name="tokenField"></param>
        public DocPrepperGetAllFieldsRequest(int docIDField = default(int), TokenField tokenField = default(TokenField))
        {
            this.DocIDField = docIDField;
            this.TokenField = tokenField;
        }
        
        /// <summary>
        /// Document ID Field
        /// </summary>
        [DataMember(Name = "DocIDField", IsRequired = true, EmitDefaultValue = true)]
        public int DocIDField { get; set; }
        
        /// <summary>
        /// Token for sending requests
        /// </summary>
        [DataMember(Name = "TokenField", IsRequired = true, EmitDefaultValue = true)]
        public TokenField TokenField { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocPrepperGetAllFieldsRequest {\n");
            sb.Append("  DocIDField: ").Append(DocIDField).Append("\n");
            sb.Append("  TokenField: ").Append(TokenField).Append("\n");
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
        ///  Returns true if objects are equal
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as DocPrepperGetAllFieldsRequest);
        }
        
        /// <summary>
        /// Returns true if DocPrepperGetAllFieldsRequest instances are equal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool Equals(DocPrepperGetAllFieldsRequest input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    this.DocIDField == input.DocIDField ||
                    this.DocIDField.Equals(input.DocIDField)
                ) &&
                (
                    this.TokenField.Equals(input.TokenField) ||
                    (this.TokenField != null &&
                     this.TokenField.Equals(input.TokenField))
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
                hashCode = (hashCode * 59) + this.DocIDField.GetHashCode();
                if (this.TokenField != null)
                {
                    hashCode = (hashCode * 59) + this.TokenField.GetHashCode();
                }
                return hashCode;
            }
        }
        
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}