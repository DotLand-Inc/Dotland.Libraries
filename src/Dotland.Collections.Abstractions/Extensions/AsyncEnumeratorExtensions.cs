namespace Dotland.Collections.Abstractions.Extensions;

public static class AsyncEnumeratorExtensions
{
    public static async Task<ICollection<T>> ToListAsync<T>(this IAsyncEnumerator<T> asyncEnumerator)
    {
        var result = new List<T>();

        while (await asyncEnumerator.MoveNextAsync())
        {
            result.Add(asyncEnumerator.Current);
        }

        return result;
    }

    public static async Task<T?> FirstOrDefaultAsync<T>(this IAsyncEnumerator<T> asyncEnumerator)
    {
        if (await asyncEnumerator.MoveNextAsync())
        {
            return asyncEnumerator.Current;
        }

        return default;
    }
}