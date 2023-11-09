using Docker.DotNet;
using Docker.DotNet.Models;
using Microsoft.AspNetCore.Mvc.Testing;

namespace NoticiasApi.tests;

public class DockerFixture : IDisposable, IAsyncLifetime
{
    private DockerClient _dockerClient;
    private string _containerId;

    public DockerFixture()
    {
        _dockerClient = new DockerClientConfiguration().CreateClient();

        var createContainerResponse = _dockerClient.Containers.CreateContainerAsync(new CreateContainerParameters
        {
            Image = "postgres",
            Env = new List<string> { "POSTGRES_PASSWORD=9816823412" },
            HostConfig = new HostConfig
            {
                PortBindings = new Dictionary<string, IList<PortBinding>>()
                {
                    { "5432/tcp", new List<PortBinding> { new PortBinding { HostPort = "5432" } } }
                },
                PublishAllPorts = true 
            }
        }).GetAwaiter().GetResult();


        _containerId = createContainerResponse.ID;

        _dockerClient.Containers.StartContainerAsync(_containerId, new ContainerStartParameters()).GetAwaiter().GetResult();

    }

    public string GetConnectionString()
    {
        var _connectionString = $"Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=9816823412;";
        return _connectionString;
    }

    public void Dispose()
    {
        _dockerClient.Containers.StopContainerAsync(_containerId, new ContainerStopParameters()).GetAwaiter().GetResult();
        _dockerClient.Containers.RemoveContainerAsync(_containerId, new ContainerRemoveParameters()).GetAwaiter().GetResult();
        _dockerClient.Dispose();
    }

    public Task InitializeAsync()
    {
        throw new NotImplementedException();
    }

    public Task DisposeAsync()
    {
        throw new NotImplementedException();
    }
}
