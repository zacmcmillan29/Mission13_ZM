using System;
using System.Linq;

namespace MySQLFun.Models
{
    public class EFBowlersRepository : IBowlersRepository
    {

        private BowlersDBContext _context { get; set; }

        public EFBowlersRepository (BowlersDBContext temp)
        {
            _context = temp;
        }

        public IQueryable<Bowler> Bowlers => _context.Bowlers;

        //IQueryable<Recipe> IRecipesRepository.Recipes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
