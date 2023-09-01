namespace RECIAPI.Data;

public interface IDataStore
{
    Task<IEnumerable<Recipe>> GetAllRecipes();
    Task<Recipe> GetRecipe(int id);
    Task<Recipe> AddRecipe(Recipe recipe);
    // remove studnet
    //get student
    Task<Recipe> UpdateRecipe(Recipe recipe);
    Task DeleteRecipe(int id);
}

public class InMemoryDataStore : IDataStore
{
    private List<Recipe> recipes = new List<Recipe>();

    public Task DeleteRecipe(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Recipe> GetRecipe(int id)
    {
        throw new NotImplementedException();
    }

    Task<Recipe> IDataStore.AddRecipe(Recipe recipe)
    {
        // recipe.ID = recipes.count
        recipes.Add(recipe);
        return Task.FromResult(recipe);
    }

    Task<IEnumerable<Recipe>> IDataStore.GetAllRecipes()
    {
        throw new NotImplementedException();
    }

    Task<Recipe> IDataStore.UpdateRecipe(Recipe recipe)
    {
        throw new NotImplementedException();
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
