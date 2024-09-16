# SigniFlow.Connect.Api.CeremonyApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|

| [**CertifyCeremonyWithToken**](CeremonyApi.md#certifyceremonywithtoken) | **POST** /CertifyCeremonyWithToken | Certify a ceremony |

<a id="certifyceremonywithtoken"></a>
# **CertifyCeremonyWithToken**
> CertifyCeremonyWithTokenResponse CertifyCeremonyWithToken (CertifyCeremonyWithTokenRequest certifyCeremonyWithTokenRequest)




### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{

    public class CertifyCeremonyWithTokenExample

    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CeremonyApi(config);

            var certifyCeremonyWithTokenRequest = new CertifyCeremonyWithTokenRequest(); // CertifyCeremonyWithTokenRequest | 


            try
            {

                CertifyCeremonyWithTokenResponse result = apiInstance.CertifyCeremonyWithToken(certifyCeremonyWithTokenRequest);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {

                Debug.Print("Exception when calling CeremonyApi.CertifyCeremonyWithToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}



#### Using the CertifyCeremonyWithTokenWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Certify a ceremony

    ApiResponse<CertifyCeremonyWithTokenResponse> response = apiInstance.CertifyCeremonyWithTokenWithHttpInfo(certifyCeremonyWithTokenRequest);

    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{

    Debug.Print("Exception when calling CeremonyApi.CertifyCeremonyWithTokenWithHttpInfo: " + e.Message);

    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|

=======
| **certifyCeremonyWithTokenRequest** | [**CertifyCeremonyWithTokenRequest**](CertifyCeremonyWithTokenRequest.md) |  |  |

### Return type

[**CertifyCeremonyWithTokenResponse**](CertifyCeremonyWithTokenResponse.md)


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

