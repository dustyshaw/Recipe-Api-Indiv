using Microsoft.AspNetCore.Mvc;

namespace RECIAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class RecipeController : ControllerBase
{
    private readonly ILogger<RecipeController> _logger;
    private static List<Recipe> _recipes = new();

    public RecipeController(ILogger<RecipeController> logger)
    {
        _logger = logger;
        _recipes = new();
    }

    [HttpGet()]
    public IEnumerable<Recipe> Get()
    {
        return _recipes;
    }

    [HttpGet("{id}")]       // get recipe by ID
    public Recipe Get(int id)
    {
        return _recipes[id];
    }

    [HttpPost]
    public Recipe Post(Recipe recipe)
    {
        // recipe.Id = _recipe.count
        //_recipes.Add(recipe)
        //return recipe;
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