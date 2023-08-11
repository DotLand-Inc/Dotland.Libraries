using Dotland.Extensions.Collections.Abstractions;
using FluentAssertions;

namespace Dotland.Extensions.Abstractions.Tests.Extensions;

public class AsyncEnumeratorExtensionsTests
{
    [Theory]
    [InlineData(0)]
    [InlineData(5)]
    public async Task ToListAsyncReturnsExpectedCountTest(int size)
    {
        var collectionResult = await GetCollectionOfSize(size).ToListAsync();

        collectionResult.Count.Should().Be(size);
    }

    [Fact]
    public async Task FirstOrDefaultAsyncReturnsExpectedWhenListIsNotEmptyTest()
    {
        const int size = 10;
        var item = await GetCollectionOfSize(size).FirstOrDefaultAsync();

        item.Should().NotBeNullOrWhiteSpace();
        item!.StartsWith("0", StringComparison.Ordinal).Should().BeTrue();
    }

    [Fact]
    public async Task FirstOrDefaultAsyncReturnsNullWhenListIsEmptyTest()
    {
        var item = await GetCollectionOfSize(0).FirstOrDefaultAsync();

        item.Should().BeNull();
    }

    private async IAsyncEnumerator<string> GetCollectionOfSize(int size)
    {
        await Task.Yield();
        for (var i = 0; i < size; i++)
        {
            yield return $"{i} Item";
        }
    }
}