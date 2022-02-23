# SigniFlow.Connect.Api.SigningCeremonyApi

All URIs are relative to *https://clientname.signiflow.com/API/SignFlowAPIServiceRest.svc*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostMultipleSignersSigningCeremony**](SigningCeremonyApi.md#postmultiplesignerssigningceremony) | **POST** /MultipleSignersSigningCeremony | Multiple Signers Signing Ceremony
[**PostSigningCeremonyV2**](SigningCeremonyApi.md#postsigningceremonyv2) | **POST** /SigningCeremonyV2 | Signing Ceremony V2



## PostMultipleSignersSigningCeremony

> MultipleSignersSigningCeremonyResponse PostMultipleSignersSigningCeremony (string contentType, MultipleSignersSigningCeremonyRequest multipleSignersSigningCeremonyRequest = null)

Multiple Signers Signing Ceremony

#### Used when there are multiple signers on a document.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostMultipleSignersSigningCeremonyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://clientname.signiflow.com/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new SigningCeremonyApi(Configuration.Default);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var multipleSignersSigningCeremonyRequest = new MultipleSignersSigningCeremonyRequest(); // MultipleSignersSigningCeremonyRequest | ##### Multiple Signers Signing Ceremony Request Model (optional) 

            try
            {
                // Multiple Signers Signing Ceremony
                MultipleSignersSigningCeremonyResponse result = apiInstance.PostMultipleSignersSigningCeremony(contentType, multipleSignersSigningCeremonyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SigningCeremonyApi.PostMultipleSignersSigningCeremony: " + e.Message );
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
 **multipleSignersSigningCeremonyRequest** | [**MultipleSignersSigningCeremonyRequest**](MultipleSignersSigningCeremonyRequest.md)| ##### Multiple Signers Signing Ceremony Request Model | [optional] 

### Return type

[**MultipleSignersSigningCeremonyResponse**](MultipleSignersSigningCeremonyResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Multiple Signers Signing Ceremony Response Model |  * Content-Type -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PostSigningCeremonyV2

> SigningCeremonyV2Response PostSigningCeremonyV2 (string contentType, SigningCeremonyV2Request signingCeremonyV2Request = null)

Signing Ceremony V2

#### Used to initiate the signing process of a document.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostSigningCeremonyV2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://clientname.signiflow.com/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new SigningCeremonyApi(Configuration.Default);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var signingCeremonyV2Request = new SigningCeremonyV2Request(); // SigningCeremonyV2Request | ##### Signing Ceremony V2 Request Model (optional) 

            try
            {
                // Signing Ceremony V2
                SigningCeremonyV2Response result = apiInstance.PostSigningCeremonyV2(contentType, signingCeremonyV2Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SigningCeremonyApi.PostSigningCeremonyV2: " + e.Message );
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
 **signingCeremonyV2Request** | [**SigningCeremonyV2Request**](SigningCeremonyV2Request.md)| ##### Signing Ceremony V2 Request Model | [optional] 

### Return type

[**SigningCeremonyV2Response**](SigningCeremonyV2Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Signing Ceremony V2 Response Model |  * Content-Type -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

