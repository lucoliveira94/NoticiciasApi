using BlogNoticias.Controllers;
using BlogNoticias.Data.Dtos;
using BlogNoticias.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace API.Tests
{
    public class EditorControllerTests
    {
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
            // Arrange
            var cadastraEditorDto = new CreateEditorDto(
                username:"Lucas",
                cpf: "1234567890",
                password:"Test@ando123",
                repassword: "Test@ando123"
                );

            _serviceMock.Setup(s => s.Cadastra(cadastraEditorDto));

            // Act
            var result = await _controller.Get(cadastraEditorDto);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = (OkObjectResult)result;
            Assert.Equal(cadastraEditorDto, okResult.Value);
        }
    }
}
