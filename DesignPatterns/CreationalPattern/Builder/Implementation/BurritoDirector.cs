using DesignPatterns.CreationalPattern.Builder.Entity;
using DesignPatterns.CreationalPattern.Builder.Interface;
using BurritoBuilderResolver = DesignPatterns.CreationalPattern.Builder.BuilderDependencyInjectionConfigurator.BurritoBuilderResolver;

namespace DesignPatterns.CreationalPattern.Builder.Implementation
{
    public class BurritoDirector : IBurritoDirector
    {
        private readonly  BurritoBuilderResolver _builder;

        public BurritoDirector(BurritoBuilderResolver builder)
        {
            _builder = builder;
        }

        public Burrito BuildVegeBurrito(int spiciness, Builder.BurritoBuilder builder)
        {
            return _builder(builder)
                .WithCheese()
                .WithNachos()
                .Build(spiciness);
        }

        public Burrito BuildBurritoWithMeat(int spiciness, string meat, Builder.BurritoBuilder builder)
        {
            return _builder(builder)
                .WithCheese()
                .WithNachos()
                .WithMeat(meat)
                .Build(spiciness);
        }
    }
}
