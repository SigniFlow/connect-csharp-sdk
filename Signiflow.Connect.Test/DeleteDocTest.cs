using Moq;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Model;

namespace Signiflow.Connect.Test;

[TestFixture]
public class Tests
{
    private IWorkFlowApi _workflowApi;
    private AuthenticationApi _authenticationApi;
    
    [SetUp]
    public void Setup()
    {
        var config = new SigniFlow.Connect.Client.Configuration
        {
            BasePath = "https://dev.signiflow.com/API/SignFlowAPIServiceRest.svc"
        };
        _workflowApi = new WorkFlowApi(config);
        _authenticationApi = new AuthenticationApi(config);
    }

    [Test(Description = "Send a delete document request and expect a File Deleted response on success")]
    public void DeleteDocument_ReturnsDeleteDocumentResponse_OnHttpRequest()
    {
        try
        {
            var tokenField = GetTokenField();
            
            // Arrange
            var request = new DeleteDocRequest(docIDField:23979, tokenField: tokenField);
        
            var requestContentType = "application/json";
            // Act
            var response = _workflowApi.PostDeleteDoc(requestContentType, request);
        
            // Assert
            Assert.That(response, Is.Not.Null);
            Assert.That(response.ResultField, Is.Not.Null);
            Assert.That(response.ResultField, Is.EqualTo("File Deleted"));
        }
        catch (Exception e)
        {
            Assert.Fail($"API call failed with exception: {e.Message}");
        }
        
    }

    [Test(Description = "Mock Delete Document Request to return a Delete Document Response")]
    public void DeleteDocument_ReturnDeleteDocumentResponse()
    {
        var deleteDocRequestMock = new Mock<IWorkFlowApiSync>();

        deleteDocRequestMock
            .Setup(m => m.PostDeleteDoc(
                It.IsAny<string>(),
                It.IsAny<DeleteDocRequest>())
            )
            .Returns(new DeleteDocResponse("File Deleted"));
    }
    

    private TokenField GetTokenField()
    {
        var loginRequest = new LoginRequest("example@signiflow.com", "password");
        
        var loginResponse = _authenticationApi.Login("application/json", loginRequest);
        
        return loginResponse.TokenField;
    }
}