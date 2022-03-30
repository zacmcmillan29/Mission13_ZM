using System;
using System.Linq;

namespace MySQLFun.Models
{
    public interface IBowlersRepository
    {
        IQueryable <Bowler> Bowlers { get;}
    }
}
