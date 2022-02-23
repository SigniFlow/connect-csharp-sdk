# SigniFlow.Connect.Api.PortfoliosApi

All URIs are relative to *https://server-url/API/SignFlowAPIServiceRest.svc*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostCreatePortfolio**](PortfoliosApi.md#postcreateportfolio) | **POST** /CreatePortfolio | Create Portfolio
[**PostDownloadPortfolio**](PortfoliosApi.md#postdownloadportfolio) | **POST** /DownloadPortfolio | Download Portfolio
[**PostLinkToPortfolio**](PortfoliosApi.md#postlinktoportfolio) | **POST** /LinkToPortfolio | Link To Portfolio
[**PostSetDocumentOrder**](PortfoliosApi.md#postsetdocumentorder) | **POST** /SetDocumentOrder | Set Document Order
[**PostSharePortfolio**](PortfoliosApi.md#postshareportfolio) | **POST** /SharePortfolio | Share Portfolio
[**PostSharePortfolioNoEmail**](PortfoliosApi.md#postshareportfolionoemail) | **POST** /SharePortfolio_No_Email | Share Portfolio No Email


<a name="postcreateportfolio"></a>
# **PostCreatePortfolio**
> CreatePortfolioResponse PostCreatePortfolio (string contentType, CreatePortfolioRequest createPortfolioRequest = null)

Create Portfolio

#### The API call used to group documents by creating a portfolio to store them in.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostCreatePortfolioExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://server-url/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new PortfoliosApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var createPortfolioRequest = new CreatePortfolioRequest(); // CreatePortfolioRequest | ##### Create Portfolio Request Model (optional) 

            try
            {
                // Create Portfolio
                CreatePortfolioResponse result = apiInstance.PostCreatePortfolio(contentType, createPortfolioRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfoliosApi.PostCreatePortfolio: " + e.Message );
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
 **createPortfolioRequest** | [**CreatePortfolioRequest**](CreatePortfolioRequest.md)| ##### Create Portfolio Request Model | [optional] 

### Return type

[**CreatePortfolioResponse**](CreatePortfolioResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Create Portfolio Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdownloadportfolio"></a>
# **PostDownloadPortfolio**
> DownloadPortfolioResponse PostDownloadPortfolio (string contentType, DownloadPortfolioRequest downloadPortfolioRequest = null)

Download Portfolio

#### The API call used to return a string that is then used to download a portfolio.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostDownloadPortfolioExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://server-url/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new PortfoliosApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var downloadPortfolioRequest = new DownloadPortfolioRequest(); // DownloadPortfolioRequest | ##### Download Portfolio Request Model (optional) 

            try
            {
                // Download Portfolio
                DownloadPortfolioResponse result = apiInstance.PostDownloadPortfolio(contentType, downloadPortfolioRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfoliosApi.PostDownloadPortfolio: " + e.Message );
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
 **downloadPortfolioRequest** | [**DownloadPortfolioRequest**](DownloadPortfolioRequest.md)| ##### Download Portfolio Request Model | [optional] 

### Return type

[**DownloadPortfolioResponse**](DownloadPortfolioResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Download Portfolio Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postlinktoportfolio"></a>
# **PostLinkToPortfolio**
> LinkToPortfolioResponse PostLinkToPortfolio (string contentType, LinkToPortfolioRequest linkToPortfolioRequest = null)

Link To Portfolio

#### Used to get the url link to a portfolio in order to link a document to a portfolio.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostLinkToPortfolioExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://server-url/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new PortfoliosApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var linkToPortfolioRequest = new LinkToPortfolioRequest(); // LinkToPortfolioRequest | ##### Link To Portfolio Request Model (optional) 

            try
            {
                // Link To Portfolio
                LinkToPortfolioResponse result = apiInstance.PostLinkToPortfolio(contentType, linkToPortfolioRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfoliosApi.PostLinkToPortfolio: " + e.Message );
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
 **linkToPortfolioRequest** | [**LinkToPortfolioRequest**](LinkToPortfolioRequest.md)| ##### Link To Portfolio Request Model | [optional] 

### Return type

[**LinkToPortfolioResponse**](LinkToPortfolioResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Link To Portfolio Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsetdocumentorder"></a>
# **PostSetDocumentOrder**
> SetDocumentOrderResponse PostSetDocumentOrder (string contentType, SetDocumentOrderRequest setDocumentOrderRequest = null)

Set Document Order

#### Used to set the order of documents that needs to be signed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostSetDocumentOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://server-url/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new PortfoliosApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var setDocumentOrderRequest = new SetDocumentOrderRequest(); // SetDocumentOrderRequest | ##### Set Document Order Request Model (optional) 

            try
            {
                // Set Document Order
                SetDocumentOrderResponse result = apiInstance.PostSetDocumentOrder(contentType, setDocumentOrderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfoliosApi.PostSetDocumentOrder: " + e.Message );
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
 **setDocumentOrderRequest** | [**SetDocumentOrderRequest**](SetDocumentOrderRequest.md)| ##### Set Document Order Request Model | [optional] 

### Return type

[**SetDocumentOrderResponse**](SetDocumentOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Set Document Order Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postshareportfolio"></a>
# **PostSharePortfolio**
> SharePortfolioResponse PostSharePortfolio (string contentType, SharePortfolioRequest sharePortfolioRequest = null)

Share Portfolio

#### Used when a user wants to share a portfolio with someone else.  Enumerations used in this API Call include: | Enumeration    | Values          | | - -- -- -- -- -- -- - |:- -- -- -- -- -- -- --:| | **AccessLevelField** | 0 = Viewer *(User has access to view documents in the portfolio)*, 1 = Contributor *(User can upload documents to placeholders)*, 2 = Owner *(User has full control over the portfolio)* | | **ShareOptionField** | 0 = Business *(Share with an entire business)*, 1 = Department *(Share with a specific department)*, 2 = Team *(Share with a specific team)*, 3 = User *(Share with a specific user)* |

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostSharePortfolioExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://server-url/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new PortfoliosApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var sharePortfolioRequest = new SharePortfolioRequest(); // SharePortfolioRequest | ##### Share Portfolio Request Model (optional) 

            try
            {
                // Share Portfolio
                SharePortfolioResponse result = apiInstance.PostSharePortfolio(contentType, sharePortfolioRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfoliosApi.PostSharePortfolio: " + e.Message );
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
 **sharePortfolioRequest** | [**SharePortfolioRequest**](SharePortfolioRequest.md)| ##### Share Portfolio Request Model | [optional] 

### Return type

[**SharePortfolioResponse**](SharePortfolioResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Share Portfolio Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postshareportfolionoemail"></a>
# **PostSharePortfolioNoEmail**
> SharePortfolioNoEmailResponse PostSharePortfolioNoEmail (string contentType, SharePortfolioNoEmailRequest sharePortfolioNoEmailRequest = null)

Share Portfolio No Email

#### Used when a user wants to share a portfolio without sending out an email.  Enumerations used in this API Call include: | Enumeration    | Values          | | - -- -- -- -- -- -- - |:- -- -- -- -- -- -- --:| | **AccessLevelField** | 0 = Viewer *(User has access to view documents in the portfolio)*, 1 = Contributor *(User can upload documents to placeholders)*, 2 = Owner *(User has full control over the portfolio)* | | **ShareOptionField** | 0 = Business *(Share with an entire business)*, 1 = Department *(Share with a specific department)*, 2 = Team *(Share with a specific team)*, 3 = User *(Share with a specific user)* |

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostSharePortfolioNoEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://server-url/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new PortfoliosApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var sharePortfolioNoEmailRequest = new SharePortfolioNoEmailRequest(); // SharePortfolioNoEmailRequest | ##### Share Portfolio No Email Request Model (optional) 

            try
            {
                // Share Portfolio No Email
                SharePortfolioNoEmailResponse result = apiInstance.PostSharePortfolioNoEmail(contentType, sharePortfolioNoEmailRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfoliosApi.PostSharePortfolioNoEmail: " + e.Message );
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
 **sharePortfolioNoEmailRequest** | [**SharePortfolioNoEmailRequest**](SharePortfolioNoEmailRequest.md)| ##### Share Portfolio No Email Request Model | [optional] 

### Return type

[**SharePortfolioNoEmailResponse**](SharePortfolioNoEmailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Share Portfolio No Email Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

