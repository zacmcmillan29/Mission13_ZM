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

        //------ CRUD ------


        public void SaveBowler (Bowler b)
        {
            _context.Update(b);
            _context.SaveChanges();
        }

        public void AddBowler (Bowler b)
        {
            _context.Add(b);
            _context.SaveChanges();
        }

        public void DeleteBowler (Bowler b)
        {
            _context.Remove(b);
            _context.SaveChanges();
        }


    }
}
