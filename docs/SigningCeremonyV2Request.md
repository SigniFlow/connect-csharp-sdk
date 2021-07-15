# SigniFlow.Connect.Model.SigningCeremonyV2Request
#### The request sent to start the signing process of a document.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CheckboxFieldsListField** | [**List&lt;SigningCeremonyV2RequestCheckboxFieldsListField&gt;**](SigningCeremonyV2RequestCheckboxFieldsListField.md) | The list of checkbox fields. | 
**DocField** | **string** |  | 
**DocNameField** | **string** | Document name. | 
**InitialFieldsListField** | [**List&lt;SigningCeremonyV2RequestInitialFieldsListField&gt;**](SigningCeremonyV2RequestInitialFieldsListField.md) | The list of initial fields. | 
**LoginPasswordField** | **string** | User password. | 
**LoginUserNameField** | **string** | User&#39;s username. | 
**SignatureHField** | **decimal** | Signature field height. | 
**SignatureImageField** | **string** | Signature field image. | 
**SignatureImageIncludeBorderField** | **bool** | Include signature border. | 
**SignatureImageIncludeReasonField** | **bool** | Include signature reason. | 
**SignatureImageIncludeSignedByField** | **bool** | Include signature signed by information. | 
**SignatureImageIncludeSignedDateField** | **bool** | Include signature date. | 
**SignatureImageTypeField** | **decimal** | Signature image type. | 
**SignaturePageField** | **decimal** | The page on which the signature is on. | 
**SignatureWField** | **decimal** | Signature field width. | 
**SignatureXField** | **decimal** | Signature field x-coordinates. | 
**SignatureYField** | **decimal** | Signature field y-coordinates. | 
**SignerEmailField** | **string** | The signer&#39;s email. | 
**SignerFullNameField** | **string** | The signer&#39;s full name. | 
**SignerIdentificationNumberField** | **string** | The signer&#39;s ID number. | 
**SignerLocationField** | **string** | The signer&#39;s GPS location. | 
**SignerMobileNumberField** | **string** | The signer&#39;s mobile number. | 
**SignerReasonField** | **string** | The signer&#39;s reason for signing. | 
**SignerTrustOriginField** | **string** | This field is used to define the source of the Audit keep by the user calling the Signing Ceremony. | 
**SignerTrustReferenceField** | **string** | A unique identifier that links back to an audit stored by the user calling the Signing Ceremony. | 
**TextFieldsListField** | [**List&lt;SigningCeremonyV2RequestTextFieldsListField&gt;**](SigningCeremonyV2RequestTextFieldsListField.md) | The list of text fields. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

