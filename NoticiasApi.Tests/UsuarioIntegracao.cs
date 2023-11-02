using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BlogNoticias.Controllers;
using BlogNoticias.Data.Dtos;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Xunit;

namespace BlogNoticias.Tests.IntegrationTests
{
    public class EditorControllerIntegrationTests : IClassFixture<WebApplicationFactory<EditorController>>
    {
        private readonly WebApplicationFactory<EditorController> _factory;

        public EditorControllerIntegrationTests(WebApplicationFactory<EditorController> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task CadastraUsuario_DeveRetornarSucesso_QuandoCadastroEhBemSucedido()
        {
            // Arrange
            var client = _factory.CreateClient();
            var dto = new CreateEditorDto
            {
                Username = "Lucas",
                CPF = "1234567890",
                Password = "Test@ndo123",
                RePassword = "Test@ndo123"
            };

            var jsonContent = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");

            // Act
            var response = await client.PostAsync("/Editor/cadastro", jsonContent);

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Equal("Usuário cadastrado!", responseString);
        }

        [Fact]
        public async Task Login_DeveRetornarSucesso_QuandoLoginEhBemSucedido()
        {
            // Arrange
            var client = _factory.CreateClient();
            var dto = new LoginEditorDto
            {
                Username = "Lucas",
                Password = "Test@ndo123"
            };

            var jsonContent = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");

            // Act
            var response = await client.PostAsync("/Editor/login", jsonContent);

            // Assert
            response.EnsureSuccessStatusCode();
            // Aqui você pode adicionar lógica para validar o token retornado, se necessário
        }
    }
}


