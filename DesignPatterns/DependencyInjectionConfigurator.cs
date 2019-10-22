using System;
using DesignPatterns.CreationalPattern.Builder;
using DesignPatterns.CreationalPattern.Factory.AbstractFactory;
using DesignPatterns.CreationalPattern.Factory.FactoryMethod;
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