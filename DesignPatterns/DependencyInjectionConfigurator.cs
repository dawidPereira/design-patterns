using System;
using DesignPatterns.CreationalPattern.Builder;
using DesignPatterns.CreationalPattern.Factory.AbstractFactory;
using DesignPatterns.CreationalPattern.Factory.FactoryMethod;
using DesignPatterns.CreationalPattern.Interface;
using CreationalPatternImplementation = DesignPatterns.CreationalPattern.Implementation.CreationalPattern;
using Microsoft.Extensions.DependencyInjection;
using DesignPatterns.StructuralPattern;

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
                .AddStructuralPattern()
                .AddTransient<ICreationalPattern, CreationalPatternImplementation>()
                .BuildServiceProvider();

        }
    }
}