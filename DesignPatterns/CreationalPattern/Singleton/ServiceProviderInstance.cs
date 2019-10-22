using System;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.CreationalPattern.Singleton
{
    public class ServiceProviderInstance
    {
        private static IServiceProvider _serviceProvider;

        private static ServiceProviderInstance _instance;

        private ServiceProviderInstance()
        {
            _serviceProvider = new ServiceCollection().Configure();
        }

        public static  ServiceProviderInstance GetInstance()
        {
            lock (_serviceProvider)
            {
                return _instance ?? (_instance = new ServiceProviderInstance());
            }
        }

        public IServiceProvider GetServiceProvider() => _serviceProvider;
    }
}
