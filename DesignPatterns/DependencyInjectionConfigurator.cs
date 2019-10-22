using System;
using DesignPatterns.CreationalPattern.Builder;
using DesignPatterns.CreationalPattern.Factory.AbstractFactory;
using DesignPatterns.CreationalPattern.Factory.FactoryMethod;
using DesignPatterns.CreationalPattern.Interface;
using CreationalPatternImplementation = DesignPatterns.CreationalPattern.Implementation.CreationalPattern;
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
                .AddTransient<ICreationalPattern, CreationalPatternImplementation>()
                .BuildServiceProvider();
        }
    }
}