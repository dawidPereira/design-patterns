using System;
using DesignPatterns.Factory.AbstractFactory.Implementation;
using DesignPatterns.Factory.AbstractFactory.Interface;
using DesignPatterns.Factory.FactoryMethod;
using DesignPatterns.FactoryMethod;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Factory.AbstractFactory
{
    public static class AbstractFactoryDIConfiguration
    {
        public static IServiceCollection AddAbstractFactory(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<EnglishSchoolMemberFactory>()
                .AddTransient<PolishSchoolMemberFactory>()
                .ConfigureShoolMemberFactory();
        }

        public static Func<ShoolMemberType, IServiceProvider, ISchoolMemberFactory> GetSchoolMemberFactory = 
            delegate (ShoolMemberType schoolMemberType, IServiceProvider serviceProvider)
                {
                    switch (schoolMemberType)
                    {
                        case ShoolMemberType.PolishStudent:
                                return serviceProvider.GetService<PolishSchoolMemberFactory>();

                        case ShoolMemberType.EnglishStudent:
                                return serviceProvider.GetService<EnglishSchoolMemberFactory>();

                        default:
                                return serviceProvider.GetService<PolishSchoolMemberFactory>();
                    }
                };

        private static IServiceCollection ConfigureShoolMemberFactory(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<Func<ShoolMemberType, ISchoolMemberFactory>>(serviceProvider => key 
                    => GetSchoolMemberFactory(key, serviceProvider));
        }
    }
}
