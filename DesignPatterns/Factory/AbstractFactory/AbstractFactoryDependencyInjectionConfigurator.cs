using System;
using DesignPatterns.Factory.AbstractFactory.Implementation;
using DesignPatterns.Factory.AbstractFactory.Interface;
using DesignPatterns.Factory.FactoryMethod;
using DesignPatterns.FactoryMethod;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Factory.AbstractFactory
{
    public static class AbstractFactoryDependencyInjectionConfigurator
    {
        public static IServiceCollection AddAbstractFactory(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<EnglishSchoolMemberFactory>()
                .AddTransient<PolishSchoolMemberFactory>()
                .ConfigureSchoolMemberFactory();
        }

        private static IServiceCollection ConfigureSchoolMemberFactory(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<Func<SchoolMemberType, ISchoolMemberFactory>>(serviceProvider => key =>
                    SchoolMemberFactoryExtension.GetSchoolMemberFactory(key, serviceProvider));
        }
    }
}
