using Bogus;
using NoticiasApi.Tests.fixtures;

namespace NoticiasApi.Tests
{
    [Collection(nameof(NoticiasTestsFixtureCollection))]
    public class NoticiasTests
    {
        private readonly Faker _faker;
        public readonly NoticiasTestsFixture _noticiasTestsFixture;

        public NoticiasTests(NoticiasTestsFixture noticiasTestsFixture)
        {
            _faker = new Faker();
            _noticiasTestsFixture = noticiasTestsFixture;
        }

        [Fact(DisplayName = "Validando se o titulo esta vazio")]
        [Trait("Categoria", "Validando Noticias")]
        public void ValidandoExceptionTituloVazio()
        {
            // Arrange         


            //act
            var result = Assert.Throws<DomainException>(() => _noticiasTestsFixture.GerarNoticiaTituloVazio());

            //Assert
            Assert.Equal("O título não pode estar vazio!", result.Message);

        }

        [Fact(DisplayName = "Validando se o chapeu esta vazio")]
        [Trait("Categoria", "Validando Noticias")]
        public void ValidandoExceptionChapeuVazio()
        {
            // Arrange
            var Chapeu = "";
            var Titulo = _faker.Random.String2(40);
            var Descricao = _faker.Random.String2(100);
            var Editor = _faker.Name.FullName();

            //act
            var result = Assert.Throws<DomainException>(() => new Noticia(Chapeu, Titulo, Descricao, Editor));

            //Assert
            Assert.Equal("O chapéu não pode estar vazio!", result.Message);

        }

        [Fact(DisplayName = "Validando se o texto esta vazio")]
        [Trait("Categoria", "Validando Noticias")]
        public void ValidandoExceptionDescricaoVazio()
        {
            // Arrange
            var Chapeu = _faker.Random.String2(10);
            var Titulo = _faker.Random.String2(50);
            var Descricao = string.Empty;
            var Editor = _faker.Name.FullName();

            //act
            var result = Assert.Throws<DomainException>(() => new Noticia(Chapeu, Titulo, Descricao, Editor));

            //Assert
            Assert.Equal("O texto não pode estar vazio!", result.Message);


        }


        [Fact(DisplayName = "Validando tamanho maximo do chapeu")]
        [Trait("Categoria", "Validando Noticias")]
        public void ValidandoExceptionTamanhoMaximoChapeu()
        {
            // Arrange
            var Chapeu = _faker.Random.String2(41); // Generate a string longer than 40 characters
            var Titulo = _faker.Random.String2(50);
            var Descricao = _faker.Random.String2(100);
            var Editor = _faker.Name.FullName();

            // Act & Assert
            var exception = Assert.Throws<DomainException>(() => new Noticia(Chapeu, Titulo, Descricao, Editor));
            Assert.Equal("O chapéu deve ter até 40 caracteres!", exception.Message);
        }
    }
}
