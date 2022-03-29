using System;
using System.Linq;

namespace MySQLFun.Models
{
    public class EFRecipesRepository : IRecipesRepository
    {

        private RecipesDBContext _context { get; set; }

        public EFRecipesRepository (RecipesDBContext temp)
        {
            _context = temp;
        }

        public IQueryable<Recipe> Recipes => _context.Recipes;

        //IQueryable<Recipe> IRecipesRepository.Recipes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
