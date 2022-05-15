using API.Static;
using AutoMapper;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.DTO.RecipeMethod;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeMethodController : ControllerBase
    {


        private readonly IRecipeMethodRepository recipeMethodRepository;
        private readonly IMapper mapper;

        public RecipeMethodController(IRecipeMethodRepository recipeMethodRepository, IMapper mapper)
        {
            this.recipeMethodRepository = recipeMethodRepository;
            this.mapper = mapper;
        }

        // GET: api/<ReicpeMethodController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecipeMethodReadOnlyDto>>> GetRecipeMethods()
        {
            try
            {
                var recipeMethods = await recipeMethodRepository.GetAllAsync();
                var recipeMethodsDtos = mapper.Map<IEnumerable<RecipeMethodReadOnlyDto>>(recipeMethods);

                return Ok(recipeMethodsDtos);
            }
            catch (Exception)
            {

                return StatusCode(500, Messages.Error500Message);
            }
           
        }

        // GET api/<ReicpeMethodController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RecipeMethodReadOnlyDto>> GetRecipe(string id)
        {
            try
            {
                var recipeMethod = await recipeMethodRepository.GetAsync(id);

                if (recipeMethod == null)
                {
                    return NotFound();
                }

                return Ok(recipeMethod);
            }
            catch (Exception)
            {

                return StatusCode(500, Messages.Error500Message);
            }
        }


        // POST api/<ReicpeMethodController>
        [HttpPost]
        public async Task<ActionResult<RecipeMethodCreateDto>> PostRecipeMethod(RecipeMethodCreateDto recipeMethodDto)
        {
            try
            {
                var recipeMethod = mapper.Map<RecipeMethod>(recipeMethodDto);
                await recipeMethodRepository.AddAsync(recipeMethod);

                return CreatedAtAction(nameof(GetRecipe), new { id = recipeMethod.Id }, recipeMethod);
            }
            catch (Exception)
            {

                return StatusCode(500, Messages.Error500Message);
            }
        }

        // PUT api/<ReicpeMethodController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecipe(string id, RecipeMethodUpdateDto recipeDto)
        {
            if (id != recipeDto.Id)
            {
                return BadRequest();
            }

            var recipe = await recipeMethodRepository.GetAsync(id);

            if (recipe == null)
            {
                return NotFound();
            }

            mapper.Map(recipeDto, recipe);

            try
            {
                await recipeMethodRepository.UpdateAsync(recipe);
            }
            catch (DbUpdateConcurrencyException ex)
            {

                if (!await RecipeMethodExists(id))
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

        private async Task<bool> RecipeMethodExists(string id)
        {
            return await recipeMethodRepository.Exists(id);
        }
    }
}

