using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.WorkOs.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class WorkOsOpenApiClientRunnerTests : FixturedUnitTest
{
    public WorkOsOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
