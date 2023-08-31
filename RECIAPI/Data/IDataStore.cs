namespace RECIAPI.Data;

public interface IDataStore
{
    Recipe AddRecipe(Recipe recipe);
    // remove studnet
    //get student
    Recipe UpdateRecipe(Recipe recipe);
}

public class InMemoryDataStore :IDataStore
{
    private List<Recipe> recipes = new List<Recipe>();
    public Recipe AddRecipe(Recipe recipe)
    {
        return recipe;
    }

    public Recipe UpdateRecipe(Recipe recipe)
    {
        return recipe;
    }
}


public class Recipe
{
    public List<Ingredient> Ingredients { get; set; }
}


public class Ingredient
{
    // name quantity unit
}
