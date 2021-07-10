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
    /// #### This request gets sent when a session token needs to be validated.
    /// </summary>
    [DataContract(Name = "TokenValidateRequest")]
    public partial class TokenValidateRequest : IEquatable<TokenValidateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenValidateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TokenValidateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenValidateRequest" /> class.
        /// </summary>
        /// <param name="_0">_0 (required).</param>
        public TokenValidateRequest(string _0 = default(string))
        {
            // to ensure "_0" is required (not null)
            this._0 = _0 ?? throw new ArgumentNullException("_0 is a required property for TokenValidateRequest and cannot be null");
        }

        /// <summary>
        /// Gets or Sets _0
        /// </summary>
        [DataMember(Name = "0", IsRequired = true, EmitDefaultValue = false)]
        public string _0 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenValidateRequest {\n");
            sb.Append("  _0: ").Append(_0).Append("\n");
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
            return this.Equals(input as TokenValidateRequest);
        }

        /// <summary>
        /// Returns true if TokenValidateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenValidateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenValidateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._0 == input._0 ||
                    (this._0 != null &&
                    this._0.Equals(input._0))
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
                if (this._0 != null)
                    hashCode = hashCode * 59 + this._0.GetHashCode();
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
            // _0 (string) minLength
            if(this._0 != null && this._0.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for _0, length must be greater than 1.", new [] { "_0" });
            }

            yield break;
        }
    }

}
