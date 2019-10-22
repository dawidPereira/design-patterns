using DesignPatterns.CreationalPattern.Builder.Implementation;
using DesignPatterns.CreationalPattern.Builder.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.CreationalPattern.Builder
{
    public static class BuilderDependencyInjectionConfigurator
    {
        public delegate IBurritoBuilder BurritoBuilderResolver(BurritoBuilder key);

        public static IServiceCollection AddBuilder(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<IBurritoDirector, BurritoDirector>()
                .ConfigureBurritoBuilder();
        }

        private static IServiceCollection ConfigureBurritoBuilder(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<Implementation.BurritoBuilder>()
                .AddTransient<BurritoBuilderResolver>(serviceProvider => key =>
                {
                    switch (key)
                    {
                        case BurritoBuilder.Burrito:
                            return serviceProvider.GetService<Implementation.BurritoBuilder>();

                        default:
                            return serviceProvider.GetService<Implementation.BurritoBuilder>();
                    }
                });
        }
    }
}
