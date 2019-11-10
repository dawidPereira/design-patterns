using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.BehavioralPattern
{
    public static class BehavioralPatternDependencyInjectionConfigurator
    {
        public static IServiceCollection AddBehavioralPattern(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<IBehavioralPattern, BehavioralPattern>();
        }
    }
}