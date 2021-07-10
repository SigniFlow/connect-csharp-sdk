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
    /// #### A request sent to add advanced fields to a document.
    /// </summary>
    [DataContract(Name = "DocPrepperAddAdvancedFieldsRequest")]
    public partial class DocPrepperAddAdvancedFieldsRequest : IEquatable<DocPrepperAddAdvancedFieldsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocPrepperAddAdvancedFieldsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocPrepperAddAdvancedFieldsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocPrepperAddAdvancedFieldsRequest" /> class.
        /// </summary>
        /// <param name="fieldInfoListField">Field information list field. (required).</param>
        /// <param name="tokenField">tokenField (required).</param>
        public DocPrepperAddAdvancedFieldsRequest(List<DocPrepperAddAdvancedFieldsRequestFieldInfoListField> fieldInfoListField = default(List<DocPrepperAddAdvancedFieldsRequestFieldInfoListField>), TokenField tokenField = default(TokenField))
        {
            // to ensure "fieldInfoListField" is required (not null)
            this.FieldInfoListField = fieldInfoListField ?? throw new ArgumentNullException("fieldInfoListField is a required property for DocPrepperAddAdvancedFieldsRequest and cannot be null");
            // to ensure "tokenField" is required (not null)
            this.TokenField = tokenField ?? throw new ArgumentNullException("tokenField is a required property for DocPrepperAddAdvancedFieldsRequest and cannot be null");
        }

        /// <summary>
        /// Field information list field.
        /// </summary>
        /// <value>Field information list field.</value>
        [DataMember(Name = "FieldInfoListField", IsRequired = true, EmitDefaultValue = false)]
        public List<DocPrepperAddAdvancedFieldsRequestFieldInfoListField> FieldInfoListField { get; set; }

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
            sb.Append("class DocPrepperAddAdvancedFieldsRequest {\n");
            sb.Append("  FieldInfoListField: ").Append(FieldInfoListField).Append("\n");
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
            return this.Equals(input as DocPrepperAddAdvancedFieldsRequest);
        }

        /// <summary>
        /// Returns true if DocPrepperAddAdvancedFieldsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DocPrepperAddAdvancedFieldsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocPrepperAddAdvancedFieldsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldInfoListField == input.FieldInfoListField ||
                    this.FieldInfoListField != null &&
                    input.FieldInfoListField != null &&
                    this.FieldInfoListField.SequenceEqual(input.FieldInfoListField)
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
                if (this.FieldInfoListField != null)
                    hashCode = hashCode * 59 + this.FieldInfoListField.GetHashCode();
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
