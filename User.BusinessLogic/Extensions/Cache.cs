﻿using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace User.BusinessLogic.Extensions;

internal static class Cache
{
    private static readonly string? lifetime = Environment.GetEnvironmentVariable("CACHE_LIFETIME");
    private const double defaultLifetime = 3.0;

    public static async Task<T?> GetDataFromCacheAsync<T>(this IDistributedCache distributedCache, string key, CancellationToken cancellationToken)
    {
        var cache = await distributedCache.GetStringAsync(key, cancellationToken);

        if (cache is null)
            return default;

        var data = JsonConvert.DeserializeObject<T>(cache)!;

        return data;
    }

    public static async Task CacheData<T>(this IDistributedCache distributedCache, T data, string key, CancellationToken cancellationToken)
    {
        if (data is null)
            return;

        if (!double.TryParse(lifetime, out var lifetimeMinutes))
            lifetimeMinutes = defaultLifetime;

        var serializedData = JsonConvert.SerializeObject(data);

        var options = new DistributedCacheEntryOptions
        {
            SlidingExpiration = TimeSpan.FromMinutes(lifetimeMinutes)
        };

        await distributedCache.SetStringAsync(key, serializedData, options, cancellationToken);
    }
}