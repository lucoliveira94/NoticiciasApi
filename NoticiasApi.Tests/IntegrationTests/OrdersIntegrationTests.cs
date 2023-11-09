using Bogus;
using Docker.DotNet;
using Newtonsoft.Json;
using NoticiasApi.Data.Dtos;
using NoticiasApi.tests;
using Npgsql;
using System.Net;
using System.Text;

namespace NoticiasApi.Tests
{
    public class NoticiaIntegrationTests : IClassFixture<DockerFixture>
    {
        private readonly DockerFixture _dockerFixture;
        private readonly DockerClient _dockerClient;
        private readonly IHttpClientFactory _httpClientFactory;

        public NoticiaIntegrationTests(DockerFixture dockerFixture)
        {
            _dockerFixture = dockerFixture;

            using (var connection = new NpgsqlConnection(_dockerFixture.GetConnectionString()))
            {
                string createTableQuery = @"
                    CREATE TABLE noticias (
                          Id SERIAL PRIMARY KEY,
                          Titulo VARCHAR(255),
                          Chapeu VARCHAR(255),
                          Descricao VARCHAR(255),
                          DataPublicacao VARCHAR(255),
                          Editor VARCHAR(255)
                    );
                ";
                using (var command = new NpgsqlCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        //[Fact]
        //public async Task AdicionaNoticia_ReturnsCreatedResponse()
        //{
            // Arrange
            //var client = _httpClientFactory.CreateClient();
            //var noticiaDto = new CreateNoticiaDto
            //{
            //    Id = 1,
            //    Titulo = "teste",
            //    Chapeu = "testando",
            //    DataPublicacao = DateTime.Now,
            //    Descricao = "testando a noticia",
            //    Editor = "Lucas"
            //};

            // Act
            //var response = await client.PostAsync("/Noticia",
            //    new StringContent(JsonConvert.SerializeObject(noticiaDto), Encoding.UTF8, "application/json"));

            //// Assert
            //response.EnsureSuccessStatusCode();
            //Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        //}
    }
}

