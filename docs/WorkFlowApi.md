# SigniFlow.Connect.Api.WorkFlowApi

All URIs are relative to *https://client-signiflow-com/API/SignFlowAPIServiceRest.svc*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWorkflow**](WorkFlowApi.md#createworkflow) | **POST** /CreateWorkflow | Create Workflow
[**GetDocument**](WorkFlowApi.md#getdocument) | **POST** /GetDoc | Get Document
[**PostAddWorkflowStep**](WorkFlowApi.md#postaddworkflowstep) | **POST** /AddWorkflowStepV2 | Add a Workflow step
[**PostCancelFlow**](WorkFlowApi.md#postcancelflow) | **POST** /CancelFlow | Cancel Flow
[**PostDeleteDoc**](WorkFlowApi.md#postdeletedoc) | **POST** /DeleteDoc | Delete Document
[**PostDocPrepperAddField**](WorkFlowApi.md#postdocprepperaddfield) | **POST** /DocPrepperAddFieldsFlowID | Document Prepper Add Fields
[**PostDocPrepperAdvancedFields**](WorkFlowApi.md#postdocprepperadvancedfields) | **POST** /DocPrepperAdvancedFields | Document Prepper Add Advanced Fields
[**PostFullWorkflow**](WorkFlowApi.md#postfullworkflow) | **POST** /FullWorkflow | FullWorkflow
[**PostGetDocStatus**](WorkFlowApi.md#postgetdocstatus) | **POST** /GetDocStatus | Get Document Status
[**PostInitiateFlow**](WorkFlowApi.md#postinitiateflow) | **POST** /InitiateFlow | Initiate Flow
[**PostInitiateFlowNoEmail**](WorkFlowApi.md#postinitiateflownoemail) | **POST** /InitiateFlow_No_Email | Initiate Flow No Email
[**PostInitiateFlowNoInitialEmail**](WorkFlowApi.md#postinitiateflownoinitialemail) | **POST** /InitiateFlow_No_Initial_Email | Initiate Flow No Initial Email
[**PostWorkflowSign**](WorkFlowApi.md#postworkflowsign) | **POST** /WorkflowSign | Workflow Sign


<a name="createworkflow"></a>
# **CreateWorkflow**
> CreateWorkflowResponse CreateWorkflow (string contentType, CreateWorkflowRequest createWorkflowRequest)

Create Workflow

#### Used to start a new workflow by passing a Base64 encoded document to SigniFlow

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class CreateWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://client-signiflow-com/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new WorkFlowApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var createWorkflowRequest = new CreateWorkflowRequest(); // CreateWorkflowRequest | ##### Create Workflow Request Model

            try
            {
                // Create Workflow
                CreateWorkflowResponse result = apiInstance.CreateWorkflow(contentType, createWorkflowRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkFlowApi.CreateWorkflow: " + e.Message );
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
 **createWorkflowRequest** | [**CreateWorkflowRequest**](CreateWorkflowRequest.md)| ##### Create Workflow Request Model | 

### Return type

[**CreateWorkflowResponse**](CreateWorkflowResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Create Workflow Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocument"></a>
# **GetDocument**
> GetDocumentResponse GetDocument (string contentType, GetDocumentRequest getDocumentRequest = null)

Get Document

#### Used to download a document from SigniFlow.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class GetDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://client-signiflow-com/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new WorkFlowApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var getDocumentRequest = new GetDocumentRequest(); // GetDocumentRequest | ##### Get Document Request Model (optional) 

            try
            {
                // Get Document
                GetDocumentResponse result = apiInstance.GetDocument(contentType, getDocumentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkFlowApi.GetDocument: " + e.Message );
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
 **getDocumentRequest** | [**GetDocumentRequest**](GetDocumentRequest.md)| ##### Get Document Request Model | [optional] 

### Return type

[**GetDocumentResponse**](GetDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Get Document Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaddworkflowstep"></a>
# **PostAddWorkflowStep**
> AddWokflowStepV2Response PostAddWorkflowStep (string contentType, AddWorkflowStepV2Request addWorkflowStepV2Request = null)

Add a Workflow step

#### Used to add a step to a document Workflow process.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostAddWorkflowStepExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://client-signiflow-com/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new WorkFlowApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var addWorkflowStepV2Request = new AddWorkflowStepV2Request(); // AddWorkflowStepV2Request | ##### Add A Workflow Step Request Model (optional) 

            try
            {
                // Add a Workflow step
                AddWokflowStepV2Response result = apiInstance.PostAddWorkflowStep(contentType, addWorkflowStepV2Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkFlowApi.PostAddWorkflowStep: " + e.Message );
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
 **addWorkflowStepV2Request** | [**AddWorkflowStepV2Request**](AddWorkflowStepV2Request.md)| ##### Add A Workflow Step Request Model | [optional] 

### Return type

[**AddWokflowStepV2Response**](AddWokflowStepV2Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Add A Workflow Step Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcancelflow"></a>
# **PostCancelFlow**
> CancelFlowResponse PostCancelFlow (string contentType, CancelFlowRequest cancelFlowRequest = null)

Cancel Flow

#### Used to cancel a document workflow.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostCancelFlowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://client-signiflow-com/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new WorkFlowApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var cancelFlowRequest = new CancelFlowRequest(); // CancelFlowRequest | ##### Cancel Flow Request Model (optional) 

            try
            {
                // Cancel Flow
                CancelFlowResponse result = apiInstance.PostCancelFlow(contentType, cancelFlowRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkFlowApi.PostCancelFlow: " + e.Message );
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
 **cancelFlowRequest** | [**CancelFlowRequest**](CancelFlowRequest.md)| ##### Cancel Flow Request Model | [optional] 

### Return type

[**CancelFlowResponse**](CancelFlowResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Cancel Flow Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdeletedoc"></a>
# **PostDeleteDoc**
> DeleteDocResponse PostDeleteDoc (string contentType, DeleteDocRequest deleteDocRequest = null)

Delete Document

#### This is used to delete a document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostDeleteDocExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://client-signiflow-com/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new WorkFlowApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var deleteDocRequest = new DeleteDocRequest(); // DeleteDocRequest | ##### Delete Document Request Model (optional) 

            try
            {
                // Delete Document
                DeleteDocResponse result = apiInstance.PostDeleteDoc(contentType, deleteDocRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkFlowApi.PostDeleteDoc: " + e.Message );
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
 **deleteDocRequest** | [**DeleteDocRequest**](DeleteDocRequest.md)| ##### Delete Document Request Model | [optional] 

### Return type

[**DeleteDocResponse**](DeleteDocResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Delete Document Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdocprepperaddfield"></a>
# **PostDocPrepperAddField**
> DocPrepperAddFieldsFlowIDResponse PostDocPrepperAddField (string contentType, DocPrepperAddFieldsFlowIDRequest docPrepperAddFieldsFlowIDRequest = null)

Document Prepper Add Fields

#### Used to add fields to a document using the user's FlowID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostDocPrepperAddFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://client-signiflow-com/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new WorkFlowApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var docPrepperAddFieldsFlowIDRequest = new DocPrepperAddFieldsFlowIDRequest(); // DocPrepperAddFieldsFlowIDRequest | ##### Document Prepper Add Fields Request Model (optional) 

            try
            {
                // Document Prepper Add Fields
                DocPrepperAddFieldsFlowIDResponse result = apiInstance.PostDocPrepperAddField(contentType, docPrepperAddFieldsFlowIDRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkFlowApi.PostDocPrepperAddField: " + e.Message );
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
 **docPrepperAddFieldsFlowIDRequest** | [**DocPrepperAddFieldsFlowIDRequest**](DocPrepperAddFieldsFlowIDRequest.md)| ##### Document Prepper Add Fields Request Model | [optional] 

### Return type

[**DocPrepperAddFieldsFlowIDResponse**](DocPrepperAddFieldsFlowIDResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Document Prepper Add Fields Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdocprepperadvancedfields"></a>
# **PostDocPrepperAdvancedFields**
> DocPrepperAddAdvancedFieldsResponse PostDocPrepperAdvancedFields (string contentType, DocPrepperAddAdvancedFieldsRequest docPrepperAddAdvancedFieldsRequest = null)

Document Prepper Add Advanced Fields

#### Used to add advanced fields to a document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostDocPrepperAdvancedFieldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://client-signiflow-com/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new WorkFlowApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var docPrepperAddAdvancedFieldsRequest = new DocPrepperAddAdvancedFieldsRequest(); // DocPrepperAddAdvancedFieldsRequest | ##### Document Prepper Add Advanced Fields Request Model (optional) 

            try
            {
                // Document Prepper Add Advanced Fields
                DocPrepperAddAdvancedFieldsResponse result = apiInstance.PostDocPrepperAdvancedFields(contentType, docPrepperAddAdvancedFieldsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkFlowApi.PostDocPrepperAdvancedFields: " + e.Message );
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
 **docPrepperAddAdvancedFieldsRequest** | [**DocPrepperAddAdvancedFieldsRequest**](DocPrepperAddAdvancedFieldsRequest.md)| ##### Document Prepper Add Advanced Fields Request Model | [optional] 

### Return type

[**DocPrepperAddAdvancedFieldsResponse**](DocPrepperAddAdvancedFieldsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Document Prepper Add Advanced Fields Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfullworkflow"></a>
# **PostFullWorkflow**
> FullWorkflowResponse PostFullWorkflow (string contentType, FullWorkflowRequest fullWorkflowRequest = null)

FullWorkflow

#### Used to create a fullworkflow for a document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostFullWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://client-signiflow-com/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new WorkFlowApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var fullWorkflowRequest = new FullWorkflowRequest(); // FullWorkflowRequest | ##### FullWorkflow Request Model (optional) 

            try
            {
                // FullWorkflow
                FullWorkflowResponse result = apiInstance.PostFullWorkflow(contentType, fullWorkflowRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkFlowApi.PostFullWorkflow: " + e.Message );
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
 **fullWorkflowRequest** | [**FullWorkflowRequest**](FullWorkflowRequest.md)| ##### FullWorkflow Request Model | [optional] 

### Return type

[**FullWorkflowResponse**](FullWorkflowResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### FullWorkflow Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgetdocstatus"></a>
# **PostGetDocStatus**
> GetDocStatusResponse PostGetDocStatus (string contentType, GetDocStatusRequest getDocStatusRequest = null)

Get Document Status

#### Used to get the status of the document ex. pending/completed/rejected.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostGetDocStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://client-signiflow-com/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new WorkFlowApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var getDocStatusRequest = new GetDocStatusRequest(); // GetDocStatusRequest | ##### Get Document Status Request Model (optional) 

            try
            {
                // Get Document Status
                GetDocStatusResponse result = apiInstance.PostGetDocStatus(contentType, getDocStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkFlowApi.PostGetDocStatus: " + e.Message );
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
 **getDocStatusRequest** | [**GetDocStatusRequest**](GetDocStatusRequest.md)| ##### Get Document Status Request Model | [optional] 

### Return type

[**GetDocStatusResponse**](GetDocStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Get Document Status Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postinitiateflow"></a>
# **PostInitiateFlow**
> InitiateFlowResponse PostInitiateFlow (string contentType, InitiateFlowRequest initiateFlowRequest = null)

Initiate Flow

#### Used to initiate aworkflow of a document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostInitiateFlowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://client-signiflow-com/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new WorkFlowApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var initiateFlowRequest = new InitiateFlowRequest(); // InitiateFlowRequest | ##### Initiate Flow Request Model (optional) 

            try
            {
                // Initiate Flow
                InitiateFlowResponse result = apiInstance.PostInitiateFlow(contentType, initiateFlowRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkFlowApi.PostInitiateFlow: " + e.Message );
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
 **initiateFlowRequest** | [**InitiateFlowRequest**](InitiateFlowRequest.md)| ##### Initiate Flow Request Model | [optional] 

### Return type

[**InitiateFlowResponse**](InitiateFlowResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Initiate Flow Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postinitiateflownoemail"></a>
# **PostInitiateFlowNoEmail**
> InitiateFlowNoEmailResponse PostInitiateFlowNoEmail (string contentType, InitiateFlowNoEmailRequest initiateFlowNoEmailRequest = null)

Initiate Flow No Email

#### Used to initiate a workflow without sending out emails.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostInitiateFlowNoEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://client-signiflow-com/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new WorkFlowApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var initiateFlowNoEmailRequest = new InitiateFlowNoEmailRequest(); // InitiateFlowNoEmailRequest | ##### Initiate Flow No Email Request Model (optional) 

            try
            {
                // Initiate Flow No Email
                InitiateFlowNoEmailResponse result = apiInstance.PostInitiateFlowNoEmail(contentType, initiateFlowNoEmailRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkFlowApi.PostInitiateFlowNoEmail: " + e.Message );
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
 **initiateFlowNoEmailRequest** | [**InitiateFlowNoEmailRequest**](InitiateFlowNoEmailRequest.md)| ##### Initiate Flow No Email Request Model | [optional] 

### Return type

[**InitiateFlowNoEmailResponse**](InitiateFlowNoEmailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Initiate Flow No Email Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postinitiateflownoinitialemail"></a>
# **PostInitiateFlowNoInitialEmail**
> InitiateFlowNoInitialEmailResponse PostInitiateFlowNoInitialEmail (string contentType, InitiateFlowNoInitialEmailRequest initiateFlowNoInitialEmailRequest = null)

Initiate Flow No Initial Email

#### Used to initiate a document workflow without an initial email being sent to the user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostInitiateFlowNoInitialEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://client-signiflow-com/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new WorkFlowApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var initiateFlowNoInitialEmailRequest = new InitiateFlowNoInitialEmailRequest(); // InitiateFlowNoInitialEmailRequest | ##### Initiate Flow No Initial Email Request Model (optional) 

            try
            {
                // Initiate Flow No Initial Email
                InitiateFlowNoInitialEmailResponse result = apiInstance.PostInitiateFlowNoInitialEmail(contentType, initiateFlowNoInitialEmailRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkFlowApi.PostInitiateFlowNoInitialEmail: " + e.Message );
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
 **initiateFlowNoInitialEmailRequest** | [**InitiateFlowNoInitialEmailRequest**](InitiateFlowNoInitialEmailRequest.md)| ##### Initiate Flow No Initial Email Request Model | [optional] 

### Return type

[**InitiateFlowNoInitialEmailResponse**](InitiateFlowNoInitialEmailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Initiate Flow No Initial Email Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkflowsign"></a>
# **PostWorkflowSign**
> WorkflowSignResponse PostWorkflowSign (string contentType, WorkflowSignRequest workflowSignRequest = null)

Workflow Sign

#### Used to send a request to a user to sign a document workflow.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace Example
{
    public class PostWorkflowSignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://client-signiflow-com/API/SignFlowAPIServiceRest.svc";
            var apiInstance = new WorkFlowApi(config);
            var contentType = contentType_example;  // string |  (default to "application/json")
            var workflowSignRequest = new WorkflowSignRequest(); // WorkflowSignRequest | ##### Workflow Sign Request Model (optional) 

            try
            {
                // Workflow Sign
                WorkflowSignResponse result = apiInstance.PostWorkflowSign(contentType, workflowSignRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkFlowApi.PostWorkflowSign: " + e.Message );
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
 **workflowSignRequest** | [**WorkflowSignRequest**](WorkflowSignRequest.md)| ##### Workflow Sign Request Model | [optional] 

### Return type

[**WorkflowSignResponse**](WorkflowSignResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ##### Workflow Sign Response Model |  * Content-Type -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

