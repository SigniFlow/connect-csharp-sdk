# SigniFlow.Connect.Model.WorkflowSignRequest
#### This request is sent when a document workflow needs to be signed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocIDField** | **string** | Document ID | 
**LatitudeField** | **string** | The current GPS lattitude location where the signing is taking place from.  Needs to be paired with the longitude Field. | 
**LoginPasswordField** | **string** | User password. | 
**LoginUserNameField** | **string** | User&#39;s username. | 
**LongitudeField** | **string** | The current GPS longitude location where the signing is taking place from.  Needs to be paired with the lattitude field. | 
**SignReasonField** | **string** | Reason for signature. | 
**TimeZoneOffsetField** | **decimal** | The user&#39;s timezone offste. | 
**TokenField** | [**TokenField**](TokenField.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

