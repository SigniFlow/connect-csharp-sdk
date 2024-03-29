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
    /// #### Request a fullworkflow of a document. 
    /// </summary>
    [DataContract(Name = "FullWorkflowRequest")]
    public partial class FullWorkflowRequest : IEquatable<FullWorkflowRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AutoRemindField
        /// </summary>
        [DataMember(Name = "AutoRemindField", IsRequired = true, EmitDefaultValue = true)]
        public AutoRemind AutoRemindField { get; set; }
        /// <summary>
        /// Gets or Sets AutoExpireField
        /// </summary>
        [DataMember(Name = "AutoExpireField", IsRequired = true, EmitDefaultValue = true)]
        public AutoExpire AutoExpireField { get; set; }
        /// <summary>
        /// Gets or Sets ExtensionField
        /// </summary>
        [DataMember(Name = "ExtensionField", IsRequired = true, EmitDefaultValue = true)]
        public DocExtension ExtensionField { get; set; }
        /// <summary>
        /// Gets or Sets PriorityField
        /// </summary>
        [DataMember(Name = "PriorityField", EmitDefaultValue = true)]
        public Priority? PriorityField { get; set; }
        //    
        //    
        //        /// <summary>
        //        /// Initializes a new instance of the <see cref="FullWorkflowRequest" /> class.
        //        /// </summary>
        //        [JsonConstructorAttribute]
        //        
        //        protected FullWorkflowRequest() { }
        //        
        //        
        //    
        //    
        /// <summary>
        /// Initializes a new instance of the <see cref="FullWorkflowRequest" /> class.
        /// </summary>
        /// <param name="additionalDataField">Additional data..</param>
        /// <param name="autoRemindField">autoRemindField (required).</param>
        /// <param name="customMessageField">Custom message..</param>
        /// <param name="docField">Document field. (required).</param>
        /// <param name="docNameField">Document name. (required).</param>
        /// <param name="dueDateField">Document due date..</param>
        /// <param name="extensionField">extensionField (required).</param>
        /// <param name="flattenDocumentField">Flatten document..</param>
        /// <param name="keepContentSecurityField">Keep content security..</param>
        /// <param name="keepCustomPropertiesField">Keep custom properties..</param>
        /// <param name="keepXMPMetadataField">Keep XMP meta data..</param>
        /// <param name="portfolioInformationField">portfolioInformationField.</param>
        /// <param name="priorityField">priorityField.</param>
        /// <param name="sLAField">This field has been deprecated, the default value is 0..</param>
        /// <param name="sendFirstEmailField">Confirm first user email notification will or will not be sent. (required).</param>
        /// <param name="sendWorkflowEmailsField">Confirm that workflow emails will or will not be sent. (required).</param>
        /// <param name="tokenField">tokenField (required).</param>
        /// <param name="workflowUsersListField">List of users in the workflow. (required).</param>
        /// <param name="autoExpireField">autoExpireField (required).</param>
        public FullWorkflowRequest(string additionalDataField = default(string), AutoRemind autoRemindField = default(AutoRemind), 
            string customMessageField = default(string), string docField = default(string), string docNameField = default(string), 
            DateTime? dueDateField = default(DateTime?), DocExtension extensionField = default(DocExtension), 
            bool? flattenDocumentField = default(bool?), bool? keepContentSecurityField = default(bool?), 
            bool? keepCustomPropertiesField = default(bool?), bool? keepXMPMetadataField = default(bool?), 
            FullWorkflowRequestPortfolioInformationField portfolioInformationField = default(FullWorkflowRequestPortfolioInformationField), 
            Priority? priorityField = default(Priority?), decimal sLAField = default(decimal), bool sendFirstEmailField = default(bool), 
            bool sendWorkflowEmailsField = default(bool), TokenField tokenField = default(TokenField), 
            List<FullWorkflowRequestWorkflowUsersListField> workflowUsersListField = default(List<FullWorkflowRequestWorkflowUsersListField>),
            AutoExpire autoExpireField = default(AutoExpire))
        {
            this.AutoRemindField = autoRemindField;
            // to ensure "docField" is required (not null)
            this.DocField = docField ?? throw new ArgumentNullException("docField is a required property for FullWorkflowRequest and cannot be null");
            // to ensure "docNameField" is required (not null)
            this.DocNameField = docNameField ?? throw new ArgumentNullException("docNameField is a required property for FullWorkflowRequest and cannot be null");
            this.ExtensionField = extensionField;
            this.SendFirstEmailField = sendFirstEmailField;
            this.SendWorkflowEmailsField = sendWorkflowEmailsField;
            // to ensure "tokenField" is required (not null)
            this.TokenField = tokenField ?? throw new ArgumentNullException("tokenField is a required property for FullWorkflowRequest and cannot be null");
            // to ensure "workflowUsersListField" is required (not null)
            this.WorkflowUsersListField = workflowUsersListField ?? throw new ArgumentNullException("workflowUsersListField is a required property for FullWorkflowRequest and cannot be null");
            this.AdditionalDataField = additionalDataField;
            this.CustomMessageField = customMessageField;
            this.DueDateField = dueDateField;
            this.FlattenDocumentField = flattenDocumentField;
            this.KeepContentSecurityField = keepContentSecurityField;
            this.KeepCustomPropertiesField = keepCustomPropertiesField;
            this.KeepXMPMetadataField = keepXMPMetadataField;
            this.PortfolioInformationField = portfolioInformationField;
            this.PriorityField = priorityField;
            this.SLAField = sLAField;
            this.AutoExpireField = autoExpireField;
        }

        /// <summary>
        /// Additional data.
        /// </summary>
        /// <value>Additional data.</value>
        [DataMember(Name = "AdditionalDataField", EmitDefaultValue = true)]
        public string AdditionalDataField { get; set; }

        /// <summary>
        /// Custom message.
        /// </summary>
        /// <value>Custom message.</value>
        [DataMember(Name = "CustomMessageField", EmitDefaultValue = true)]
        public string CustomMessageField { get; set; }

        /// <summary>
        /// Document field.
        /// </summary>
        /// <value>Document field.</value>
        [DataMember(Name = "DocField", IsRequired = true, EmitDefaultValue = true)]
        public string DocField { get; set; }

        /// <summary>
        /// Document name.
        /// </summary>
        /// <value>Document name.</value>
        [DataMember(Name = "DocNameField", IsRequired = true, EmitDefaultValue = true)]
        public string DocNameField { get; set; }

        /// <summary>
        /// Document due date.
        /// </summary>
        /// <value>Document due date.</value>
        [DataMember(Name = "DueDateField", EmitDefaultValue = true)]
        //[JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? DueDateField { get; set; }

        /// <summary>
        /// Flatten document.
        /// </summary>
        /// <value>Flatten document.</value>
        [DataMember(Name = "FlattenDocumentField", EmitDefaultValue = true)]
        public bool? FlattenDocumentField { get; set; }

        /// <summary>
        /// Keep content security.
        /// </summary>
        /// <value>Keep content security.</value>
        [DataMember(Name = "KeepContentSecurityField", EmitDefaultValue = true)]
        public bool? KeepContentSecurityField { get; set; }

        /// <summary>
        /// Keep custom properties.
        /// </summary>
        /// <value>Keep custom properties.</value>
        [DataMember(Name = "KeepCustomPropertiesField", EmitDefaultValue = true)]
        public bool? KeepCustomPropertiesField { get; set; }

        /// <summary>
        /// Keep XMP meta data.
        /// </summary>
        /// <value>Keep XMP meta data.</value>
        [DataMember(Name = "KeepXMPMetadataField", EmitDefaultValue = true)]
        public bool? KeepXMPMetadataField { get; set; }

        /// <summary>
        /// Gets or Sets PortfolioInformationField
        /// </summary>
        [DataMember(Name = "PortfolioInformationField", EmitDefaultValue = true)]
        public FullWorkflowRequestPortfolioInformationField PortfolioInformationField { get; set; }

        /// <summary>
        /// This field has been deprecated, the default value is 0.
        /// </summary>
        /// <value>This field has been deprecated, the default value is 0.</value>
        [DataMember(Name = "SLAField", EmitDefaultValue = true)]
        public decimal SLAField { get; set; }

        /// <summary>
        /// Confirm first user email notification will or will not be sent.
        /// </summary>
        /// <value>Confirm first user email notification will or will not be sent.</value>
        [DataMember(Name = "SendFirstEmailField", IsRequired = true, EmitDefaultValue = true)]
        public bool SendFirstEmailField { get; set; }

        /// <summary>
        /// Confirm that workflow emails will or will not be sent.
        /// </summary>
        /// <value>Confirm that workflow emails will or will not be sent.</value>
        [DataMember(Name = "SendWorkflowEmailsField", IsRequired = true, EmitDefaultValue = true)]
        public bool SendWorkflowEmailsField { get; set; }

        /// <summary>
        /// Gets or Sets TokenField
        /// </summary>
        [DataMember(Name = "TokenField", IsRequired = true, EmitDefaultValue = true)]
        public TokenField TokenField { get; set; }

        /// <summary>
        /// List of users in the workflow.
        /// </summary>
        /// <value>List of users in the workflow.</value>
        [DataMember(Name = "WorkflowUsersListField", IsRequired = true, EmitDefaultValue = true)]
        public List<FullWorkflowRequestWorkflowUsersListField> WorkflowUsersListField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullWorkflowRequest {\n");
            sb.Append("  AdditionalDataField: ").Append(AdditionalDataField).Append("\n");
            sb.Append("  AutoRemindField: ").Append(AutoRemindField).Append("\n");           
            sb.Append("  CustomMessageField: ").Append(CustomMessageField).Append("\n");
            sb.Append("  DocField: ").Append(DocField).Append("\n");
            sb.Append("  DocNameField: ").Append(DocNameField).Append("\n");
            sb.Append("  DueDateField: ").Append(DueDateField).Append("\n");
            sb.Append("  ExtensionField: ").Append(ExtensionField).Append("\n");
            sb.Append("  FlattenDocumentField: ").Append(FlattenDocumentField).Append("\n");
            sb.Append("  KeepContentSecurityField: ").Append(KeepContentSecurityField).Append("\n");
            sb.Append("  KeepCustomPropertiesField: ").Append(KeepCustomPropertiesField).Append("\n");
            sb.Append("  KeepXMPMetadataField: ").Append(KeepXMPMetadataField).Append("\n");
            sb.Append("  PortfolioInformationField: ").Append(PortfolioInformationField).Append("\n");
            sb.Append("  PriorityField: ").Append(PriorityField).Append("\n");
            sb.Append("  SLAField: ").Append(SLAField).Append("\n");
            sb.Append("  SendFirstEmailField: ").Append(SendFirstEmailField).Append("\n");
            sb.Append("  SendWorkflowEmailsField: ").Append(SendWorkflowEmailsField).Append("\n");
            sb.Append("  TokenField: ").Append(TokenField).Append("\n");
            sb.Append("  WorkflowUsersListField: ").Append(WorkflowUsersListField).Append("\n");
            sb.Append("  AutoExpireField: ").Append(AutoExpireField).Append("\n");
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
            return this.Equals(input as FullWorkflowRequest);
        }

        /// <summary>
        /// Returns true if FullWorkflowRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FullWorkflowRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FullWorkflowRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalDataField == input.AdditionalDataField ||
                    (this.AdditionalDataField != null &&
                    this.AdditionalDataField.Equals(input.AdditionalDataField))
                ) && 
                (
                    this.AutoRemindField == input.AutoRemindField ||
                    this.AutoRemindField.Equals(input.AutoRemindField)
                ) && 
                (
                    this.CustomMessageField == input.CustomMessageField ||
                    (this.CustomMessageField != null &&
                    this.CustomMessageField.Equals(input.CustomMessageField))
                ) && 
                (
                    this.DocField == input.DocField ||
                    (this.DocField != null &&
                    this.DocField.Equals(input.DocField))
                ) && 
                (
                    this.DocNameField == input.DocNameField ||
                    (this.DocNameField != null &&
                    this.DocNameField.Equals(input.DocNameField))
                ) && 
                (
                    this.DueDateField == input.DueDateField ||
                    (this.DueDateField != null &&
                    this.DueDateField.Equals(input.DueDateField))
                ) && 
                (
                    this.ExtensionField == input.ExtensionField ||
                    this.ExtensionField.Equals(input.ExtensionField)
                ) && 
                (
                    this.FlattenDocumentField == input.FlattenDocumentField ||
                    (this.FlattenDocumentField != null &&
                    this.FlattenDocumentField.Equals(input.FlattenDocumentField))
                ) && 
                (
                    this.KeepContentSecurityField == input.KeepContentSecurityField ||
                    (this.KeepContentSecurityField != null &&
                    this.KeepContentSecurityField.Equals(input.KeepContentSecurityField))
                ) && 
                (
                    this.KeepCustomPropertiesField == input.KeepCustomPropertiesField ||
                    (this.KeepCustomPropertiesField != null &&
                    this.KeepCustomPropertiesField.Equals(input.KeepCustomPropertiesField))
                ) && 
                (
                    this.KeepXMPMetadataField == input.KeepXMPMetadataField ||
                    (this.KeepXMPMetadataField != null &&
                    this.KeepXMPMetadataField.Equals(input.KeepXMPMetadataField))
                ) && 
                (
                    this.PortfolioInformationField == input.PortfolioInformationField ||
                    (this.PortfolioInformationField != null &&
                    this.PortfolioInformationField.Equals(input.PortfolioInformationField))
                ) && 
                (
                    this.PriorityField == input.PriorityField ||
                    this.PriorityField.Equals(input.PriorityField)
                ) && 
                (
                    this.SLAField == input.SLAField ||
                    this.SLAField.Equals(input.SLAField)
                ) && 
                (
                    this.SendFirstEmailField == input.SendFirstEmailField ||
                    this.SendFirstEmailField.Equals(input.SendFirstEmailField)
                ) && 
                (
                    this.SendWorkflowEmailsField == input.SendWorkflowEmailsField ||
                    this.SendWorkflowEmailsField.Equals(input.SendWorkflowEmailsField)
                ) && 
                (
                    this.TokenField == input.TokenField ||
                    (this.TokenField != null &&
                    this.TokenField.Equals(input.TokenField))
                ) && 
                (
                    this.WorkflowUsersListField == input.WorkflowUsersListField ||
                    this.WorkflowUsersListField != null &&
                    input.WorkflowUsersListField != null &&
                    this.WorkflowUsersListField.SequenceEqual(input.WorkflowUsersListField)
                ) &&
                (
                    this.AutoExpireField == input.AutoExpireField ||
                    this.AutoExpireField.Equals(input.AutoExpireField)
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
                if (this.AdditionalDataField != null)
                    hashCode = hashCode * 59 + this.AdditionalDataField.GetHashCode();
                hashCode = hashCode * 59 + this.AutoRemindField.GetHashCode();
                if (this.CustomMessageField != null)
                    hashCode = hashCode * 59 + this.CustomMessageField.GetHashCode();
                if (this.DocField != null)
                    hashCode = hashCode * 59 + this.DocField.GetHashCode();
                if (this.DocNameField != null)
                    hashCode = hashCode * 59 + this.DocNameField.GetHashCode();
                if (this.DueDateField != null)
                    hashCode = hashCode * 59 + this.DueDateField.GetHashCode();
                hashCode = hashCode * 59 + this.ExtensionField.GetHashCode();
                if (this.FlattenDocumentField != null)
                    hashCode = hashCode * 59 + this.FlattenDocumentField.GetHashCode();
                if (this.KeepContentSecurityField != null)
                    hashCode = hashCode * 59 + this.KeepContentSecurityField.GetHashCode();
                if (this.KeepCustomPropertiesField != null)
                    hashCode = hashCode * 59 + this.KeepCustomPropertiesField.GetHashCode();
                if (this.KeepXMPMetadataField != null)
                    hashCode = hashCode * 59 + this.KeepXMPMetadataField.GetHashCode();
                if (this.PortfolioInformationField != null)
                    hashCode = hashCode * 59 + this.PortfolioInformationField.GetHashCode();
                hashCode = hashCode * 59 + this.PriorityField.GetHashCode();
                hashCode = hashCode * 59 + this.SLAField.GetHashCode();
                hashCode = hashCode * 59 + this.SendFirstEmailField.GetHashCode();
                hashCode = hashCode * 59 + this.SendWorkflowEmailsField.GetHashCode();
                if (this.TokenField != null)
                    hashCode = hashCode * 59 + this.TokenField.GetHashCode();
                if (this.WorkflowUsersListField != null)
                    hashCode = hashCode * 59 + this.WorkflowUsersListField.GetHashCode();
                hashCode = hashCode * 59 + this.AutoExpireField.GetHashCode();
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
            // DocField (string) minLength
            if(this.DocField != null && this.DocField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DocField, length must be greater than 1.", new [] { "DocField" });
            }

            // DocNameField (string) minLength
            if(this.DocNameField != null && this.DocNameField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DocNameField, length must be greater than 1.", new [] { "DocNameField" });
            }

            // SLAField (decimal) maximum
            if(this.SLAField > (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SLAField, must be a value less than or equal to 0.", new [] { "SLAField" });
            }

            // SLAField (decimal) minimum
            if(this.SLAField < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SLAField, must be a value greater than or equal to 0.", new [] { "SLAField" });
            }

            yield break;
        }
    }

}
