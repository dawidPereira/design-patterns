using System;
using DesignPatterns.BehavioralPattern;
using DesignPatterns.CreationalPattern;
using DesignPatterns.CreationalPattern.Builder;
using DesignPatterns.CreationalPattern.Factory.AbstractFactory;
using DesignPatterns.CreationalPattern.Factory.FactoryMethod;
using CreationalPatternImplementation = DesignPatterns.CreationalPattern.CreationalPattern;
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
                .AddBehavioralPattern()
                .AddCreationalPattern()
                .BuildServiceProvider();

        }
    }
}