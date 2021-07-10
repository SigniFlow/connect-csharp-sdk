# SigniFlow.Connect.Api.AuditsApi

All URIs are relative to *https://server-url/API/SignFlowAPIServiceRest.svc*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostGetAuditDocument**](AuditsApi.md#postgetauditdocument) | **POST** /GetAuditDocument | Get Audit Document
[**PostGetDocumentAudit**](AuditsApi.md#postgetdocumentaudit) | **POST** /GetDocumentAudit | Get Document Audit


<a name="postgetauditdocument"></a>
# **PostGetAuditDocument**
> GetAuditDocumentResponse PostGetAuditDocument (string contentType, GetAuditDocumentRequest getAuditDocumentRequest = null)

Get Audit Document

#### Used to get an audit document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostGetAuditDocumentExample
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
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuditsApi.PostGetAuditDocument: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | [default to &quot;application/json&quot;]
 **getAuditDocumentRequest** | [**GetAuditDocumentRequest**](GetAuditDocumentRequest.md)| ##### Get Audit Document Request Model | [optional] 

### Return type

[**GetAuditDocumentResponse**](GetAuditDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Get Audit Document Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgetdocumentaudit"></a>
# **PostGetDocumentAudit**
> GetDocumentAuditResponse PostGetDocumentAudit (string contentType, GetDocumentAuditRequest getDocumentAuditRequest = null)

Get Document Audit

#### Used to get the audit information from a document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostGetDocumentAuditExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://server-url/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new AuditsApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var getDocumentAuditRequest = new GetDocumentAuditRequest(); // GetDocumentAuditRequest | ##### Get Document Audit Request Model (optional) 

            try
            {
                // Get Document Audit
                GetDocumentAuditResponse result = apiInstance.PostGetDocumentAudit(contentType, getDocumentAuditRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuditsApi.PostGetDocumentAudit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | [default to &quot;application/json&quot;]
 **getDocumentAuditRequest** | [**GetDocumentAuditRequest**](GetDocumentAuditRequest.md)| ##### Get Document Audit Request Model | [optional] 

### Return type

[**GetDocumentAuditResponse**](GetDocumentAuditResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Get Document Audit Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

