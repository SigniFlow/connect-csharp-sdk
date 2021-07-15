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
    /// #### The response returned when a user wants to download a portfolio.
    /// </summary>
    [DataContract(Name = "DownloadPortfolioResponse")]
    public partial class DownloadPortfolioResponse : IEquatable<DownloadPortfolioResponse>, IValidatableObject
    {
//    
//    
//        /// <summary>
//        /// Initializes a new instance of the <see cref="DownloadPortfolioResponse" /> class.
//        /// </summary>
//        [JsonConstructorAttribute]
//        
//        protected DownloadPortfolioResponse() { }
//        
//        
//    
//    
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadPortfolioResponse" /> class.
        /// </summary>
        /// <param name="portfolioDataField">The portfolio document as a base64 encoded string. (required).</param>
        /// <param name="portfolioIDField">Portfolio ID. (required).</param>
        /// <param name="portfolioNameField">Portfolio name. (required).</param>
        /// <param name="resultField">Displays the result of the call. (required).</param>
        public DownloadPortfolioResponse(string portfolioDataField = default(string), decimal portfolioIDField = default(decimal), string portfolioNameField = default(string), string resultField = default(string))
        {
            // to ensure "portfolioDataField" is required (not null)
            this.PortfolioDataField = portfolioDataField ?? throw new ArgumentNullException("portfolioDataField is a required property for DownloadPortfolioResponse and cannot be null");
            this.PortfolioIDField = portfolioIDField;
            // to ensure "portfolioNameField" is required (not null)
            this.PortfolioNameField = portfolioNameField ?? throw new ArgumentNullException("portfolioNameField is a required property for DownloadPortfolioResponse and cannot be null");
            // to ensure "resultField" is required (not null)
            this.ResultField = resultField ?? throw new ArgumentNullException("resultField is a required property for DownloadPortfolioResponse and cannot be null");
        }

        /// <summary>
        /// The portfolio document as a base64 encoded string.
        /// </summary>
        /// <value>The portfolio document as a base64 encoded string.</value>
        [DataMember(Name = "PortfolioDataField", IsRequired = true, EmitDefaultValue = true)]
        public string PortfolioDataField { get; set; }

        /// <summary>
        /// Portfolio ID.
        /// </summary>
        /// <value>Portfolio ID.</value>
        [DataMember(Name = "PortfolioIDField", IsRequired = true, EmitDefaultValue = true)]
        public decimal PortfolioIDField { get; set; }

        /// <summary>
        /// Portfolio name.
        /// </summary>
        /// <value>Portfolio name.</value>
        [DataMember(Name = "PortfolioNameField", IsRequired = true, EmitDefaultValue = true)]
        public string PortfolioNameField { get; set; }

        /// <summary>
        /// Displays the result of the call.
        /// </summary>
        /// <value>Displays the result of the call.</value>
        [DataMember(Name = "ResultField", IsRequired = true, EmitDefaultValue = true)]
        public string ResultField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadPortfolioResponse {\n");
            sb.Append("  PortfolioDataField: ").Append(PortfolioDataField).Append("\n");
            sb.Append("  PortfolioIDField: ").Append(PortfolioIDField).Append("\n");
            sb.Append("  PortfolioNameField: ").Append(PortfolioNameField).Append("\n");
            sb.Append("  ResultField: ").Append(ResultField).Append("\n");
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
            return this.Equals(input as DownloadPortfolioResponse);
        }

        /// <summary>
        /// Returns true if DownloadPortfolioResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DownloadPortfolioResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DownloadPortfolioResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PortfolioDataField == input.PortfolioDataField ||
                    (this.PortfolioDataField != null &&
                    this.PortfolioDataField.Equals(input.PortfolioDataField))
                ) && 
                (
                    this.PortfolioIDField == input.PortfolioIDField ||
                    this.PortfolioIDField.Equals(input.PortfolioIDField)
                ) && 
                (
                    this.PortfolioNameField == input.PortfolioNameField ||
                    (this.PortfolioNameField != null &&
                    this.PortfolioNameField.Equals(input.PortfolioNameField))
                ) && 
                (
                    this.ResultField == input.ResultField ||
                    (this.ResultField != null &&
                    this.ResultField.Equals(input.ResultField))
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
                if (this.PortfolioDataField != null)
                    hashCode = hashCode * 59 + this.PortfolioDataField.GetHashCode();
                hashCode = hashCode * 59 + this.PortfolioIDField.GetHashCode();
                if (this.PortfolioNameField != null)
                    hashCode = hashCode * 59 + this.PortfolioNameField.GetHashCode();
                if (this.ResultField != null)
                    hashCode = hashCode * 59 + this.ResultField.GetHashCode();
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
            // PortfolioDataField (string) minLength
            if(this.PortfolioDataField != null && this.PortfolioDataField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PortfolioDataField, length must be greater than 1.", new [] { "PortfolioDataField" });
            }

            // PortfolioNameField (string) minLength
            if(this.PortfolioNameField != null && this.PortfolioNameField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PortfolioNameField, length must be greater than 1.", new [] { "PortfolioNameField" });
            }

            // ResultField (string) minLength
            if(this.ResultField != null && this.ResultField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResultField, length must be greater than 1.", new [] { "ResultField" });
            }

            yield break;
        }
    }

}
