using BlogNoticias.Controllers;
using BlogNoticias.Services;
using Microsoft.Extensions.Logging;
using Moq;
using NoticiasApi.tests;

namespace NoticiasApi.Tests;

public class EditorControllerTests
{
    private DockerFixture _dockerClient { get; set; }
    private EditorController _controller;
    private Mock<IEditorService> _serviceMock;
    private Mock<ILogger<EditorController>> _loggerMock;


    public EditorControllerTests()
    {
        // Configurar o mock do serviço
        _serviceMock = new Mock<IEditorService>();

        // Configurar o mock do logger
        _loggerMock = new Mock<ILogger<EditorController>>();

        // Inicializar o controller com o mock do serviço e do logger
        _controller = new EditorController(_loggerMock.Object, _serviceMock.Object);
    }

    [Fact]
    public async Task Get_ReturnsOkResultWithData()
    {
        //var controller = new NoticiaController( _dockerClient);

        ////Act
        //var response = await controller.GetNoticias(Guid.Empty);

        ////Assert
        //var objectResult = (ObjectResult?)response;
        //var apiResponse = _dockerFixture.GetApiResponseFromObjectResult(objectResult);

        //Assert.Equal((int)HttpStatusCode.BadRequest, objectResult?.StatusCode);
        //Assert.Null(apiResponse?.Data);

    }
}
