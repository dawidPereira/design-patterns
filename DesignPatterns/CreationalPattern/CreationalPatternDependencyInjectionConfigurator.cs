using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.CreationalPattern
{
    public static class CreationalPatternDependencyInjectionConfigurator
    {
        public static IServiceCollection AddCreationalPattern(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<ICreationalPattern, CreationalPattern>();
        }
    }
}