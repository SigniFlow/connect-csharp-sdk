# SigniFlow.Connect.Model.CreateWorkflowRequest
#### The request sent to create a document workflow.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalDataField** | **string** | Sets additional data to be embedded in PDF Meta. | [optional] 
**AutoExpireField** | **AutoExpire** |  | [optional] 
**AutoRemindField** | **AutoRemind** |  | 
**DocField** | **string** | Base64 Encoded String of document | 
**DocNameField** | **string** | Name of document to display in SigniFlow | 
**DueDateField** | **DateTime?** | Due date for the document, use in conjunction with Auto Expire. | [optional] 
**ExtensionField** | **DocExtension** |  | 
**MessageField** | **string** | Custom message to display to participants | [optional] 
**PriorityField** | **Priority** |  | 
**SLAField** | **int** | Deprecated field, Pass 0 | [optional] [default to 0]
**TokenField** | [**TokenField**](TokenField.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

