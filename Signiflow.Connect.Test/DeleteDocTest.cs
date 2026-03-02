using Moq;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Model;

namespace Signiflow.Connect.Test;

[TestFixture]
public class Tests
{
    private Mock<IWorkFlowApiSync> _deleteDocRequestMock;
    
    [SetUp]
    public void Setup()
    {
        _deleteDocRequestMock = new Mock<IWorkFlowApiSync>();
    }
    
    [Test(Description = "Mock Delete Document Request to return a Delete Document Response")]
    public void DeleteDocument_ReturnDeleteDocumentResponse()
    {
        
        _deleteDocRequestMock
            .Setup(m => m.PostDeleteDoc(
                It.IsAny<string>(),
                It.IsAny<DeleteDocRequest>())
            )
            .Returns(new DeleteDocResponse("File Deleted"));
    }
}