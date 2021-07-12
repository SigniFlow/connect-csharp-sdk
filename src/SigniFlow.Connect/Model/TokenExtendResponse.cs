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
    /// #### The response returned when requesting the extention of the period of which the toekn is valid.
    /// </summary>
    [DataContract(Name = "TokenExtendResponse")]
    public partial class TokenExtendResponse : IEquatable<TokenExtendResponse>, IValidatableObject
    {
//    
//    
//        /// <summary>
//        /// Initializes a new instance of the <see cref="TokenExtendResponse" /> class.
//        /// </summary>
//        [JsonConstructorAttribute]
//        
//        protected TokenExtendResponse() { }
//        
//        
//    
//    
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenExtendResponse" /> class.
        /// </summary>
        /// <param name="resultField">Displays the result of the call. (required).</param>
        /// <param name="tokenField">tokenField (required).</param>
        public TokenExtendResponse(string resultField = default(string), TokenField tokenField = default(TokenField))
        {
            // to ensure "resultField" is required (not null)
            this.ResultField = resultField ?? throw new ArgumentNullException("resultField is a required property for TokenExtendResponse and cannot be null");
            // to ensure "tokenField" is required (not null)
            this.TokenField = tokenField ?? throw new ArgumentNullException("tokenField is a required property for TokenExtendResponse and cannot be null");
        }

        /// <summary>
        /// Displays the result of the call.
        /// </summary>
        /// <value>Displays the result of the call.</value>
        [DataMember(Name = "ResultField", IsRequired = true, EmitDefaultValue = false)]
        public string ResultField { get; set; }

        /// <summary>
        /// Gets or Sets TokenField
        /// </summary>
        [DataMember(Name = "TokenField", IsRequired = true, EmitDefaultValue = false)]
        public TokenField TokenField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenExtendResponse {\n");
            sb.Append("  ResultField: ").Append(ResultField).Append("\n");
            sb.Append("  TokenField: ").Append(TokenField).Append("\n");
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
            return this.Equals(input as TokenExtendResponse);
        }

        /// <summary>
        /// Returns true if TokenExtendResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenExtendResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenExtendResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResultField == input.ResultField ||
                    (this.ResultField != null &&
                    this.ResultField.Equals(input.ResultField))
                ) && 
                (
                    this.TokenField == input.TokenField ||
                    (this.TokenField != null &&
                    this.TokenField.Equals(input.TokenField))
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
                if (this.ResultField != null)
                    hashCode = hashCode * 59 + this.ResultField.GetHashCode();
                if (this.TokenField != null)
                    hashCode = hashCode * 59 + this.TokenField.GetHashCode();
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
            // ResultField (string) minLength
            if(this.ResultField != null && this.ResultField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResultField, length must be greater than 1.", new [] { "ResultField" });
            }

            yield break;
        }
    }

}
