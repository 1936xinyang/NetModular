﻿using Microsoft.Extensions.DependencyInjection;
using Nm.Lib.Cache.Abstractions;

namespace Nm.Lib.Cache.MemoryCache
{
    public class ServiceCollectionConfig : IServiceCollectionConfig
    {
        public IServiceCollection Config(IServiceCollection services)
        {
            services.AddMemoryCache();

            services.AddSingleton<ICacheHandler, MemoryCacheHandler>();

            return services;
        }
    }
}
