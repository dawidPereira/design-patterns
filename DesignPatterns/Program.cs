using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection().Configure();

            var logger = serviceProvider
                .GetService<ILoggerFactory>()
                .CreateLogger<Program>();
            
            logger.LogInformation("Show log");

            Console.ReadKey();
        }
    }
}
