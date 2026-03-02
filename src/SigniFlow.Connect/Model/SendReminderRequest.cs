using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace SigniFlow.Connect.Model
{
    [DataContract(Name = "SendReminderRequest")]
    public partial class SendReminderRequest : IEquatable<SendReminderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendReminderRequest" /> class.
        /// </summary>
        /// <param name="awaitingFromEmailField"></param>
        /// <param name="awaitingFromIdField"></param>
        /// <param name="awaitingFromNameField"></param>
        /// <param name="dateRequestedField"></param>
        /// <param name="docIDField"></param>
        /// <param name="docNameField"></param>
        /// <param name="dueDateField"></param>
        /// <param name="tokenField"></param>
        public SendReminderRequest(string awaitingFromEmailField = default(string),
            string awaitingFromIdField = default(string),
            string awaitingFromNameField = default(string),
            DateTime dateRequestedField = default(DateTime),
            int docIDField = default(int),
            string docNameField = default(string),
            DateTime dueDateField = default(DateTime),
            TokenField tokenField = default(TokenField))
            {
                this.AwaintingFromEmailField = awaitingFromEmailField;
                this.AwaintingFromIdField = awaitingFromIdField;
                this.AwaintingFromNameField = awaitingFromNameField;
                this.DateRequestedField = dateRequestedField;
                this.DocIDField = docIDField;
                this.DocNameField = docNameField;
                this.DueDateField = dueDateField;
                this.TokenField = tokenField;
            }
        
        /// <summary>
        /// Awaiting From Email Field
        /// </summary>
        [DataMember(Name = "AwaintingFromEmailField")]
        public string AwaintingFromEmailField { get; set; }
        
        /// <summary>
        /// Awaiting From User Id Field
        /// </summary>
        [DataMember(Name = "AwaintingFromIDField")]
        public string AwaintingFromIdField { get; set; }
        
        /// <summary>
        /// Awaiting From Full Name Field
        /// </summary>
        [DataMember(Name = "AwaintingFromNameField")]
        public string AwaintingFromNameField { get; set; }
        
        /// <summary>
        /// Date Requested Field
        /// </summary>
        [DataMember(Name = "DateRequestedField")]
        public DateTime DateRequestedField { get; set; }
        
        /// <summary>
        /// Document ID Field
        /// </summary>
        [DataMember(Name = "DocIDField")]
        public int DocIDField { get; set; }
        
        /// <summary>
        /// Document Name Field
        /// </summary>
        [DataMember(Name = "DocNameField")]
        public string DocNameField { get; set; }
        
        /// <summary>
        ///  Document Due Date Field
        /// </summary>
        [DataMember(Name = "DueDateField")]
        public DateTime DueDateField { get; set; }
        
        /// <summary>
        /// Token for sending the request
        /// </summary>
        [DataMember(Name = "TokenField", IsRequired = true, EmitDefaultValue = true)]
        public TokenField TokenField { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append("class SendReminderRequest {\n");
            sb.Append("  AwaitingFromEmailField: ").Append(AwaintingFromEmailField).Append("\n");
            sb.Append("  AwaitingFromIdField: ").Append(AwaintingFromIdField).Append("\n");
            sb.Append("  AwaitingFromNameField: ").Append(AwaintingFromNameField).Append("\n");
            sb.Append("  DateRequestedField: ").Append(DateRequestedField).Append("\n");
            sb.Append("  DocIDField: ").Append(DocIDField).Append("\n");
            sb.Append("  DocNameField: ").Append(DocNameField).Append("\n");
            sb.Append("  DueDateField: ").Append(DueDateField).Append("\n");
            sb.Append("  TokenField: ").Append(TokenField).Append("\n");
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

        public override bool Equals(object obj)
        {
            return this.Equals(obj as SendReminderRequest);
        }
        
        /// <summary>
        /// Returns true if SendReminderRequest instances are equal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool Equals(SendReminderRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AwaintingFromEmailField == input.AwaintingFromEmailField ||
                    (this.AwaintingFromEmailField != null &&
                     this.AwaintingFromEmailField.Equals(input.AwaintingFromEmailField))
                ) &&
                (
                    this.AwaintingFromIdField == input.AwaintingFromIdField ||
                    (this.AwaintingFromIdField != null &&
                     this.AwaintingFromIdField.Equals(input.AwaintingFromIdField))
                ) &&
                (
                    this.AwaintingFromNameField == input.AwaintingFromNameField ||
                    (this.AwaintingFromNameField != null &&
                     this.AwaintingFromNameField.Equals(input.AwaintingFromNameField))
                ) &&
                (
                    this.DateRequestedField == input.DateRequestedField ||
                    (this.DateRequestedField != null &&
                     this.DateRequestedField.Equals(input.DateRequestedField))
                ) &&
                (
                    this.DocIDField == input.DocIDField ||
                    this.DocIDField.Equals(input.DocIDField)
                ) &&
                (
                    this.DocNameField == input.DocNameField ||
                    (this.DocNameField != null &&
                     this.DocNameField.Equals(input.DocNameField))
                ) &&
                (
                    this.DueDateField == input.DueDateField ||
                    (this.DueDateField != null &&
                     this.DueDateField.Equals(input.DueDateField))
                ) &&
                (
                    this.TokenField == input.TokenField ||
                    (this.TokenField != null &&
                     this.TokenField.Equals(input.TokenField))
                );
        }
        
        /// <summary>
        /// Get the hash code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.AwaintingFromEmailField != null)
                    hashCode = hashCode * 59 + this.AwaintingFromEmailField.GetHashCode();
                if (this.AwaintingFromIdField != null)
                    hashCode = hashCode * 59 + this.AwaintingFromIdField.GetHashCode();
                if (this.AwaintingFromNameField != null)
                    hashCode = hashCode * 59 + this.AwaintingFromNameField.GetHashCode();
                if (this.DateRequestedField != null)
                    hashCode = hashCode * 59 + this.DateRequestedField.GetHashCode();
                hashCode = hashCode * 59 + this.DocIDField.GetHashCode();
                if (this.DocNameField != null)
                    hashCode = hashCode * 59 + this.DocNameField.GetHashCode();
                if (this.DueDateField != null)
                    hashCode = hashCode * 59 + this.DueDateField.GetHashCode();
                if (this.TokenField != null)
                    hashCode = hashCode * 59 + this.TokenField.GetHashCode();
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