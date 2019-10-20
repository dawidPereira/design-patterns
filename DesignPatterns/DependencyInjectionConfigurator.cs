using System;
using DesignPatterns.Builder;
using DesignPatterns.Factory;
using DesignPatterns.Factory.AbstractFactory;
using DesignPatterns.Factory.FactoryMethod;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns
{
    public static class DependencyInjectionConfigurator
    {
        public static IServiceProvider Configure(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddBuilder()
                .AddFactoryMethod()
                .AddAbstractFactory()
                .BuildServiceProvider();
        }
    }
}