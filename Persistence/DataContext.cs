using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<RecipeMethod> RecipeMethods { get; set; }


    }
}