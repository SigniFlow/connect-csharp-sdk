# SigniFlow.Connect.Model.FullWorkflowRequestWorkflowUsersListField

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActionField** | **ActionField** |  | 
**AllowProxyField** | **ProxyAllowedField** |  | 
**AutoSignField** | **bool** | ### Enable auto sign.  &#x60;True &#x3D; Signature will be applied automaticly False &#x3D; User will need to login and Sign&#x60;  | 
**EmailAddressField** | **string** | Workflow user&#39;s email addresses. | 
**GroupStepField** | [**FullWorkflowRequestGroupStepField**](FullWorkflowRequestGroupStepField.md) |  | [optional] 
**LanguageCodeField** | **string** | #### Sets the display language for the user ##### ISO 2 Digit Code  &#x60;en &#x3D; English es &#x3D; Spanish fr &#x3D; French&#x60;  | 
**LatitudeField** | **string** | The current GPS lattitude location where the signing is taking place from. Needs to be paired with the longitude field. | [optional] 
**LongitudeField** | **string** | The current GPS longitudelocation where the signing is taking place from. Needs to be paired with the lattitude field. | [optional] 
**MobileNumberField** | **string** | Group user&#39;s mobile number. | 
**PreloadedFaceToFaceSignersField** | **List&lt;Object&gt;** | Preloaded user&#39;s who will be using the face to face signature field. | [optional] 
**SignReasonField** | **string** | Reason for signature. | [optional] 
**SignerPasswordField** | **string** | Face to face user&#39;s password. | [optional] 
**UserFirstNameField** | **string** | Face to face user&#39;s first name. | 
**UserFullNameField** | **string** | Face to face user&#39;s full name. | 
**UserLastNameField** | **string** | Face to face user&#39;s last name. | 
**WorkflowUserFieldsField** | [**List&lt;FullWorkflowRequestWorkflowUserFieldsField&gt;**](FullWorkflowRequestWorkflowUserFieldsField.md) | The list of the workflowed documents field. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

