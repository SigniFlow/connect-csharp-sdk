# SigniFlow.Connect.Model.FullWorkflowRequest
#### Request a fullworkflow of a document. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalDataField** | **string** | Additional data. | [optional] 
**AutoRemindField** | **AutoRemind** |  | 
**AutoExpireField** | **AutoExpire** |  | 
**CustomMessageField** | **string** | Custom message. | [optional] 
**DocField** | **string** | Document field. | 
**DocNameField** | **string** | Document name. | 
**DueDateField** | **DateTime?** | Document due date. | [optional] 
**ExtensionField** | **DocExtension** |  | 
**FlattenDocumentField** | **bool?** | Flatten document. | [optional] 
**KeepContentSecurityField** | **bool?** | Keep content security. | [optional] 
**KeepCustomPropertiesField** | **bool?** | Keep custom properties. | [optional] 
**KeepXMPMetadataField** | **bool?** | Keep XMP meta data. | [optional] 
**PortfolioInformationField** | [**FullWorkflowRequestPortfolioInformationField**](FullWorkflowRequestPortfolioInformationField.md) |  | [optional] 
**PriorityField** | **Priority** |  | [optional] 
**SLAField** | **decimal** | This field has been deprecated, the default value is 0. | [optional] 
**SendFirstEmailField** | **bool** | Confirm first user email notification will or will not be sent. | 
**SendWorkflowEmailsField** | **bool** | Confirm that workflow emails will or will not be sent. | 
**TokenField** | [**TokenField**](TokenField.md) |  | 
**WorkflowUsersListField** | [**List&lt;FullWorkflowRequestWorkflowUsersListField&gt;**](FullWorkflowRequestWorkflowUsersListField.md) | List of users in the workflow. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

