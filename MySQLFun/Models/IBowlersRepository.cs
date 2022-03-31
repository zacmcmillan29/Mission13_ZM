using System;
using System.Linq;

namespace MySQLFun.Models
{
    public interface IBowlersRepository
    {
        IQueryable <Bowler> Bowlers { get;}
        IQueryable<Team> Teams { get; }

        public void SaveBowler(Bowler b);

        public void AddBowler(Bowler b);

        public void DeleteBowler(Bowler b);

    }
}
