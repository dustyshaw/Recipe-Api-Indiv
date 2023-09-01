using Microsoft.AspNetCore.Mvc;
using RECIAPI.Data;

namespace RECIAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class RecipeController : ControllerBase
{
    private readonly ILogger<RecipeController> _logger;
    private readonly IDataStore _dataStore;
    private static List<Recipe> _recipes = new();

    public RecipeController(ILogger<RecipeController> logger, IDataStore dataStore)
    {
        _dataStore = dataStore;
        _logger = logger;
        _recipes = new();
    }

    [HttpGet()]
    public IEnumerable<Recipe> Get()
    {
        return _recipes;
        //return datStore.GetAllRecipes();
    }

    [HttpGet("{id}")]       // get recipe by ID
    public async Task<Recipe> Get(int id)
    {
        //return dataStore.GetRecipe();
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<Recipe> Post([FromBody] Recipe recipe)
    {
        // recipe.Id = _recipe.count
        var newRecipe = await _dataStore.AddRecipe(recipe);
        return newRecipe;
    }
}


