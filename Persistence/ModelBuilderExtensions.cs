using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasData(
                  new Recipe
                  {
                      Id = Guid.NewGuid().ToString(),
                      Title = "Lemon Tea",
                      Description = "Hong Kong speciality is lemon tea - " +
                            "served in cafes and restaurants as regular black tea " +
                            "with several slices of fresh lemon, either hot or cold, " +
                            "with a pot of sugar to add to taste.",

                  },


                      new Recipe
                      {
                          Id = Guid.NewGuid().ToString(),
                          Title = "Coffee",
                          Description = "Coffee is a brewed drink prepared from roasted coffee beans," +
                                     " the seeds of berries from certain flowering plants in the Coffea genus. " +
                                     "From the coffee fruit, the seeds are separated to produce a stable," +
                                     " raw product: unroasted green coffee.",
                        
                      },
                     new Recipe
                     {
                         Id = Guid.NewGuid().ToString(),
                         Title = "Hot chocolate",
                         Description = "Hot chocolate, also known as hot cocoa or drinking chocolate," +
                                      " is heated chocolate milk. Hot chocolate made with melted chocolate is sometimes " +
                                      "called drinking chocolate, characterized by less sweetness and a thicker consistency.",
                         
                         IsDeleted = false,
                     }
                );

            modelBuilder.Entity<RecipeMethod>().HasData(
                    new RecipeMethod
                    {
                        Id= Guid.NewGuid().ToString(),
                        RecipeId= "2e12f26b-d06e-47f2-8d00-d5b316fc8abc",
                        Description= "Boil some water",
                        Order = 1,
                        IsDeleted= false,
                    },
                    new RecipeMethod
                    {
                        Id = Guid.NewGuid().ToString(),
                        RecipeId = "2e12f26b-d06e-47f2-8d00-d5b316fc8abc",
                        Description = "Steep the water in the tea",
                        Order = 2,
                        IsDeleted = false,
                    },
                    new RecipeMethod
                    {
                        Id = Guid.NewGuid().ToString(),
                        RecipeId = "2e12f26b-d06e-47f2-8d00-d5b316fc8abc",
                        Description = "Pour tea in the cup",
                        Order = 3,
                        IsDeleted = false,
                    },
                    new RecipeMethod
                    {
                        Id = Guid.NewGuid().ToString(),
                        RecipeId = "2e12f26b-d06e-47f2-8d00-d5b316fc8abc",
                        Description = "Add lemon",
                        Order = 4,
                        IsDeleted = false,
                    }
                );

        }
    }
}
