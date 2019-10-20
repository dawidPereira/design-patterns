using DesignPatterns.FactoryMethod.Implementation;
using DesignPatterns.FactoryMethod.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.FactoryMethod
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
