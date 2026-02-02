using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace SigniFlow.Connect.Model
{
    /// <summary>
    ///  #### Response returned after sending a reminder for a document.
    /// </summary>
    [DataContract(Name = "SendReminderResponse")]
    public partial class SendReminderResponse : IEquatable<SendReminderResponse> , IValidatableObject
    {
        /// <summary>
        /// new instance of the <see cref="SendReminderResponse" /> class.
        /// </summary>
        /// <param name="docIDField"></param>
        /// <param name="resultField"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public SendReminderResponse(int docIDField = default(int), string resultField = default(string))
        {
            this.DocIDField = docIDField;
            // to ensure "resultField" is required (not null)
            this.ResultField = resultField ??
                               throw new ArgumentNullException(
                                   "resultField is a required property for SendReminderResponse and cannot be null");
        }
        
        /// <summary>
        /// Document ID field.
        /// </summary>
        [DataMember(Name = "DocIDField", IsRequired = true, EmitDefaultValue = true)]
        public int DocIDField { get; set; }
        
        /// <summary>
        /// Displays the result of the call.
        /// </summary>
        [DataMember(Name = "ResultField", IsRequired = true, EmitDefaultValue = true)]
        public string ResultField { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendReminderResponse {\n");
            sb.Append("  DocIDField: ").Append(DocIDField).Append("\n");
            sb.Append("  ResultField: ").Append(ResultField).Append("\n");
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
        /// <param name="input"></param>
        /// <returns></returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SendReminderResponse);
        }
        
        /// <summary>
        /// Return true if SendReminderResponse instances are equal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool Equals(SendReminderResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocIDField == input.DocIDField ||
                    this.DocIDField.Equals(input.DocIDField)
                ) && 
                (
                    this.ResultField == input.ResultField ||
                    (this.ResultField != null &&
                    this.ResultField.Equals(input.ResultField))
                );
        }
        
        /// <summary>
        /// Get Hash Code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            int hashCode = 41;
            hashCode = hashCode * 59 + this.DocIDField.GetHashCode();
            if(this.ResultField != null)
                hashCode = hashCode * 59 + this.ResultField.GetHashCode();
            return hashCode;
        }

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // ResultField (string) minLength
            if (this.ResultField != null && this.ResultField.Length < 1)
            {
                yield return new ValidationResult(
                    "Invalid value for ResultField, length must be greater than or equal to 1.",
                    new[] { "ResultField" });
            }

            yield break;
        }
    }
}