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
    /// #### The request sent when a user Logs in.
    /// </summary>
    [DataContract(Name = "LoginRequest")]
    public partial class LoginRequest : IEquatable<LoginRequest>, IValidatableObject
    {
//    
//    
//        /// <summary>
//        /// Initializes a new instance of the <see cref="LoginRequest" /> class.
//        /// </summary>
//        [JsonConstructorAttribute]
//        
//        protected LoginRequest() { }
//        
//        
//    
//    
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginRequest" /> class.
        /// </summary>
        /// <param name="userNameField">Email address of the user generating a Token (required).</param>
        /// <param name="passwordField">SigniFlow user password (required).</param>
        public LoginRequest(string userNameField = default(string), string passwordField = default(string))
        {
            // to ensure "userNameField" is required (not null)
            this.UserNameField = userNameField ?? throw new ArgumentNullException("userNameField is a required property for LoginRequest and cannot be null");
            // to ensure "passwordField" is required (not null)
            this.PasswordField = passwordField ?? throw new ArgumentNullException("passwordField is a required property for LoginRequest and cannot be null");
        }

        /// <summary>
        /// Email address of the user generating a Token
        /// </summary>
        /// <value>Email address of the user generating a Token</value>
        [DataMember(Name = "UserNameField", IsRequired = true, EmitDefaultValue = true)]
        public string UserNameField { get; set; }

        /// <summary>
        /// SigniFlow user password
        /// </summary>
        /// <value>SigniFlow user password</value>
        [DataMember(Name = "PasswordField", IsRequired = true, EmitDefaultValue = true)]
        public string PasswordField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginRequest {\n");
            sb.Append("  UserNameField: ").Append(UserNameField).Append("\n");
            sb.Append("  PasswordField: ").Append(PasswordField).Append("\n");
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
            return this.Equals(input as LoginRequest);
        }

        /// <summary>
        /// Returns true if LoginRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LoginRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoginRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserNameField == input.UserNameField ||
                    (this.UserNameField != null &&
                    this.UserNameField.Equals(input.UserNameField))
                ) && 
                (
                    this.PasswordField == input.PasswordField ||
                    (this.PasswordField != null &&
                    this.PasswordField.Equals(input.PasswordField))
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
                if (this.UserNameField != null)
                    hashCode = hashCode * 59 + this.UserNameField.GetHashCode();
                if (this.PasswordField != null)
                    hashCode = hashCode * 59 + this.PasswordField.GetHashCode();
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
            // UserNameField (string) minLength
            if(this.UserNameField != null && this.UserNameField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserNameField, length must be greater than 1.", new [] { "UserNameField" });
            }

            // PasswordField (string) minLength
            if(this.PasswordField != null && this.PasswordField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PasswordField, length must be greater than 1.", new [] { "PasswordField" });
            }

            yield break;
        }
    }

}
