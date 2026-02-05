using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace SigniFlow.Connect.Model
{
    /// <summary>
    /// NominatedSignersField for FullWorkFlowRequest
    /// </summary>
    [DataContract(Name = "NominatedSignersField")]
    public class NominatedSignersField : IEquatable<NominatedSignersField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SigniFlow.Connect.Model.NominatedSignersField" /> class.
        /// </summary>
        /// <param name="userFields"></param>
        /// <param name="photoAtSigningField"></param>
        /// <param name="sendCompletedEmailField"></param>
        /// <param name="signerNicknameField"></param>
        public NominatedSignersField(List<UserField> userFields = default(List<UserField>),
            PhotoAtSigning? photoAtSigningField = null, 
            int sendCompletedEmailField = default(int),
            string signerNicknameField = default(string))
        {
            this.UserFieldListUserField = userFields;
            this.PhotoAtSigningField = photoAtSigningField;
            this.SendCompletedEmailField = sendCompletedEmailField;
            this.SignerNicknameField = signerNicknameField;
        }
        
        [DataMember(Name = "FieldsListField", EmitDefaultValue = false)]
        public List<UserField> UserFieldListUserField { get; set; }
        
        [DataMember(Name = "PhotoAtSigningField", EmitDefaultValue = false)]
        public PhotoAtSigning? PhotoAtSigningField { get; set; }
        
        [DataMember(Name = "SendCompletedEmailField", EmitDefaultValue = false)]
        public int SendCompletedEmailField { get; set; }
        
        [DataMember(Name = "SignerNicknameField", EmitDefaultValue = false)]
        public string SignerNicknameField { get; set; }

        /// <summary>
        ///  Returns the string presentation of the object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NominatedSignersField {\n");
            sb.Append("  UserFieldListUserField: ").Append(UserFieldListUserField).Append("\n");
            sb.Append("  PhotoAtSigningField: ").Append(PhotoAtSigningField).Append("\n");
            sb.Append("  SendCompletedEmailField: ").Append(SendCompletedEmailField).Append("\n");
            sb.Append("  SignerNicknameField: ").Append(SignerNicknameField).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns></returns>
        public virtual string ToJson() => Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)=> this.Equals(obj as NominatedSignersField);
    
        /// <summary>
        /// Returns true if NominatedSignersField instances are equal
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(NominatedSignersField other)
        {
            if (other == null)
                return false;

            return 
                (
                    this.UserFieldListUserField == other.UserFieldListUserField ||
                    (this.UserFieldListUserField != null &&
                    other.UserFieldListUserField != null &&
                    this.UserFieldListUserField.SequenceEqual(other.UserFieldListUserField))
                ) && 
                (
                    this.PhotoAtSigningField == other.PhotoAtSigningField ||
                    (this.PhotoAtSigningField.Equals(other.PhotoAtSigningField))
                ) && 
                (
                    this.SendCompletedEmailField == other.SendCompletedEmailField ||
                    this.SendCompletedEmailField.Equals(other.SendCompletedEmailField)
                ) && 
                (
                    this.SignerNicknameField == other.SignerNicknameField ||
                    (this.SignerNicknameField != null &&
                    this.SignerNicknameField.Equals(other.SignerNicknameField))
                );
        }

        /// <summary>
        /// Returns the hash code for this instance
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.UserFieldListUserField != null)
                    hashCode = hashCode * 59 + this.UserFieldListUserField.GetHashCode();
                if (this.PhotoAtSigningField != null)
                    hashCode = hashCode * 59 + this.PhotoAtSigningField.GetHashCode();
                hashCode = hashCode * 59 + this.SendCompletedEmailField.GetHashCode();
                if (this.SignerNicknameField != null)
                    hashCode = hashCode * 59 + this.SignerNicknameField.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// Returns the list of invalid properties with reasons.
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}