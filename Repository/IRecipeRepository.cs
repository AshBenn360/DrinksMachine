using Domain;
using Repository.DTO.Recipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRecipeRepository : IGenericRepository<Recipe>
    {
        Task<RecipeDetailsDto> GetRecipeDetailsAsync(string id);
    }
}
