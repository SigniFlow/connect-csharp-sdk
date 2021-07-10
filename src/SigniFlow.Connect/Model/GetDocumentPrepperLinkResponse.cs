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
    /// #### This is the response returned when requesting a document prepper url.
    /// </summary>
    [DataContract(Name = "GetDocumentPrepperLinkResponse")]
    public partial class GetDocumentPrepperLinkResponse : IEquatable<GetDocumentPrepperLinkResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentPrepperLinkResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetDocumentPrepperLinkResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentPrepperLinkResponse" /> class.
        /// </summary>
        /// <param name="result">Displays the result of the call. (required).</param>
        /// <param name="uRL">Url (required).</param>
        public GetDocumentPrepperLinkResponse(string result = default(string), string uRL = default(string))
        {
            // to ensure "result" is required (not null)
            this.Result = result ?? throw new ArgumentNullException("result is a required property for GetDocumentPrepperLinkResponse and cannot be null");
            // to ensure "uRL" is required (not null)
            this.URL = uRL ?? throw new ArgumentNullException("uRL is a required property for GetDocumentPrepperLinkResponse and cannot be null");
        }

        /// <summary>
        /// Displays the result of the call.
        /// </summary>
        /// <value>Displays the result of the call.</value>
        [DataMember(Name = "Result", IsRequired = true, EmitDefaultValue = false)]
        public string Result { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        /// <value>Url</value>
        [DataMember(Name = "URL", IsRequired = true, EmitDefaultValue = false)]
        public string URL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDocumentPrepperLinkResponse {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  URL: ").Append(URL).Append("\n");
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
            return this.Equals(input as GetDocumentPrepperLinkResponse);
        }

        /// <summary>
        /// Returns true if GetDocumentPrepperLinkResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDocumentPrepperLinkResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocumentPrepperLinkResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.URL == input.URL ||
                    (this.URL != null &&
                    this.URL.Equals(input.URL))
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
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.URL != null)
                    hashCode = hashCode * 59 + this.URL.GetHashCode();
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
            // Result (string) minLength
            if(this.Result != null && this.Result.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Result, length must be greater than 1.", new [] { "Result" });
            }

            // URL (string) minLength
            if(this.URL != null && this.URL.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for URL, length must be greater than 1.", new [] { "URL" });
            }

            yield break;
        }
    }

}
