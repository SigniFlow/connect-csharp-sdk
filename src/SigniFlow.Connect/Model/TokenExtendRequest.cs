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
    /// #### The request sent to extend the session time by extending the period when the token is valid.
    /// </summary>
    [DataContract(Name = "TokenExtendRequest")]
    public partial class TokenExtendRequest : IEquatable<TokenExtendRequest>, IValidatableObject
    {
//    
//    
//        /// <summary>
//        /// Initializes a new instance of the <see cref="TokenExtendRequest" /> class.
//        /// </summary>
//        [JsonConstructorAttribute]
//        
//        protected TokenExtendRequest() { }
//        
//        
//    
//    
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenExtendRequest" /> class.
        /// </summary>
        /// <param name="tokenField">tokenField (required).</param>
        /// <param name="tokenValidityField">tokenValidityField (required).</param>
        public TokenExtendRequest(TokenField tokenField = default(TokenField), decimal tokenValidityField = default(decimal))
        {
            // to ensure "tokenField" is required (not null)
            this.TokenField = tokenField ?? throw new ArgumentNullException("tokenField is a required property for TokenExtendRequest and cannot be null");
            this.TokenValidityField = tokenValidityField;
        }

        /// <summary>
        /// Gets or Sets TokenField
        /// </summary>
        [DataMember(Name = "TokenField", IsRequired = true, EmitDefaultValue = true)]
        public TokenField TokenField { get; set; }

        /// <summary>
        /// Gets or Sets TokenValidityField
        /// </summary>
        [DataMember(Name = "TokenValidityField", IsRequired = true, EmitDefaultValue = true)]
        public decimal TokenValidityField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenExtendRequest {\n");
            sb.Append("  TokenField: ").Append(TokenField).Append("\n");
            sb.Append("  TokenValidityField: ").Append(TokenValidityField).Append("\n");
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
            return this.Equals(input as TokenExtendRequest);
        }

        /// <summary>
        /// Returns true if TokenExtendRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenExtendRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenExtendRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenField == input.TokenField ||
                    (this.TokenField != null &&
                    this.TokenField.Equals(input.TokenField))
                ) && 
                (
                    this.TokenValidityField == input.TokenValidityField ||
                    this.TokenValidityField.Equals(input.TokenValidityField)
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
                if (this.TokenField != null)
                    hashCode = hashCode * 59 + this.TokenField.GetHashCode();
                hashCode = hashCode * 59 + this.TokenValidityField.GetHashCode();
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
