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
    /// #### The response received after a portfolio is created.
    /// </summary>
    [DataContract(Name = "CreatePortfolioResponse")]
    public partial class CreatePortfolioResponse : IEquatable<CreatePortfolioResponse>, IValidatableObject
    {
//    
//    
//        /// <summary>
//        /// Initializes a new instance of the <see cref="CreatePortfolioResponse" /> class.
//        /// </summary>
//        [JsonConstructorAttribute]
//        
//        protected CreatePortfolioResponse() { }
//        
//        
//    
//    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePortfolioResponse" /> class.
        /// </summary>
        /// <param name="portfolioIDField">Document portfolio ID field. (required).</param>
        /// <param name="resultField">Displays the result of the call. (required).</param>
        public CreatePortfolioResponse(decimal portfolioIDField = default(decimal), string resultField = default(string))
        {
            this.PortfolioIDField = portfolioIDField;
            // to ensure "resultField" is required (not null)
            this.ResultField = resultField ?? throw new ArgumentNullException("resultField is a required property for CreatePortfolioResponse and cannot be null");
        }

        /// <summary>
        /// Document portfolio ID field.
        /// </summary>
        /// <value>Document portfolio ID field.</value>
        [DataMember(Name = "PortfolioIDField", IsRequired = true, EmitDefaultValue = true)]
        public decimal PortfolioIDField { get; set; }

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
            sb.Append("class CreatePortfolioResponse {\n");
            sb.Append("  PortfolioIDField: ").Append(PortfolioIDField).Append("\n");
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
            return this.Equals(input as CreatePortfolioResponse);
        }

        /// <summary>
        /// Returns true if CreatePortfolioResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePortfolioResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePortfolioResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PortfolioIDField == input.PortfolioIDField ||
                    this.PortfolioIDField.Equals(input.PortfolioIDField)
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
                hashCode = hashCode * 59 + this.PortfolioIDField.GetHashCode();
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
            // ResultField (string) minLength
            if(this.ResultField != null && this.ResultField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResultField, length must be greater than 1.", new [] { "ResultField" });
            }

            yield break;
        }
    }

}
