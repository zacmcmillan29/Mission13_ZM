﻿using System;
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
        public IQueryable<Team> Teams => _context.Teams;

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

        public void DeleteBowler (Bowler bowler)
        {
            _context.Remove(bowler);
            _context.SaveChanges();
        }


    }
}
