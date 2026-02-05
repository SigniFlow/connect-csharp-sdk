using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace SigniFlow.Connect.Model
{
    /// <summary>
    /// PreloadedFaceToFaceSigners
    /// </summary>
    [DataContract(Name = "PreloadedFaceToFaceSigners")]
    public class PreloadedFaceToFaceSigners : IEquatable<PreloadedFaceToFaceSigners>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SigniFlow.Connect.Model.PreloadedFaceToFaceSigners" /> class.
        /// </summary>
        /// <param name="countryIdField"></param>
        /// <param name="fieldsListField"></param>
        /// <param name="iDTypeField"></param>
        /// <param name="iDentificationNumberField"></param>
        /// <param name="photoAtSigningField"></param>
        /// <param name="sendCompletedEmailField"></param>
        /// <param name="sendOTPField"></param>
        /// <param name="signerEmailField"></param>
        /// <param name="signerFirstNameField"></param>
        /// <param name="signerLastNameField"></param>
        /// <param name="signerMobileField"></param>
        public PreloadedFaceToFaceSigners(int countryIdField = default(int),
            List<UserField> fieldsListField = default(List<UserField>),
            IDType iDTypeField = default(IDType),
            string iDentificationNumberField = default(string),
            PhotoAtSigning? photoAtSigningField = null,
            int sendCompletedEmailField = default(int),
            int sendOTPField = default(int),
            string signerEmailField = default(string),
            string signerFirstNameField = default(string),
            string signerLastNameField = default(string),
            string signerMobileField = default(string))
        {
            this.CountryIDField = countryIdField;
            this.FieldsListField = fieldsListField;
            this.IDTypeField = iDTypeField;
            this.IdentificationNumberField = iDentificationNumberField;
            this.PhotoAtSigningField = photoAtSigningField;
            this.SendCompletedEmailField = sendCompletedEmailField;
            this.SendOTPField = sendOTPField;
            this.SignerEmailField = signerEmailField;
            this.SignerFirstNameField = signerFirstNameField;
            this.SignerLastNameField = signerLastNameField;
            this.SignerMobileField = signerMobileField;
        }
        
        /// <summary>
        /// Country ID Field
        /// </summary>
        [DataMember(Name = "CountryIDField", EmitDefaultValue = false)]
        public int CountryIDField { get; set; }
        
        /// <summary>
        /// List of WorkFlow Fields For Participant
        /// </summary>
        [DataMember(Name = "FieldsListField", EmitDefaultValue = false)]
        public List<UserField> FieldsListField { get; set; }
        
        /// <summary>
        /// ID type
        /// </summary>
        [DataMember(Name = "IDTypeField", EmitDefaultValue = false)]
        public IDType IDTypeField { get; set; }
        
        /// <summary>
        /// Identification number
        /// </summary>
        [DataMember(Name = "IdentificationNumberField", EmitDefaultValue = false)]
        public string IdentificationNumberField { get; set; }
        
        /// <summary>
        /// Photo at signing option
        /// </summary>
        [DataMember(Name = "PhotoAtSigningField", EmitDefaultValue = false)]
        public PhotoAtSigning? PhotoAtSigningField { get; set; }
        
        /// <summary>
        /// Sned Completed Email
        /// </summary>
        [DataMember(Name = "SendCompletedEmailField", EmitDefaultValue = false)]
        public int SendCompletedEmailField { get; set; }
        
        /// <summary>
        /// Sen OTP when Signing
        /// </summary>
        [DataMember(Name = "SendOTPField", EmitDefaultValue = false)]
        public int SendOTPField { get; set; }
        
        /// <summary>
        /// Signer Email
        /// </summary>
        [DataMember(Name = "SignerEmailField", EmitDefaultValue = false)]
        public string SignerEmailField { get; set; }
        
        /// <summary>
        /// Signer First Name
        /// </summary>
        [DataMember(Name = "SignerFirstNameField", EmitDefaultValue = false)]
        public string SignerFirstNameField { get; set; }
        
        /// <summary>
        /// Signer Last Name
        /// </summary>
        [DataMember(Name = "SignerLastNameField", EmitDefaultValue = false)]
        public string SignerLastNameField { get; set; }
        
        /// <summary>
        /// Signer Mobile Number
        /// </summary>
        [DataMember(Name = "SignerMobileField", EmitDefaultValue = false)]
        public string SignerMobileField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreloadedFaceToFaceSigners {\n");
            sb.Append("  CountryIDField: ").Append(CountryIDField).Append("\n");
            sb.Append("  FieldsListField: ").Append(FieldsListField).Append("\n");
            sb.Append("  IDTypeField: ").Append(IDTypeField).Append("\n");
            sb.Append("  IDentificationNumberField: ").Append(IdentificationNumberField).Append("\n");
            sb.Append("  PhotoAtSigningField: ").Append(PhotoAtSigningField).Append("\n");
            sb.Append("  SendCompletedEmailField: ").Append(SendCompletedEmailField).Append("\n");
            sb.Append("  SendOTPField: ").Append(SendOTPField).Append("\n");
            sb.Append("  SignerEmailField: ").Append(SignerEmailField).Append("\n");
            sb.Append("  SignerFirstNameField: ").Append(SignerFirstNameField).Append("\n");
            sb.Append("  SignerLastNameField: ").Append(SignerLastNameField).Append("\n");
            sb.Append("  SignerMobileField: ").Append(SignerMobileField).Append("\n");
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
        public override bool Equals(object obj) => this.Equals(obj as PreloadedFaceToFaceSigners);
        
        /// <summary>
        /// Returns true if PreloadedFaceToFaceSigners instances are equal
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(PreloadedFaceToFaceSigners other)
        {
            if (other == null)
                return false;

            return
                (
                    this.CountryIDField == other.CountryIDField
                ) &&
                (
                    this.FieldsListField == other.FieldsListField ||
                    (this.FieldsListField != null && this.FieldsListField.SequenceEqual(other.FieldsListField))
                ) &&
                (
                    this.IDTypeField == other.IDTypeField
                ) &&
                (
                    this.IdentificationNumberField == other.IdentificationNumberField ||
                    (this.IdentificationNumberField != null && this.IdentificationNumberField.Equals(other.IdentificationNumberField))
                ) &&
                (
                    this.PhotoAtSigningField == other.PhotoAtSigningField
                ) &&
                (
                    this.SendCompletedEmailField == other.SendCompletedEmailField
                ) &&
                (
                    this.SendOTPField == other.SendOTPField
                ) &&
                (
                    this.SignerEmailField == other.SignerEmailField ||
                    (this.SignerEmailField != null && this.SignerEmailField.Equals(other.SignerEmailField))
                ) &&
                (
                    this.SignerFirstNameField == other.SignerFirstNameField ||
                    (this.SignerFirstNameField != null && this.SignerFirstNameField.Equals(other.SignerFirstNameField))
                ) &&
                (
                    this.SignerLastNameField == other.SignerLastNameField ||
                    (this.SignerLastNameField != null && this.SignerLastNameField.Equals(other.SignerLastNameField))
                ) &&
                (
                    this.SignerMobileField == other.SignerMobileField ||
                    (this.SignerMobileField != null && this.SignerMobileField.Equals(other.SignerMobileField))
                );
                
        }

        /// <summary>
        /// Returns the hash code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.CountryIDField.GetHashCode();
                if (this.FieldsListField != null)
                    hashCode = hashCode * 59 + this.FieldsListField.GetHashCode();
                hashCode = hashCode * 59 + this.IDTypeField.GetHashCode();
                if (this.IdentificationNumberField != null)
                    hashCode = hashCode * 59 + this.IdentificationNumberField.GetHashCode();
                hashCode = hashCode * 59 + this.PhotoAtSigningField.GetHashCode();
                hashCode = hashCode * 59 + this.SendCompletedEmailField.GetHashCode();
                hashCode = hashCode * 59 + this.SendOTPField.GetHashCode();
                if (this.SignerEmailField != null)
                    hashCode = hashCode * 59 + this.SignerEmailField.GetHashCode();
                if (this.SignerFirstNameField != null)
                    hashCode = hashCode * 59 + this.SignerFirstNameField.GetHashCode();
                if (this.SignerLastNameField != null)
                    hashCode = hashCode * 59 + this.SignerLastNameField.GetHashCode();
                if (this.SignerMobileField != null)
                    hashCode = hashCode * 59 + this.SignerMobileField.GetHashCode();
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
    
    public enum IDType
    {
        NationalID = 0,
        Passport,
    }
}