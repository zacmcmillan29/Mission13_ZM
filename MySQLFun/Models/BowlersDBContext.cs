using System;
using Microsoft.EntityFrameworkCore;

namespace MySQLFun.Models
{
    public class BowlersDBContext : DbContext
    {
        public BowlersDBContext(DbContextOptions<BowlersDBContext> options) : base (options)
        {
            //leave blank
        }

        //create the dataset!!
        public DbSet<Bowler> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
