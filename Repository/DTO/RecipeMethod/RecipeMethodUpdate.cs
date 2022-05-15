using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DTO.RecipeMethod
{
    public class RecipeMethodUpdateDto :BaseDto
    {
        [Required]
        public string RecipeId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Order { get; set; }
        [Required]
        public bool Optional { get; set; }
        public bool IsDeleted
        {
            get; set;
        }

    }
}
