//using BlogNoticias.Data.Dtos;
//using BlogNoticias.Services;
//using FakeItEasy;
//using FluentAssertions;
//using Microsoft.Extensions.DependencyInjection;
//using Newtonsoft.Json;
//using TestExamples.Api.IntegrationTests.TestUtilities.TestHost;
//using Microsoft.AspNetCore.Mvc.Testing;

//namespace NoticiasApi.Tests.Controllers
//{
//    public class EditorControllerTest
//    {
//        public class EditorCadastro
//        {
//            [Fact]
//            public async Task Should_Cadastrar_Editor()
//            {
//                // Arrange
//                var editorService = A.Fake<IEditorService>();

//                var testServerContainer = new TestServerContainer(serviceCollection =>
//                {
//                    serviceCollection.AddScoped(factory => editorService);
//                });

//                using var httpClient = testServerContainer.HttpClient;

//                var expectedEditor = new CreateEditorDto(
//                    username: "Lucas",
//                    cpf: "1234567890",
//                    password: "Test@ando123",
//                    repassword: "Test@ando123");

//                // Act
//                var response = await httpClient.GetAsync($"/Editor/cadastro?username={expectedEditor.Username}&cpf={expectedEditor.CPF}&password={expectedEditor.Password}&repassword={expectedEditor.RePassword}");

//                // Assert
//                Assert.True( response.IsSuccessStatusCode );
//            }
//        }
//    }
//}

