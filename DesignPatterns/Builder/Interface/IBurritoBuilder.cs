using DesignPatterns.Builder.Entity;

namespace DesignPatterns.Builder.Interface
{
    public interface IBurritoBuilder
    {
        IBurritoBuilder WithCheese();

        IBurritoBuilder WithMeat(string meat);

        IBurritoBuilder WithNachos();

        Burrito Build(int spiciness);
    }
}
