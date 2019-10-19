namespace DesignPatterns.Builder.Interface
{
    public interface IBurritoDirector
    {
        Burrito BuildVegeBurrito(int spiciness, string builderType = BurritoBuilderTypes.DefaultBuilder);

        Burrito BuildBurritoWithMeat(int spiciness, string meat, string builderType = BurritoBuilderTypes.DefaultBuilder);
    }
}
