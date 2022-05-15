
using AutoMapper;
using Domain;
using Repository.DTO.Recipe;
using Repository.DTO.RecipeMethod;

namespace API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<RecipeReadOnlyDto, Recipe>().ReverseMap();
            CreateMap<RecipeDetailsDto, Recipe>().ReverseMap();
            CreateMap<RecipeCreateDto, Recipe>().ReverseMap();
            CreateMap<RecipeUpdateDto, Recipe>().ReverseMap();

            CreateMap<RecipeMethod, RecipeMethodReadOnlyDto>();
            CreateMap<RecipeMethodCreateDto, RecipeMethod>().ReverseMap();
            CreateMap<RecipeMethodUpdateDto, RecipeMethod>().ReverseMap();



        }
       
        

    }
}
