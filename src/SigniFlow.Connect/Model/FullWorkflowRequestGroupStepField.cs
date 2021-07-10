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
    /// Steps of the group signers in the workflow.
    /// </summary>
    [DataContract(Name = "FullWorkflowRequest_GroupStepField")]
    public partial class FullWorkflowRequestGroupStepField : IEquatable<FullWorkflowRequestGroupStepField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FullWorkflowRequestGroupStepField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FullWorkflowRequestGroupStepField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FullWorkflowRequestGroupStepField" /> class.
        /// </summary>
        /// <param name="groupMembersField">The list of users in a group in the workflow. (required).</param>
        /// <param name="groupNameField">Group name. (required).</param>
        /// <param name="requiredNumberOfSignaturesField">Required number of signatures in the group. (required).</param>
        public FullWorkflowRequestGroupStepField(List<FullWorkflowRequestGroupStepFieldGroupMembersField> groupMembersField = default(List<FullWorkflowRequestGroupStepFieldGroupMembersField>), string groupNameField = default(string), decimal requiredNumberOfSignaturesField = default(decimal))
        {
            // to ensure "groupMembersField" is required (not null)
            this.GroupMembersField = groupMembersField ?? throw new ArgumentNullException("groupMembersField is a required property for FullWorkflowRequestGroupStepField and cannot be null");
            // to ensure "groupNameField" is required (not null)
            this.GroupNameField = groupNameField ?? throw new ArgumentNullException("groupNameField is a required property for FullWorkflowRequestGroupStepField and cannot be null");
            this.RequiredNumberOfSignaturesField = requiredNumberOfSignaturesField;
        }

        /// <summary>
        /// The list of users in a group in the workflow.
        /// </summary>
        /// <value>The list of users in a group in the workflow.</value>
        [DataMember(Name = "GroupMembersField", IsRequired = true, EmitDefaultValue = false)]
        public List<FullWorkflowRequestGroupStepFieldGroupMembersField> GroupMembersField { get; set; }

        /// <summary>
        /// Group name.
        /// </summary>
        /// <value>Group name.</value>
        [DataMember(Name = "GroupNameField", IsRequired = true, EmitDefaultValue = false)]
        public string GroupNameField { get; set; }

        /// <summary>
        /// Required number of signatures in the group.
        /// </summary>
        /// <value>Required number of signatures in the group.</value>
        [DataMember(Name = "RequiredNumberOfSignaturesField", IsRequired = true, EmitDefaultValue = false)]
        public decimal RequiredNumberOfSignaturesField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullWorkflowRequestGroupStepField {\n");
            sb.Append("  GroupMembersField: ").Append(GroupMembersField).Append("\n");
            sb.Append("  GroupNameField: ").Append(GroupNameField).Append("\n");
            sb.Append("  RequiredNumberOfSignaturesField: ").Append(RequiredNumberOfSignaturesField).Append("\n");
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
            return this.Equals(input as FullWorkflowRequestGroupStepField);
        }

        /// <summary>
        /// Returns true if FullWorkflowRequestGroupStepField instances are equal
        /// </summary>
        /// <param name="input">Instance of FullWorkflowRequestGroupStepField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FullWorkflowRequestGroupStepField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupMembersField == input.GroupMembersField ||
                    this.GroupMembersField != null &&
                    input.GroupMembersField != null &&
                    this.GroupMembersField.SequenceEqual(input.GroupMembersField)
                ) && 
                (
                    this.GroupNameField == input.GroupNameField ||
                    (this.GroupNameField != null &&
                    this.GroupNameField.Equals(input.GroupNameField))
                ) && 
                (
                    this.RequiredNumberOfSignaturesField == input.RequiredNumberOfSignaturesField ||
                    this.RequiredNumberOfSignaturesField.Equals(input.RequiredNumberOfSignaturesField)
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
                if (this.GroupMembersField != null)
                    hashCode = hashCode * 59 + this.GroupMembersField.GetHashCode();
                if (this.GroupNameField != null)
                    hashCode = hashCode * 59 + this.GroupNameField.GetHashCode();
                hashCode = hashCode * 59 + this.RequiredNumberOfSignaturesField.GetHashCode();
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
            // GroupNameField (string) minLength
            if(this.GroupNameField != null && this.GroupNameField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GroupNameField, length must be greater than 1.", new [] { "GroupNameField" });
            }

            yield break;
        }
    }

}
