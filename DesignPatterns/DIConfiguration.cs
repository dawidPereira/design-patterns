using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DesignPatterns
{
    public static class DIConfiguration
    {
        public static ServiceProvider Configure(this ServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddLogging(builder => { builder.AddConsole(); })
                .BuildServiceProvider();
        }
    }
}