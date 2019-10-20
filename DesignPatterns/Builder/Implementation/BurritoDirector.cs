using System;
using DesignPatterns.Builder.Entity;
using DesignPatterns.Builder.Interface;

namespace DesignPatterns.Builder.Implementation
{
    public class BurritoDirector : IBurritoDirector
    {
        private readonly  Func<BurritoBuilderTypes, IBurritoBuilder> _builder;

        public BurritoDirector(Func<BurritoBuilderTypes, IBurritoBuilder> builder)
        {
            _builder = builder;
        }

        public Burrito BuildVegeBurrito(int spiciness, BurritoBuilderTypes builderType)
        {
            return _builder(builderType)
                .WithCheese()
                .WithNachos()
                .Build(spiciness);
        }

        public Burrito BuildBurritoWithMeat(int spiciness, string meat, BurritoBuilderTypes builderType)
        {
            return _builder(builderType)
                .WithCheese()
                .WithNachos()
                .WithMeat(meat)
                .Build(spiciness);
        }
    }
}
