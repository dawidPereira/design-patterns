using DesignPatterns.CreationalPattern.Builder.Entity;

namespace DesignPatterns.CreationalPattern.Builder.Interface
{
    public interface IBurritoDirector
    {
        Burrito BuildVegeBurrito(int spiciness, BurritoBuilder builder = BurritoBuilder.Default);

        Burrito BuildBurritoWithMeat(int spiciness, string meat, BurritoBuilder builder = BurritoBuilder.Default);
    }
}
