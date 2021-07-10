# SigniFlow.Connect.Api.AuthenticationApi

All URIs are relative to *https://server-url/API/SignFlowAPIServiceRest.svc*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Login**](AuthenticationApi.md#login) | **POST** /Login | Login
[**PostLogout**](AuthenticationApi.md#postlogout) | **POST** /Logout | Logout
[**PostTokenExtend**](AuthenticationApi.md#posttokenextend) | **POST** /TokenExtend | Token Extend
[**PostTokenValidate**](AuthenticationApi.md#posttokenvalidate) | **POST** /TokenValidate | Token Validate


<a name="login"></a>
# **Login**
> LoginResponse Login (string contentType, LoginRequest loginRequest)

Login

#### Generates a API Token for the User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class LoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://server-url/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new AuthenticationApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var loginRequest = new LoginRequest(); // LoginRequest | ##### Login Request Model

            try
            {
                // Login
                LoginResponse result = apiInstance.Login(contentType, loginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.Login: " + e.Message );
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
 **loginRequest** | [**LoginRequest**](LoginRequest.md)| ##### Login Request Model | 

### Return type

[**LoginResponse**](LoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Login Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postlogout"></a>
# **PostLogout**
> LogoutResponse PostLogout (string contentType, LogoutRequest logoutRequest = null)

Logout

#### Used to log out a user from SigniFlow.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostLogoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://server-url/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new AuthenticationApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var logoutRequest = new LogoutRequest(); // LogoutRequest | ##### Logout Request Model (optional) 

            try
            {
                // Logout
                LogoutResponse result = apiInstance.PostLogout(contentType, logoutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.PostLogout: " + e.Message );
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
 **logoutRequest** | [**LogoutRequest**](LogoutRequest.md)| ##### Logout Request Model | [optional] 

### Return type

[**LogoutResponse**](LogoutResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Logout Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttokenextend"></a>
# **PostTokenExtend**
> TokenExtendResponse PostTokenExtend (string contentType, TokenExtendRequest tokenExtendRequest = null)

Token Extend

#### Used to extend the period of time in which the session token is valid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostTokenExtendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://server-url/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new AuthenticationApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var tokenExtendRequest = new TokenExtendRequest(); // TokenExtendRequest | ##### Token Extend Request Model (optional) 

            try
            {
                // Token Extend
                TokenExtendResponse result = apiInstance.PostTokenExtend(contentType, tokenExtendRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.PostTokenExtend: " + e.Message );
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
 **tokenExtendRequest** | [**TokenExtendRequest**](TokenExtendRequest.md)| ##### Token Extend Request Model | [optional] 

### Return type

[**TokenExtendResponse**](TokenExtendResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Token Extend Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttokenvalidate"></a>
# **PostTokenValidate**
> TokenValidateResponse PostTokenValidate (string contentType, TokenValidateRequest tokenValidateRequest = null)

Token Validate

#### Used to validate the user's session token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostTokenValidateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://server-url/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new AuthenticationApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var tokenValidateRequest = new TokenValidateRequest(); // TokenValidateRequest | ##### Token Validate Request Model (optional) 

            try
            {
                // Token Validate
                TokenValidateResponse result = apiInstance.PostTokenValidate(contentType, tokenValidateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.PostTokenValidate: " + e.Message );
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
 **tokenValidateRequest** | [**TokenValidateRequest**](TokenValidateRequest.md)| ##### Token Validate Request Model | [optional] 

### Return type

[**TokenValidateResponse**](TokenValidateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Token Validate Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

