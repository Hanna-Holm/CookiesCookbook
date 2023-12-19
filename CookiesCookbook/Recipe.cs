
namespace CookiesCookbook
{
    internal class Recipe
    {
        private List<Ingredient> ingredients { get; set; }

        public Recipe(List<Ingredient> ingredients)
        {
            this.ingredients = ingredients;
        }
    }
}
