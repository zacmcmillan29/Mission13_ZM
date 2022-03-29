using System;
using Microsoft.EntityFrameworkCore;

namespace MySQLFun.Models
{
    public class RecipesDBContext : DbContext
    {
        public RecipesDBContext(DbContextOptions<RecipesDBContext> options) : base (options)
        {
            //leave blank
        }

        //create the dataset!!
        public DbSet<Recipe> Recipes { get; set; }
    }
}
