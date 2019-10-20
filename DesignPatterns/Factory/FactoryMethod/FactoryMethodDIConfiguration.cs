using DesignPatterns.Factory.FactoryMethod.Implementation;
using DesignPatterns.Factory.FactoryMethod.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Factory.FactoryMethod
{
    public static class FactoryMethodDIConfiguration
    {
        public static IServiceCollection AddFactoryMethod(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<IStudentFactory, StudentFactory>();
        }
    }
}
