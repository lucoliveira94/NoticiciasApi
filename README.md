# Projeto criado para o Tech Challenge da terceira fase do curso de Arquitetura de Sistemas .NET com Azure

#Uma api para o cadastro de notícias em .NET 6, utilizando ASPNET, arquitetura REST e banco de dados MySQL
#A api conta também com um cadastro de Editores, que tem implementado um método de autenticação JWT que retorna um token no caso do login ser bem sucedido.

#A aplicação foi configurada para ser executada na plataforma de nuvem Azure utilizando o Github Actions, também conta com monitoração utilizando a ferramenta Application Insights

#Foram implantados testes unitários utilizando Xunit e testes de integração utilizando pipeline do github actions para realizar o build e teste com docker para o banco de testes

#Para executar o projeto é necessário configurar o appsettings.json e executar com .NET 6 e banco de dados MySql
