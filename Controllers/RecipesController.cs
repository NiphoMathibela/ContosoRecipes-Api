using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace ContosoRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetRecipes([FromQuery]int count)
        {
            Models.Recipe[] recipes = { 
                new() {Title = "Oxtail"},
                new() {Title = "Lamb Curry"},
                new() {Title = "Mash Potatoes"}
            };

            return Ok(recipes.Take(count));
        }

        [HttpPost]
        public ActionResult CreatRecipes([FromBody] Models.Recipe newRecipe)
        {
            bool badThingsHappened = false;

            if(badThingsHappened)
            {
                return BadRequest();
            }
            else
            {
                return Created("", newRecipe);
            }
        }
    }
}
