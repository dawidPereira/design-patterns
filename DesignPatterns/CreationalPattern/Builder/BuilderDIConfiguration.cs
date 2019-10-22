using DesignPatterns.CreationalPattern.Builder.Implementation;
using DesignPatterns.CreationalPattern.Builder.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.CreationalPattern.Builder
{
    public static class BuilderDependencyInjectionConfigurator
    {
        public delegate IBurritoBuilder BurritoBuilderResolver(BurritoBuilderTypes key);

        public static IServiceCollection AddBuilder(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<IBurritoDirector, BurritoDirector>()
                .ConfigureBurritoBuilder();
        }

        private static IServiceCollection ConfigureBurritoBuilder(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<BurritoBuilder>()
                .AddTransient<BurritoBuilderResolver>(serviceProvider => key =>
                {
                    switch (key)
                    {
                        case BurritoBuilderTypes.BurritoBuilder:
                            return serviceProvider.GetService<BurritoBuilder>();

                        default:
                            return serviceProvider.GetService<BurritoBuilder>();
                    }
                });
        }
    }
}
