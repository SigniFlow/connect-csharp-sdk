using SigniFlow.Connect.Api;
using SigniFlow.Connect.Model;

namespace Signiflow.Connect.Test;

public class Tests
{
    private WorkFlowApi _workflowApi;
    
    [SetUp]
    public void Setup()
    {
        var config = new SigniFlow.Connect.Client.Configuration
        {
            BasePath = "https://dev.signiflow.com/API/SignFlowAPIServiceRest.svc"
        };
        _workflowApi = new WorkFlowApi(config);
    }

    [Test]
    public void DeleteDocument_ShouldReturnSuccess()
    {
        try
        {
            var tokenField = new TokenField(tokenExpiryField: DateTime.Parse("2026-01-27T09:11:36.3140177+02:00"),
                tokenField: "atnint");
            // Arrange
            var request = new DeleteDocRequest(docIDField:23979, tokenField: tokenField);
        
            var requestContentType = "application/json";
            // Act
            var response = _workflowApi.PostDeleteDoc(requestContentType, request);
        
            // Assert
            Assert.That(response, Is.InstanceOf<DeleteDocResponse>());
        }
        catch (Exception e)
        {
            Assert.Fail($"API call failed with exception: {e.Message}");
        }
        
    }
}