namespace NoticiasApi.tests;

public class IntegrationTests : IClassFixture<DockerFixture>
{
    private readonly DockerFixture _dockerFixture;

    public IntegrationTests(DockerFixture dockerFixture)
    {
        _dockerFixture = dockerFixture;
    }
}
