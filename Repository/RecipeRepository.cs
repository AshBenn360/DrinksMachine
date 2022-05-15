
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Repository.DTO.Recipe;

namespace Repository
{
    public class RecipeRepository : GenericRepository<Recipe>, IRecipeRepository
    {
        private readonly DataContext context;
        private readonly IMapper mapper;

        public RecipeRepository(DataContext context, IMapper mapper) : base(context, mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<RecipeDetailsDto> GetRecipeDetailsAsync(string id)
        {
            return await context.Recipes
                .Include(x => x.RecipeMethod.OrderBy(y=> y.Order))
                .ProjectTo<RecipeDetailsDto>(mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }

    
}
