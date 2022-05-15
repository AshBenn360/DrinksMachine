using System.ComponentModel.DataAnnotations;

namespace Repository.DTO.Recipe
{
    public class RecipeCreateDto : BaseDto
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
