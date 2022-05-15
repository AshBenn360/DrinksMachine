using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Recipe
    {
        [Key]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<RecipeMethod> RecipeMethod { get; set; }
        public bool IsDeleted { get; set; }
    }
}