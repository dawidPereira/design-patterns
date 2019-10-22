using DesignPatterns.CreationalPattern.Factory.FactoryMethod.Implementation;
using DesignPatterns.CreationalPattern.Factory.FactoryMethod.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.CreationalPattern.Factory.FactoryMethod
{
    public static class FactoryMethodDependencyInjectionConfigurator
    {
        public static IServiceCollection AddFactoryMethod(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<IStudentFactory, StudentFactory>();
        }
    }
}
