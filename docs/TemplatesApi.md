# SigniFlow.Connect.Api.TemplatesApi

All URIs are relative to *https://server-url/API/SignFlowAPIServiceRest.svc*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostApplyPrepperTemplate**](TemplatesApi.md#postapplypreppertemplate) | **POST** /ApplyPrepperTemplate | Apply a Prepper template
[**PostGetDocumentTagFieldBoxPosition**](TemplatesApi.md#postgetdocumenttagfieldboxposition) | **POST** /GetDocumentTagFieldBoxPosition | Get Document Tag Field Box Position
[**PostGetDocumentTagFieldPosition**](TemplatesApi.md#postgetdocumenttagfieldposition) | **POST** /GetDocumentTagFieldPosition | Get Document Tag Field Position
[**PostGetPrepperTemplate**](TemplatesApi.md#postgetpreppertemplate) | **POST** /GetPrepperTemplate | Get Prepper Template
[**PostGetPrepperTemplateList**](TemplatesApi.md#postgetpreppertemplatelist) | **POST** /GetPrepperTemplateList | Get Prepper Template List


<a name="postapplypreppertemplate"></a>
# **PostApplyPrepperTemplate**
> ApplyPrepperTemplateResponse PostApplyPrepperTemplate (string contentType, ApplyPrepperTemplateRequest applyPrepperTemplateRequest = null)

Apply a Prepper template

#### Used when applying a templaet to a document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostApplyPrepperTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://server-url/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new TemplatesApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var applyPrepperTemplateRequest = new ApplyPrepperTemplateRequest(); // ApplyPrepperTemplateRequest | ##### Apply A Prepper Template Request Model (optional) 

            try
            {
                // Apply a Prepper template
                ApplyPrepperTemplateResponse result = apiInstance.PostApplyPrepperTemplate(contentType, applyPrepperTemplateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.PostApplyPrepperTemplate: " + e.Message );
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
 **applyPrepperTemplateRequest** | [**ApplyPrepperTemplateRequest**](ApplyPrepperTemplateRequest.md)| ##### Apply A Prepper Template Request Model | [optional] 

### Return type

[**ApplyPrepperTemplateResponse**](ApplyPrepperTemplateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Apply A Prepper Template Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgetdocumenttagfieldboxposition"></a>
# **PostGetDocumentTagFieldBoxPosition**
> GetDocumentTagFieldBoxPositionResponse PostGetDocumentTagFieldBoxPosition (string contentType, GetDocumentTagFieldBoxPositionRequest getDocumentTagFieldBoxPositionRequest = null)

Get Document Tag Field Box Position

#### Used to get the tag field box position on a document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostGetDocumentTagFieldBoxPositionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://server-url/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new TemplatesApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var getDocumentTagFieldBoxPositionRequest = new GetDocumentTagFieldBoxPositionRequest(); // GetDocumentTagFieldBoxPositionRequest | ##### Get Document Tag Field Box Position Request Model (optional) 

            try
            {
                // Get Document Tag Field Box Position
                GetDocumentTagFieldBoxPositionResponse result = apiInstance.PostGetDocumentTagFieldBoxPosition(contentType, getDocumentTagFieldBoxPositionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.PostGetDocumentTagFieldBoxPosition: " + e.Message );
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
 **getDocumentTagFieldBoxPositionRequest** | [**GetDocumentTagFieldBoxPositionRequest**](GetDocumentTagFieldBoxPositionRequest.md)| ##### Get Document Tag Field Box Position Request Model | [optional] 

### Return type

[**GetDocumentTagFieldBoxPositionResponse**](GetDocumentTagFieldBoxPositionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Get Document Tag Field Box Position Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgetdocumenttagfieldposition"></a>
# **PostGetDocumentTagFieldPosition**
> GetDocumentTagFieldPositionResponse PostGetDocumentTagFieldPosition (string contentType, GetDocumentTagFieldPositionRequest getDocumentTagFieldPositionRequest = null)

Get Document Tag Field Position

#### Used to get the tag position on a document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostGetDocumentTagFieldPositionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://server-url/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new TemplatesApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var getDocumentTagFieldPositionRequest = new GetDocumentTagFieldPositionRequest(); // GetDocumentTagFieldPositionRequest | ##### Get Document Tag Field Position Request Model (optional) 

            try
            {
                // Get Document Tag Field Position
                GetDocumentTagFieldPositionResponse result = apiInstance.PostGetDocumentTagFieldPosition(contentType, getDocumentTagFieldPositionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.PostGetDocumentTagFieldPosition: " + e.Message );
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
 **getDocumentTagFieldPositionRequest** | [**GetDocumentTagFieldPositionRequest**](GetDocumentTagFieldPositionRequest.md)| ##### Get Document Tag Field Position Request Model | [optional] 

### Return type

[**GetDocumentTagFieldPositionResponse**](GetDocumentTagFieldPositionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Get Document Tag Field Position Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgetpreppertemplate"></a>
# **PostGetPrepperTemplate**
> GetPrepperTemplateResponse PostGetPrepperTemplate (string contentType, GetPrepperTemplateRequest getPrepperTemplateRequest = null)

Get Prepper Template

#### Used to get a document template.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostGetPrepperTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://server-url/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new TemplatesApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var getPrepperTemplateRequest = new GetPrepperTemplateRequest(); // GetPrepperTemplateRequest | ##### Get Prepper Template Request Model (optional) 

            try
            {
                // Get Prepper Template
                GetPrepperTemplateResponse result = apiInstance.PostGetPrepperTemplate(contentType, getPrepperTemplateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.PostGetPrepperTemplate: " + e.Message );
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
 **getPrepperTemplateRequest** | [**GetPrepperTemplateRequest**](GetPrepperTemplateRequest.md)| ##### Get Prepper Template Request Model | [optional] 

### Return type

[**GetPrepperTemplateResponse**](GetPrepperTemplateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Get Prepper Template Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgetpreppertemplatelist"></a>
# **PostGetPrepperTemplateList**
> GetPrepperTemplateListResponse PostGetPrepperTemplateList (string contentType, GetPrepperTemplateListRequest getPrepperTemplateListRequest = null)

Get Prepper Template List

#### Used to get a list of document templates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostGetPrepperTemplateListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://server-url/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new TemplatesApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var getPrepperTemplateListRequest = new GetPrepperTemplateListRequest(); // GetPrepperTemplateListRequest | ##### Get Prepper Template List Request Model (optional) 

            try
            {
                // Get Prepper Template List
                GetPrepperTemplateListResponse result = apiInstance.PostGetPrepperTemplateList(contentType, getPrepperTemplateListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.PostGetPrepperTemplateList: " + e.Message );
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
 **getPrepperTemplateListRequest** | [**GetPrepperTemplateListRequest**](GetPrepperTemplateListRequest.md)| ##### Get Prepper Template List Request Model | [optional] 

### Return type

[**GetPrepperTemplateListResponse**](GetPrepperTemplateListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Get Prepper Template List Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

