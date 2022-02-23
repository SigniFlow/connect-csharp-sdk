
# SigniFlow.Connect.Model.MultipleSignersSigningCeremonyRequestSignerListField

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SignatureHField** | **decimal** | Signature field height. | 
**SignatureImageField** | **string** | Signature image, if signature type is set to 0 then no signature image field is needed. | 
**SignatureImageIncludeBorderField** | **bool** | Signature image with borders | 
**SignatureImageIncludeReasonField** | **bool** | Signature image with a reason. | 
**SignatureImageIncludeSignedByField** | **bool** | Signature image with the signer included. | 
**SignatureImageIncludeSignedDateField** | **bool** | Signature image with signed by date. | 
**SignatureImageTypeField** | **decimal** | Signature image type. | 
**SignaturePageField** | **decimal** | The page where the signature is. | 
**SignatureWField** | **decimal** | Signature field width. | 
**SignatureXField** | **decimal** | Signature field x-coordinates. | 
**SignatureYField** | **decimal** | Signature field y-coordinates. | 
**SignerEmailField** | **string** | Signer email address | 
**SignerFullNameField** | **string** | Signer full name. | 
**SignerIndentificationNumberField** | **string** | Signer ID number. | [optional] 
**SignerLocationField** | **string** | Signer GPS location. | 
**SignerMobileNumberField** | **string** | SIgner mobile number | [optional] 
**SignerReasonField** | **string** | Reason for signature of the signer. This will be required if SignatureImageIncludeReasonField is set to true. | [optional] 
**SignerTrustOriginField** | **string** | This field is used to define the source of the Audit keep by the user calling the Signing Ceremony. | 
**SignerTrustReferenceField** | **string** | A unique identifier that links back to an audit stored by the user calling the Signing Ceremony. | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

