using DesignPatterns.CreationalPattern.Builder;
using DesignPatterns.CreationalPattern.Builder.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.CreationalPattern
{
    public class BurritoDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var burritoDirector = ServiceProvider.GetService<IBurritoDirector>();

            burritoDirector.BuildBurritoWithMeat(3, "Chicken", BurritoBuilder.Burrito);
            burritoDirector.BuildVegeBurrito(1);
        }
    }
}
