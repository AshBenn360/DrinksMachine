using Repository.DTO.RecipeMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DTO.Recipe
{
    public class RecipeDetailsDto : RecipeReadOnlyDto
    {
        public List<RecipeMethodReadOnlyDto> RecipeMethod { get; set; }
    }
}
