﻿using System;
using DesignPatterns.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns
{
    public static class DIConfiguration
    {
        public static IServiceProvider Configure(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddBuilder()
                .BuildServiceProvider();
        }
    }
}