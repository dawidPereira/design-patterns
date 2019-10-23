using System;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.CreationalPattern.Singleton
{
    public class ServiceProviderInstance
    {
        private static IServiceProvider _serviceProvider;

        private static volatile ServiceProviderInstance _instance;
        private static readonly object LockObject = new object();

        private ServiceProviderInstance()
        {
            _serviceProvider = new ServiceCollection().Configure();
        }

        public static  ServiceProviderInstance GetInstance()
        {
            if (_instance != null)
            {
                return _instance;
            }

            lock (LockObject)
            {
                if (_instance == null)
                {
                    _instance = new ServiceProviderInstance();
                }
            }

            return _instance;
        }

        public IServiceProvider GetServiceProvider() => _serviceProvider;
    }
}
