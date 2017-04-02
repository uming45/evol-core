﻿using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Website.Cache
{
    public  class DemoCache
    {
        private static MemoryCache _cache;

        private static bool inited = false;

        public static void Init(IOptions<MemoryCacheOptions> options)
        {
            if (inited)
                return;
            _cache = new MemoryCache(options);
            inited = true;
        }

        public static void Set<TItem>(object key, TItem value)
        {
            _cache.Set(key, value, TimeSpan.FromMinutes(10));
        }

        public static void Get<TItem>(object key, TItem value)
        {
            object value;
            _cache.TryGetValue(key, out value);
        }
    }
}
