using NoticiasApi.Models;
using System.ComponentModel.DataAnnotations;

namespace NoticiasApi.Tests
{
    public class NoticiaTests
    {
        [Fact]
        public void Noticia_DeveTerAtributoRequiredNaPropriedadeTitulo()
        {
            // Arrange
            var propInfo = typeof(Noticia).GetProperty("Titulo");

            // Act
            var hasRequiredAttribute = propInfo.GetCustomAttributes(typeof(RequiredAttribute), true).Length > 0;

            // Assert
            Assert.True(hasRequiredAttribute, "Título é obrigatório");
        }

        [Fact]
        public void Noticia_DeveTerMaxLength100NaPropriedadeTitulo()
        {
            // Arrange
            var propInfo = typeof(Noticia).GetProperty("Titulo");

            // Act
            var maxLengthAttribute = (MaxLengthAttribute)propInfo.GetCustomAttributes(typeof(MaxLengthAttribute), true)[0];

            // Assert
            Assert.Equal(100, maxLengthAttribute.Length);
        }

        [Fact]
        public void Noticia_DeveTerAtributoRequiredNaPropriedadeChapeu()
        {
            // Arrange
            var propInfo = typeof(Noticia).GetProperty("Chapeu");

            // Act
            var hasRequiredAttribute = propInfo.GetCustomAttributes(typeof(RequiredAttribute), true).Length > 0;

            // Assert
            Assert.True(hasRequiredAttribute, "Chapeu é obrigatório");
        }

        [Fact]
        public void Noticia_DeveTerMaxLength50NaPropriedadeChapeu()
        {
            // Arrange
            var propInfo = typeof(Noticia).GetProperty("Chapeu");

            // Act
            var maxLengthAttribute = (MaxLengthAttribute)propInfo.GetCustomAttributes(typeof(MaxLengthAttribute), true)[0];

            // Assert
            Assert.Equal(50, maxLengthAttribute.Length);
        }

        [Fact]
        public void Noticia_DeveTerAtributoRequiredNaPropriedadeDescricao()
        {
            // Arrange
            var propInfo = typeof(Noticia).GetProperty("Descricao");

            // Act
            var hasRequiredAttribute = propInfo.GetCustomAttributes(typeof(RequiredAttribute), true).Length > 0;

            // Assert
            Assert.True(hasRequiredAttribute, "Descricao é obrigatório");
        }

        [Fact]
        public void Noticia_DeveTerAtributoRequiredNaPropriedadeEditor()
        {
            // Arrange
            var propInfo = typeof(Noticia).GetProperty("Editor");

            // Act
            var hasRequiredAttribute = propInfo.GetCustomAttributes(typeof(RequiredAttribute), true).Length > 0;

            // Assert
            Assert.True(hasRequiredAttribute, "Editor é obrigatório");
        }
    }
}
