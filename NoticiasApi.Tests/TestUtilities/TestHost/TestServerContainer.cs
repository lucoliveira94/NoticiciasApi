﻿using BlogNoticias.Services;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestExamples.Api.IntegrationTests.TestUtilities.TestHost
{
    public class TestServerContainer
    {
        public HttpClient HttpClient { get; }

        public TestServerContainer(Action<IServiceCollection>? additionalServicesConfiguration = null)
        {
            var application = new WebApplicationFactory<Program>()
                .WithWebHostBuilder(builder =>
                {
                    builder.ConfigureServices(services =>
                    {
                        // [Set up necessary fakes here]
                        services.AddScoped(factory => A.Fake<IEditorService>());

                        if (additionalServicesConfiguration != null)
                            additionalServicesConfiguration.Invoke(services);
                    });
                });

            HttpClient = application.CreateClient();
        }

        public void Dispose()
        {
            HttpClient.Dispose();
        }
        public partial class Program { }
    }
}
