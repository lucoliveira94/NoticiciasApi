using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Newtonsoft.Json;
using NoticiasApi.Data;
using NoticiasApi.Data.Dtos;
using NoticiasApi.tests;
using System.Net;
using System.Text;

namespace NoticiasApi.Tests.Controllers;

public class NoticiaControllerIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;
    private NoticiaContext? _noticiaContext;
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly DockerFixture _dockerFixture;

    public NoticiaContext GetDbContext()
    {
        var contextOptions = new DbContextOptionsBuilder<NoticiaContext>()
            .UseInMemoryDatabase("NoticiasApi")
            .ConfigureWarnings(b => b.Ignore(InMemoryEventId.TransactionIgnoredWarning))
            .Options;

        _noticiaContext = new NoticiaContext(contextOptions);

        _noticiaContext.Database.EnsureDeleted();
        _noticiaContext.Database.EnsureCreated();

        return _noticiaContext;
    }

    //[Fact]
    //public async Task AdicionaNoticia_ReturnsCreatedResponse()
    //{
    //    // Arrange
    //    var client = _httpClientFactory.CreateClient();
    //    var noticiaDto = new CreateNoticiaDto
    //    {
    //        Id = 1,
    //        Titulo = "teste",
    //        Chapeu = "testando",
    //        DataPublicacao = DateTime.Now,
    //        Descricao = "testando a noticia",
    //        Editor = "Lucas"
    //    };

    //    // Act
    //    var response = await client.PostAsync("/Noticia",
    //        new StringContent(JsonConvert.SerializeObject(noticiaDto), Encoding.UTF8, "application/json"));

    //    // Assert
    //    response.EnsureSuccessStatusCode();
    //    Assert.Equal(HttpStatusCode.Created, response.StatusCode);

    //}

    //[Fact]
    //public async Task RecuperaNoticiaPorId_ReturnsOkResponse()
    //{
    //    // Arrange
    //    var noticia = new ReadNoticiaDto();

    //    var client = _factory.CreateClient();
    //    var id = noticia.Id;

    //    // Act
    //    var response = await client.GetAsync($"/Noticia/{id}");

    //    // Assert
    //    response.EnsureSuccessStatusCode();
    //    Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    //}
}
