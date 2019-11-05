using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.StructuralPattern
{
    public static class StructuralPatternDependencyInjectionConfigurator
    {
        public static IServiceCollection AddStructuralPattern(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<IStructuralPattern, StructuralPattern>();
        }
    }
}
