using DesignPatterns.Factory.AbstractFactory.Implementation;
using DesignPatterns.Factory.AbstractFactory.Interface;
using DesignPatterns.FactoryMethod;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DesignPatterns.Factory
{
    public static class AbstractFactoryDIConfiguration
    {
        public static IServiceCollection AddAbstractFactory(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<EnglishShoolMemberFactory>()
                .AddTransient<PolishShoolMemberFactory>()
                .ConfigureShoolMemberFactory();
        }

        public static Func<ShoolMemberType, IServiceProvider, IShoolMemberFactory> getShoolMemberFactory = 
            delegate (ShoolMemberType shoolMemberType, IServiceProvider serviceProvider)
                {
                    switch (shoolMemberType)
                    {
                        case ShoolMemberType.PolishStudent:
                            {
                                return serviceProvider.GetService<PolishShoolMemberFactory>();
                            }
                        case ShoolMemberType.EnglishStudent:
                            {
                                return serviceProvider.GetService<EnglishShoolMemberFactory>();
                            }
                        default:
                            {
                                return serviceProvider.GetService<PolishShoolMemberFactory>();
                            }
                    }
                };

        private static IServiceCollection ConfigureShoolMemberFactory(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<Func<ShoolMemberType, IShoolMemberFactory>>(serviceProvider => key =>
                {
                    return getShoolMemberFactory(key, serviceProvider);
                });
        }
    }
}
