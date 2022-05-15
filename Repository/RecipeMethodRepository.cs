using AutoMapper;
using Domain;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RecipeMethodRepository : GenericRepository<RecipeMethod>, IRecipeMethodRepository
    {
        private readonly DataContext context;
        private readonly IMapper mapper;

        public RecipeMethodRepository(DataContext context, IMapper mapper) : base(context, mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

      
    }
}
