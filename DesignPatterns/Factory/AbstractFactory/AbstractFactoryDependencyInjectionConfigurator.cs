using DesignPatterns.Factory.AbstractFactory.Implementation;
using DesignPatterns.Factory.AbstractFactory.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Factory.AbstractFactory
{
    public static class AbstractFactoryDependencyInjectionConfigurator
    {
        public delegate ISchoolMemberFactory SchoolMemberFactoryResolver(SchoolMemberType key);

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
                .AddTransient<SchoolMemberFactoryResolver>(serviceProvider => key =>
                    SchoolMemberFactoryExtension.GetSchoolMemberFactory(key, serviceProvider));
        }
    }
}
