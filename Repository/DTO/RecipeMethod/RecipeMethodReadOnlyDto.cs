namespace Repository.DTO.RecipeMethod
{
    public class RecipeMethodReadOnlyDto : BaseDto
    {
       
        public string RecipeId { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public bool Optional { get; set; }
        public bool IsDeleted { get; set; }
    }
}
