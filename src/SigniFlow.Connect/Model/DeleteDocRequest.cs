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
    /// #### This is the request used to delete a document.
    /// </summary>
    [DataContract(Name = "DeleteDocRequest")]
    public partial class DeleteDocRequest : IEquatable<DeleteDocRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDocRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteDocRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDocRequest" /> class.
        /// </summary>
        /// <param name="docIDField">Document ID field. (required).</param>
        /// <param name="tokenField">tokenField (required).</param>
        public DeleteDocRequest(decimal docIDField = default(decimal), TokenField tokenField = default(TokenField))
        {
            this.DocIDField = docIDField;
            // to ensure "tokenField" is required (not null)
            this.TokenField = tokenField ?? throw new ArgumentNullException("tokenField is a required property for DeleteDocRequest and cannot be null");
        }

        /// <summary>
        /// Document ID field.
        /// </summary>
        /// <value>Document ID field.</value>
        [DataMember(Name = "DocIDField", IsRequired = true, EmitDefaultValue = false)]
        public decimal DocIDField { get; set; }

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
            sb.Append("class DeleteDocRequest {\n");
            sb.Append("  DocIDField: ").Append(DocIDField).Append("\n");
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
            return this.Equals(input as DeleteDocRequest);
        }

        /// <summary>
        /// Returns true if DeleteDocRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteDocRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteDocRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocIDField == input.DocIDField ||
                    this.DocIDField.Equals(input.DocIDField)
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
                hashCode = hashCode * 59 + this.DocIDField.GetHashCode();
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
            yield break;
        }
    }

}
