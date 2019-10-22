using DesignPatterns.CreationalPattern.Builder.Entity;

namespace DesignPatterns.CreationalPattern.Builder.Interface
{
    public interface IBurritoBuilder
    {
        IBurritoBuilder WithCheese();

        IBurritoBuilder WithMeat(string meat);

        IBurritoBuilder WithNachos();

        Burrito Build(int spiciness);
    }
}
