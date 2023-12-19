
namespace CookiesCookbook
{
    internal abstract class Ingredient
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string PreparationInstructions { get; set; }

        public void PrintIdAndName()
        {
            Console.WriteLine($"{Id}. {Name}");
        }

        public void Print()
        {
            Console.WriteLine($"{Id}. {Name}: {PreparationInstructions}");
        }
    }
}
