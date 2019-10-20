using DesignPatterns.Builder.Entity;

namespace DesignPatterns.Builder.Interface
{
    public interface IBurritoDirector
    {
        Burrito BuildVegeBurrito(int spiciness, BurritoBuilderTypes builderType = BurritoBuilderTypes.DefaultBuilder);

        Burrito BuildBurritoWithMeat(int spiciness, string meat, BurritoBuilderTypes builderType = BurritoBuilderTypes.DefaultBuilder);
    }
}
