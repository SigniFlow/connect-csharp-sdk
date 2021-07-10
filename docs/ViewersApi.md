# SigniFlow.Connect.Api.ViewersApi

All URIs are relative to *https://server-url/API/SignFlowAPIServiceRest.svc*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostGetDocLink**](ViewersApi.md#postgetdoclink) | **POST** /GetDocLink | Get Document Link
[**PostGetDocumentPrepperLink**](ViewersApi.md#postgetdocumentprepperlink) | **POST** /GetDocumentPrepperLink | Get Document Prepper Link


<a name="postgetdoclink"></a>
# **PostGetDocLink**
> GetDocLinkResponse PostGetDocLink (string contentType, GetDocLinkRequest getDocLinkRequest = null)

Get Document Link

#### Used to get the document link that will be used to sign a document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostGetDocLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://server-url/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new ViewersApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var getDocLinkRequest = new GetDocLinkRequest(); // GetDocLinkRequest | ##### Get Document Link Request Model (optional) 

            try
            {
                // Get Document Link
                GetDocLinkResponse result = apiInstance.PostGetDocLink(contentType, getDocLinkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ViewersApi.PostGetDocLink: " + e.Message );
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
 **getDocLinkRequest** | [**GetDocLinkRequest**](GetDocLinkRequest.md)| ##### Get Document Link Request Model | [optional] 

### Return type

[**GetDocLinkResponse**](GetDocLinkResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Get Document Link Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgetdocumentprepperlink"></a>
# **PostGetDocumentPrepperLink**
> GetDocumentPrepperLinkResponse PostGetDocumentPrepperLink (string contentType, GetDocumentPrepperLinkRequest getDocumentPrepperLinkRequest = null)

Get Document Prepper Link

#### Used to get a document prepper link (url).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostGetDocumentPrepperLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://server-url/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new ViewersApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var getDocumentPrepperLinkRequest = new GetDocumentPrepperLinkRequest(); // GetDocumentPrepperLinkRequest | ##### Get Document Prepper Link Request Model (optional) 

            try
            {
                // Get Document Prepper Link
                GetDocumentPrepperLinkResponse result = apiInstance.PostGetDocumentPrepperLink(contentType, getDocumentPrepperLinkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ViewersApi.PostGetDocumentPrepperLink: " + e.Message );
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
 **getDocumentPrepperLinkRequest** | [**GetDocumentPrepperLinkRequest**](GetDocumentPrepperLinkRequest.md)| ##### Get Document Prepper Link Request Model | [optional] 

### Return type

[**GetDocumentPrepperLinkResponse**](GetDocumentPrepperLinkResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Get Document Prepper Link Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

