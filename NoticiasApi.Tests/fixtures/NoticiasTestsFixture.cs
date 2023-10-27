using Bogus;
using NoticiasApi.Models;

namespace NoticiasApi.Tests.fixtures
{
    public class NoticiasTestsFixture
    {
        private readonly Faker _faker;

        public NoticiasTestsFixture()
        {
            _faker = new Faker();
        } 

        public Noticia GerarNoticiaTituloVazio()
        {
            // Arrange
            var Chapeu = _faker.Random.String2(10);
            var Titulo = string.Empty;
            var Descricao = _faker.Random.String2(100);
            var Editor = _faker.Name.FullName();

            return new Noticia(Chapeu, Titulo, Descricao, Editor);
        }

        public Noticia GerarNoticia()
        {
            // Arrange
            var Chapeu = _faker.Random.String2(10);
            var Titulo = _faker.Random.String2(40);
            var Descricao = _faker.Random.String2(100);
            var Editor = _faker.Name.FullName();

            return new Noticia(Titulo, Chapeu, Descricao, Editor);
        }


    }
}
