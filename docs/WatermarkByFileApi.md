# SigniFlow.Connect.Api.WatermarkByFileApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddDocumentWatermarkByFile**](WatermarkByFileApi.md#adddocumentwatermarkbyfile) | **POST** /AddDocumentWatermarkByFile | Add watermark to a document by file |

<a id="adddocumentwatermarkbyfile"></a>
# **AddDocumentWatermarkByFile**
> AddWatermarkByFileResponse AddDocumentWatermarkByFile (AddWatermarkByFileRequest addWatermarkByFileRequest)

Add watermark to a document by file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class AddDocumentWatermarkByFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WatermarkByFileApi(config);
            var addWatermarkByFileRequest = new AddWatermarkByFileRequest(); // AddWatermarkByFileRequest | 

            try
            {
                // Add watermark to a document by file
                AddWatermarkByFileResponse result = apiInstance.AddDocumentWatermarkByFile(addWatermarkByFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WatermarkByFileApi.AddDocumentWatermarkByFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddDocumentWatermarkByFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add watermark to a document by file
    ApiResponse<AddWatermarkByFileResponse> response = apiInstance.AddDocumentWatermarkByFileWithHttpInfo(addWatermarkByFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WatermarkByFileApi.AddDocumentWatermarkByFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addWatermarkByFileRequest** | [**AddWatermarkByFileRequest**](AddWatermarkByFileRequest.md) |  |  |

### Return type

[**AddWatermarkByFileResponse**](AddWatermarkByFileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

