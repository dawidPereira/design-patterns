﻿using System;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.CreationalPattern.Singleton
{
    public static class ServiceProviderInstance
    {
        private static IServiceProvider _serviceProvider = null;

        public static IServiceProvider GetServiceProvider()
        {
            return _serviceProvider ?? (_serviceProvider = new ServiceCollection().Configure());
        }
    }
}