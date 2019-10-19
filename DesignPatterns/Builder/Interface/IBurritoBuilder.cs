using DesignPatterns.Builder.Implementation;

namespace DesignPatterns.Builder.Interface
{
    public interface IBurritoBuilder
    {
        IBurritoBuilder WithCheese();

        IBurritoBuilder WithMeat(string meet);

        IBurritoBuilder WithNachos();

        Burrito Build(int spiciness);
    }
}
