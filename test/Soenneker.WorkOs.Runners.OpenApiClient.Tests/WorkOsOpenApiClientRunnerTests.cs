using Soenneker.Tests.HostedUnit;

namespace Soenneker.WorkOs.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class WorkOsOpenApiClientRunnerTests : HostedUnitTest
{
    public WorkOsOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
