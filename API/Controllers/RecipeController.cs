using API.Static;
using AutoMapper;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.DTO.Recipe;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeRepository recipeRepository;
        private readonly IMapper mapper;

        public RecipeController(IRecipeRepository recipeRepository, IMapper mapper)
        {
            this.recipeRepository = recipeRepository;
            this.mapper = mapper;
        }


        // GET: api/<ReipeController>
        [HttpGet]
       public async Task<ActionResult<IEnumerable<RecipeReadOnlyDto>>> GetRecipes()
        {
            try
            {
                var recipes = await recipeRepository.GetAllAsync();
                var recipesDtos = mapper.Map<IEnumerable<RecipeReadOnlyDto>>(recipes);

                return Ok(recipesDtos);
            }
            catch (Exception)
            {

                return StatusCode(500, Messages.Error500Message);
            }
          ;
        }

        // GET api/<ReipeController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RecipeDetailsDto>> GetRecipe(string id)
        {
            try
            {
                var recipe = await recipeRepository.GetRecipeDetailsAsync(id);

                if (recipe == null)
                {
                    return NotFound();
                }

                return Ok(recipe);  
            }
            catch (Exception)
            {

                return StatusCode(500, Messages.Error500Message);
            }
        }

        // POST api/<ReipeController>
        [HttpPost]
        public async Task<ActionResult<RecipeCreateDto>>PostRecipe(RecipeCreateDto recipeDto)
        {
            try
            {
                var recipe = mapper.Map<Recipe>(recipeDto);
                await recipeRepository.AddAsync(recipe);

                return CreatedAtAction(nameof(GetRecipe), new { id = recipe.Id }, recipe);
            }
            catch (Exception)
            {

                return StatusCode(500, Messages.Error500Message);
            }
        }

        // PUT api/<ReipeController>/5
        [HttpPut("{id}")]
        public async Task <IActionResult> PutRecipe(string id, RecipeUpdateDto recipeDto)
        {
            if (id != recipeDto.Id)
            {
                return BadRequest();
            }

            var recipe = await recipeRepository.GetAsync(id);

            if (recipe == null)
            {
                return NotFound();
            }

            mapper.Map(recipeDto, recipe);

            try
            {
                await recipeRepository.UpdateAsync(recipe);
            }
            catch (DbUpdateConcurrencyException ex)
            {

                if (!await RecipeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    return StatusCode(500, Messages.Error500Message);
                }
            }

            return NoContent();

        }

        

        private async Task<bool> RecipeExists(string id)
        {
            return await recipeRepository.Exists(id);
        }
    }
}
