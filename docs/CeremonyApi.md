# SigniFlow.Connect.Api.CeremonyApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CertifyCeremony**](CeremonyApi.md#certifyceremony) | **POST** /certifyCeremony | Certify a ceremony |

<a id="certifyceremony"></a>
# **CertifyCeremony**
> CertifyingCeremonyResponse CertifyCeremony (CertifyingCeremonyRequest certifyingCeremonyRequest)

Certify a ceremony

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class CertifyCeremonyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CeremonyApi(config);
            var certifyingCeremonyRequest = new CertifyingCeremonyRequest(); // CertifyingCeremonyRequest | 

            try
            {
                // Certify a ceremony
                CertifyingCeremonyResponse result = apiInstance.CertifyCeremony(certifyingCeremonyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CeremonyApi.CertifyCeremony: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CertifyCeremonyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Certify a ceremony
    ApiResponse<CertifyingCeremonyResponse> response = apiInstance.CertifyCeremonyWithHttpInfo(certifyingCeremonyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CeremonyApi.CertifyCeremonyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **certifyingCeremonyRequest** | [**CertifyingCeremonyRequest**](CertifyingCeremonyRequest.md) |  |  |

### Return type

[**CertifyingCeremonyResponse**](CertifyingCeremonyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response |  -  |
| **400** | Bad request |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

