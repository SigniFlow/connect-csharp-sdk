/*
 * WorkFlow API
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
    /// Portfolio information.
    /// </summary>
    [DataContract(Name = "FullWorkflowRequest_PortfolioInformationField")]
    public partial class FullWorkflowRequestPortfolioInformationField : IEquatable<FullWorkflowRequestPortfolioInformationField>, IValidatableObject
    {
//    
//    
//        /// <summary>
//        /// Initializes a new instance of the <see cref="FullWorkflowRequestPortfolioInformationField" /> class.
//        /// </summary>
//        [JsonConstructorAttribute]
//        
//        protected FullWorkflowRequestPortfolioInformationField() { }
//        
//        
//    
//    
        /// <summary>
        /// Initializes a new instance of the <see cref="FullWorkflowRequestPortfolioInformationField" /> class.
        /// </summary>
        /// <param name="createPortfolioField">Create a new portfolio. (required).</param>
        /// <param name="linkToPortfolioField">Link document to Portfolio link. (required).</param>
        /// <param name="portfolioIDField">Portfolio ID..</param>
        /// <param name="portfolioNameField">Portfolio name..</param>
        public FullWorkflowRequestPortfolioInformationField(bool createPortfolioField = default(bool), bool linkToPortfolioField = default(bool), decimal? portfolioIDField = default(decimal?), string portfolioNameField = default(string))
        {
            this.CreatePortfolioField = createPortfolioField;
            this.LinkToPortfolioField = linkToPortfolioField;
            this.PortfolioIDField = portfolioIDField;
            this.PortfolioNameField = portfolioNameField;
        }

        /// <summary>
        /// Create a new portfolio.
        /// </summary>
        /// <value>Create a new portfolio.</value>
        [DataMember(Name = "CreatePortfolioField", IsRequired = true, EmitDefaultValue = true)]
        public bool CreatePortfolioField { get; set; }

        /// <summary>
        /// Link document to Portfolio link.
        /// </summary>
        /// <value>Link document to Portfolio link.</value>
        [DataMember(Name = "LinkToPortfolioField", IsRequired = true, EmitDefaultValue = true)]
        public bool LinkToPortfolioField { get; set; }

        /// <summary>
        /// Portfolio ID.
        /// </summary>
        /// <value>Portfolio ID.</value>
        [DataMember(Name = "PortfolioIDField", EmitDefaultValue = true)]
        public decimal? PortfolioIDField { get; set; }

        /// <summary>
        /// Portfolio name.
        /// </summary>
        /// <value>Portfolio name.</value>
        [DataMember(Name = "PortfolioNameField", EmitDefaultValue = true)]
        public string PortfolioNameField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullWorkflowRequestPortfolioInformationField {\n");
            sb.Append("  CreatePortfolioField: ").Append(CreatePortfolioField).Append("\n");
            sb.Append("  LinkToPortfolioField: ").Append(LinkToPortfolioField).Append("\n");
            sb.Append("  PortfolioIDField: ").Append(PortfolioIDField).Append("\n");
            sb.Append("  PortfolioNameField: ").Append(PortfolioNameField).Append("\n");
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
            return this.Equals(input as FullWorkflowRequestPortfolioInformationField);
        }

        /// <summary>
        /// Returns true if FullWorkflowRequestPortfolioInformationField instances are equal
        /// </summary>
        /// <param name="input">Instance of FullWorkflowRequestPortfolioInformationField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FullWorkflowRequestPortfolioInformationField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatePortfolioField == input.CreatePortfolioField ||
                    this.CreatePortfolioField.Equals(input.CreatePortfolioField)
                ) && 
                (
                    this.LinkToPortfolioField == input.LinkToPortfolioField ||
                    this.LinkToPortfolioField.Equals(input.LinkToPortfolioField)
                ) && 
                (
                    this.PortfolioIDField == input.PortfolioIDField ||
                    (this.PortfolioIDField != null &&
                    this.PortfolioIDField.Equals(input.PortfolioIDField))
                ) && 
                (
                    this.PortfolioNameField == input.PortfolioNameField ||
                    (this.PortfolioNameField != null &&
                    this.PortfolioNameField.Equals(input.PortfolioNameField))
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
                hashCode = hashCode * 59 + this.CreatePortfolioField.GetHashCode();
                hashCode = hashCode * 59 + this.LinkToPortfolioField.GetHashCode();
                if (this.PortfolioIDField != null)
                    hashCode = hashCode * 59 + this.PortfolioIDField.GetHashCode();
                if (this.PortfolioNameField != null)
                    hashCode = hashCode * 59 + this.PortfolioNameField.GetHashCode();
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
            // PortfolioNameField (string) minLength
            if(this.PortfolioNameField != null && this.PortfolioNameField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PortfolioNameField, length must be greater than 1.", new [] { "PortfolioNameField" });
            }

            yield break;
        }
    }

}
