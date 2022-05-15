using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class RecipeMethod 
    {
       
        public string Id { get; set; }
        public string RecipeId { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public bool Optional { get; set; }
        public bool IsDeleted { get; set; }
    }
}