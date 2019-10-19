using System;
using DesignPatterns.Builder.Interface;

namespace DesignPatterns.Builder.Implementation
{
    public class BurritoDirector : IBurritoDirector
    {
        private readonly  Func<string, IBurritoBuilder> _builder;

        public BurritoDirector(Func<string, IBurritoBuilder> builder)
        {
            _builder = builder;
        }

        public Burrito BuildVegeBurrito(int spiciness, string builderType)
        {
            return _builder(builderType)
                .WithCheese()
                .WithNachos()
                .Build(spiciness);
        }

        public Burrito BuildBurritoWithMeat(int spiciness, string meat, string builderType)
        {
            return _builder("test")
                .WithCheese()
                .WithNachos()
                .WithMeat(meat)
                .Build(spiciness);
        }
    }
}
