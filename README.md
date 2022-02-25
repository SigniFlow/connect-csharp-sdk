![SigniFlow Logo]
---

[![Build status](https://ci.appveyor.com/api/projects/status/7pwdgm3vwl1pd04f?svg=true)](https://ci.appveyor.com/project/SigniFlow/connect-csharp-sdk)
[![Build status](https://ci.appveyor.com/api/projects/status/7pwdgm3vwl1pd04f/branch/main?svg=true)](https://ci.appveyor.com/project/SigniFlow/connect-csharp-sdk/branch/main)
[![NuGet version](https://badge.fury.io/nu/SigniFlow.Connect.svg)](https://badge.fury.io/nu/SigniFlow.Connect)
[![Apache-2 license](https://img.shields.io/badge/license-Apache2-brightgreen.svg)](https://www.apache.org/licenses/LICENSE-2.0)

# SigniFlow.Connect - the C# library for the WorkFlow API

## SigniFlow API used to automate esignature workflow creation and management.


This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0
- SDK version: 1.0.30
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://www.signiflow.com/contact](https://www.signiflow.com/contact)

## Frameworks supported
- .NET Standard 2.0


## Usage
### **Option 1: Obtain from [NuGet package manager](https://www.nuget.org/packages/SigniFlow.Connect/) (Recommended)**
```
PM> Install-Package SigniFlow.Connect
```

### **Option 2: Generating DLLs from source**

#### Dependencies
- [RestSharp] (https://www.nuget.org/packages/RestSharp) - 106.3.1 or later
- [Json.NET] (https://www.nuget.org/packages/Newtonsoft.Json/) - 11.0.2 or later

Option 1: Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Option 2: Import the `SigniFlow.Connect/SigniFlow.Connect.csproj` to your solution and build from VS

Then include the DLLs (under the `bin` folder) in the C# project,

- SigniFlow.Connect.dll

## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://server-url/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new AuditsApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var getAuditDocumentRequest = new GetAuditDocumentRequest(); // GetAuditDocumentRequest | ##### Get Audit Document Request Model (optional) 

            try
            {
                // Get Audit Document
                GetAuditDocumentResponse result = apiInstance.PostGetAuditDocument(contentType, getAuditDocumentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuditsApi.PostGetAuditDocument: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://server-url/API/SignFlowAPIServiceRest.svc*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuditsApi* | [**PostGetAuditDocument**](docs/AuditsApi.md#postgetauditdocument) | **POST** /GetAuditDocument | Get Audit Document
*AuditsApi* | [**PostGetDocumentAudit**](docs/AuditsApi.md#postgetdocumentaudit) | **POST** /GetDocumentAudit | Get Document Audit
*AuthenticationApi* | [**Login**](docs/AuthenticationApi.md#login) | **POST** /Login | Login
*AuthenticationApi* | [**PostLogout**](docs/AuthenticationApi.md#postlogout) | **POST** /Logout | Logout
*AuthenticationApi* | [**PostTokenExtend**](docs/AuthenticationApi.md#posttokenextend) | **POST** /TokenExtend | Token Extend
*AuthenticationApi* | [**PostTokenValidate**](docs/AuthenticationApi.md#posttokenvalidate) | **POST** /TokenValidate | Token Validate
*PortfoliosApi* | [**PostCreatePortfolio**](docs/PortfoliosApi.md#postcreateportfolio) | **POST** /CreatePortfolio | Create Portfolio
*PortfoliosApi* | [**PostDownloadPortfolio**](docs/PortfoliosApi.md#postdownloadportfolio) | **POST** /DownloadPortfolio | Download Portfolio
*PortfoliosApi* | [**PostLinkToPortfolio**](docs/PortfoliosApi.md#postlinktoportfolio) | **POST** /LinkToPortfolio | Link To Portfolio
*PortfoliosApi* | [**PostSetDocumentOrder**](docs/PortfoliosApi.md#postsetdocumentorder) | **POST** /SetDocumentOrder | Set Document Order
*PortfoliosApi* | [**PostSharePortfolio**](docs/PortfoliosApi.md#postshareportfolio) | **POST** /SharePortfolio | Share Portfolio
*PortfoliosApi* | [**PostSharePortfolioNoEmail**](docs/PortfoliosApi.md#postshareportfolionoemail) | **POST** /SharePortfolio_No_Email | Share Portfolio No Email
*SigningCeremonyApi* | [**PostMultipleSignersSigningCeremony**](docs/SigningCeremonyApi.md#postmultiplesignerssigningceremony) | **POST** /MultipleSignersSigningCeremony | Multiple Signers Signing Ceremony
*SigningCeremonyApi* | [**PostSigningCeremonyV2**](docs/SigningCeremonyApi.md#postsigningceremonyv2) | **POST** /SigningCeremonyV2 | Signing Ceremony V2
*TemplatesApi* | [**PostApplyPrepperTemplate**](docs/TemplatesApi.md#postapplypreppertemplate) | **POST** /ApplyPrepperTemplate | Apply a Prepper template
*TemplatesApi* | [**PostGetDocumentTagFieldBoxPosition**](docs/TemplatesApi.md#postgetdocumenttagfieldboxposition) | **POST** /GetDocumentTagFieldBoxPosition | Get Document Tag Field Box Position
*TemplatesApi* | [**PostGetDocumentTagFieldPosition**](docs/TemplatesApi.md#postgetdocumenttagfieldposition) | **POST** /GetDocumentTagFieldPosition | Get Document Tag Field Position
*TemplatesApi* | [**PostGetPrepperTemplate**](docs/TemplatesApi.md#postgetpreppertemplate) | **POST** /GetPrepperTemplate | Get Prepper Template
*TemplatesApi* | [**PostGetPrepperTemplateList**](docs/TemplatesApi.md#postgetpreppertemplatelist) | **POST** /GetPrepperTemplateList | Get Prepper Template List
*ViewersApi* | [**PostGetDocLink**](docs/ViewersApi.md#postgetdoclink) | **POST** /GetDocLink | Get Document Link
*ViewersApi* | [**PostGetDocumentPrepperLink**](docs/ViewersApi.md#postgetdocumentprepperlink) | **POST** /GetDocumentPrepperLink | Get Document Prepper Link
*WorkFlowApi* | [**CreateWorkflow**](docs/WorkFlowApi.md#createworkflow) | **POST** /CreateWorkflow | Create Workflow
*WorkFlowApi* | [**GetDocument**](docs/WorkFlowApi.md#getdocument) | **POST** /GetDoc | Get Document
*WorkFlowApi* | [**PostAddWorkflowStep**](docs/WorkFlowApi.md#postaddworkflowstep) | **POST** /AddWorkflowStepV2 | Add a Workflow step
*WorkFlowApi* | [**PostCancelFlow**](docs/WorkFlowApi.md#postcancelflow) | **POST** /CancelFlow | Cancel Flow
*WorkFlowApi* | [**PostDeleteDoc**](docs/WorkFlowApi.md#postdeletedoc) | **POST** /DeleteDoc | Delete Document
*WorkFlowApi* | [**PostDocPrepperAddField**](docs/WorkFlowApi.md#postdocprepperaddfield) | **POST** /DocPrepperAddFieldsFlowID | Document Prepper Add Fields
*WorkFlowApi* | [**PostDocPrepperAdvancedFields**](docs/WorkFlowApi.md#postdocprepperadvancedfields) | **POST** /DocPrepperAdvancedFields | Document Prepper Add Advanced Fields
*WorkFlowApi* | [**PostFullWorkflow**](docs/WorkFlowApi.md#postfullworkflow) | **POST** /FullWorkflow | FullWorkflow
*WorkFlowApi* | [**PostGetDocStatus**](docs/WorkFlowApi.md#postgetdocstatus) | **POST** /GetDocStatus | Get Document Status
*WorkFlowApi* | [**PostInitiateFlow**](docs/WorkFlowApi.md#postinitiateflow) | **POST** /InitiateFlow | Initiate Flow
*WorkFlowApi* | [**PostInitiateFlowNoEmail**](docs/WorkFlowApi.md#postinitiateflownoemail) | **POST** /InitiateFlow_No_Email | Initiate Flow No Email
*WorkFlowApi* | [**PostInitiateFlowNoInitialEmail**](docs/WorkFlowApi.md#postinitiateflownoinitialemail) | **POST** /InitiateFlow_No_Initial_Email | Initiate Flow No Initial Email
*WorkFlowApi* | [**PostWorkflowSign**](docs/WorkFlowApi.md#postworkflowsign) | **POST** /WorkflowSign | Workflow Sign


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccessLevelField](docs/AccessLevelField.md)
 - [Model.ActionField](docs/ActionField.md)
 - [Model.AddWokflowStepV2Response](docs/AddWokflowStepV2Response.md)
 - [Model.AddWokflowStepV2ResponseFlowStepsField](docs/AddWokflowStepV2ResponseFlowStepsField.md)
 - [Model.AddWorkflowStepV2Request](docs/AddWorkflowStepV2Request.md)
 - [Model.AdvancedFieldType](docs/AdvancedFieldType.md)
 - [Model.ApplyPrepperTemplateRequest](docs/ApplyPrepperTemplateRequest.md)
 - [Model.ApplyPrepperTemplateResponse](docs/ApplyPrepperTemplateResponse.md)
 - [Model.AutoExpire](docs/AutoExpire.md)
 - [Model.AutoRemind](docs/AutoRemind.md)
 - [Model.CancelFlowRequest](docs/CancelFlowRequest.md)
 - [Model.CancelFlowResponse](docs/CancelFlowResponse.md)
 - [Model.CreatePortfolioRequest](docs/CreatePortfolioRequest.md)
 - [Model.CreatePortfolioResponse](docs/CreatePortfolioResponse.md)
 - [Model.CreateWorkflowRequest](docs/CreateWorkflowRequest.md)
 - [Model.CreateWorkflowResponse](docs/CreateWorkflowResponse.md)
 - [Model.DeleteDocRequest](docs/DeleteDocRequest.md)
 - [Model.DeleteDocResponse](docs/DeleteDocResponse.md)
 - [Model.DocExtension](docs/DocExtension.md)
 - [Model.DocPrepperAddAdvancedFieldsRequest](docs/DocPrepperAddAdvancedFieldsRequest.md)
 - [Model.DocPrepperAddAdvancedFieldsRequestFieldInfoListField](docs/DocPrepperAddAdvancedFieldsRequestFieldInfoListField.md)
 - [Model.DocPrepperAddAdvancedFieldsRequestFieldOptionsListField](docs/DocPrepperAddAdvancedFieldsRequestFieldOptionsListField.md)
 - [Model.DocPrepperAddAdvancedFieldsResponse](docs/DocPrepperAddAdvancedFieldsResponse.md)
 - [Model.DocPrepperAddAdvancedFieldsResponseAdvancedFieldResponseListField](docs/DocPrepperAddAdvancedFieldsResponseAdvancedFieldResponseListField.md)
 - [Model.DocPrepperAddFieldsFlowIDRequest](docs/DocPrepperAddFieldsFlowIDRequest.md)
 - [Model.DocPrepperAddFieldsFlowIDResponse](docs/DocPrepperAddFieldsFlowIDResponse.md)
 - [Model.DownloadPortfolioRequest](docs/DownloadPortfolioRequest.md)
 - [Model.DownloadPortfolioResponse](docs/DownloadPortfolioResponse.md)
 - [Model.FieldType](docs/FieldType.md)
 - [Model.FullWorkflowRequest](docs/FullWorkflowRequest.md)
 - [Model.FullWorkflowRequestGroupStepField](docs/FullWorkflowRequestGroupStepField.md)
 - [Model.FullWorkflowRequestGroupStepFieldGroupMembersField](docs/FullWorkflowRequestGroupStepFieldGroupMembersField.md)
 - [Model.FullWorkflowRequestPortfolioInformationField](docs/FullWorkflowRequestPortfolioInformationField.md)
 - [Model.FullWorkflowRequestWorkflowUserFieldsField](docs/FullWorkflowRequestWorkflowUserFieldsField.md)
 - [Model.FullWorkflowRequestWorkflowUsersListField](docs/FullWorkflowRequestWorkflowUsersListField.md)
 - [Model.FullWorkflowResponse](docs/FullWorkflowResponse.md)
 - [Model.GetAuditDocumentRequest](docs/GetAuditDocumentRequest.md)
 - [Model.GetAuditDocumentResponse](docs/GetAuditDocumentResponse.md)
 - [Model.GetDocLinkRequest](docs/GetDocLinkRequest.md)
 - [Model.GetDocLinkResponse](docs/GetDocLinkResponse.md)
 - [Model.GetDocStatusRequest](docs/GetDocStatusRequest.md)
 - [Model.GetDocStatusResponse](docs/GetDocStatusResponse.md)
 - [Model.GetDocumentAuditRequest](docs/GetDocumentAuditRequest.md)
 - [Model.GetDocumentAuditResponse](docs/GetDocumentAuditResponse.md)
 - [Model.GetDocumentAuditResponseActivityField](docs/GetDocumentAuditResponseActivityField.md)
 - [Model.GetDocumentPrepperLinkRequest](docs/GetDocumentPrepperLinkRequest.md)
 - [Model.GetDocumentPrepperLinkResponse](docs/GetDocumentPrepperLinkResponse.md)
 - [Model.GetDocumentRequest](docs/GetDocumentRequest.md)
 - [Model.GetDocumentResponse](docs/GetDocumentResponse.md)
 - [Model.GetDocumentTagFieldBoxPositionRequest](docs/GetDocumentTagFieldBoxPositionRequest.md)
 - [Model.GetDocumentTagFieldBoxPositionResponse](docs/GetDocumentTagFieldBoxPositionResponse.md)
 - [Model.GetDocumentTagFieldBoxPositionResponseDocumentTagFieldsBoxPositionField](docs/GetDocumentTagFieldBoxPositionResponseDocumentTagFieldsBoxPositionField.md)
 - [Model.GetDocumentTagFieldPositionRequest](docs/GetDocumentTagFieldPositionRequest.md)
 - [Model.GetDocumentTagFieldPositionResponse](docs/GetDocumentTagFieldPositionResponse.md)
 - [Model.GetDocumentTagFieldPositionResponseDocumentTagFieldsPositionField](docs/GetDocumentTagFieldPositionResponseDocumentTagFieldsPositionField.md)
 - [Model.GetPrepperTemplateListRequest](docs/GetPrepperTemplateListRequest.md)
 - [Model.GetPrepperTemplateListResponse](docs/GetPrepperTemplateListResponse.md)
 - [Model.GetPrepperTemplateListResponseTemplateInformationValuesField](docs/GetPrepperTemplateListResponseTemplateInformationValuesField.md)
 - [Model.GetPrepperTemplateRequest](docs/GetPrepperTemplateRequest.md)
 - [Model.GetPrepperTemplateResponse](docs/GetPrepperTemplateResponse.md)
 - [Model.GetPrepperTemplateResponsePrepperTemplateValuesField](docs/GetPrepperTemplateResponsePrepperTemplateValuesField.md)
 - [Model.InitiateFlowNoEmailRequest](docs/InitiateFlowNoEmailRequest.md)
 - [Model.InitiateFlowNoEmailResponse](docs/InitiateFlowNoEmailResponse.md)
 - [Model.InitiateFlowNoInitialEmailRequest](docs/InitiateFlowNoInitialEmailRequest.md)
 - [Model.InitiateFlowNoInitialEmailResponse](docs/InitiateFlowNoInitialEmailResponse.md)
 - [Model.InitiateFlowRequest](docs/InitiateFlowRequest.md)
 - [Model.InitiateFlowResponse](docs/InitiateFlowResponse.md)
 - [Model.LinkToPortfolioRequest](docs/LinkToPortfolioRequest.md)
 - [Model.LinkToPortfolioResponse](docs/LinkToPortfolioResponse.md)
 - [Model.LoginRequest](docs/LoginRequest.md)
 - [Model.LoginResponse](docs/LoginResponse.md)
 - [Model.LogoutRequest](docs/LogoutRequest.md)
 - [Model.LogoutResponse](docs/LogoutResponse.md)
 - [Model.MultipleSignersSigningCeremonyRequest](docs/MultipleSignersSigningCeremonyRequest.md)
 - [Model.MultipleSignersSigningCeremonyRequestSignerListField](docs/MultipleSignersSigningCeremonyRequestSignerListField.md)
 - [Model.MultipleSignersSigningCeremonyResponse](docs/MultipleSignersSigningCeremonyResponse.md)
 - [Model.Priority](docs/Priority.md)
 - [Model.ProxyAllowedField](docs/ProxyAllowedField.md)
 - [Model.SetDocumentOrderRequest](docs/SetDocumentOrderRequest.md)
 - [Model.SetDocumentOrderResponse](docs/SetDocumentOrderResponse.md)
 - [Model.ShareOptionField](docs/ShareOptionField.md)
 - [Model.SharePortfolioNoEmailRequest](docs/SharePortfolioNoEmailRequest.md)
 - [Model.SharePortfolioNoEmailResponse](docs/SharePortfolioNoEmailResponse.md)
 - [Model.SharePortfolioRequest](docs/SharePortfolioRequest.md)
 - [Model.SharePortfolioResponse](docs/SharePortfolioResponse.md)
 - [Model.SigningCeremonyV2Request](docs/SigningCeremonyV2Request.md)
 - [Model.SigningCeremonyV2RequestCheckboxFieldsListField](docs/SigningCeremonyV2RequestCheckboxFieldsListField.md)
 - [Model.SigningCeremonyV2RequestInitialFieldsListField](docs/SigningCeremonyV2RequestInitialFieldsListField.md)
 - [Model.SigningCeremonyV2RequestTextFieldsListField](docs/SigningCeremonyV2RequestTextFieldsListField.md)
 - [Model.SigningCeremonyV2Response](docs/SigningCeremonyV2Response.md)
 - [Model.TokenExtendRequest](docs/TokenExtendRequest.md)
 - [Model.TokenExtendResponse](docs/TokenExtendResponse.md)
 - [Model.TokenField](docs/TokenField.md)
 - [Model.TokenValidateRequest](docs/TokenValidateRequest.md)
 - [Model.TokenValidateResponse](docs/TokenValidateResponse.md)
 - [Model.WorkflowSignRequest](docs/WorkflowSignRequest.md)
 - [Model.WorkflowSignResponse](docs/WorkflowSignResponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.

## Contributing

Send bug reports, feature requests, and code contributions to the [API
specifications repository](https://github.com/SigniFlow/OpenAPI-Specifications),
as this repository contains only the generated SDK code.

## License

```
Copyright 2021 SigniFlow, Inc.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
```

[//]: # "Link anchor definitions"
[SigniFlow Logo]: https://www.signiflow.com/wp-content/uploads/2020/12/WEB-GENERIC-LOGO-REGISTERED-1024x256-1-300x75.png
