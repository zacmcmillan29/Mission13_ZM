using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySQLFun.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MySQLFun.Controllers
{
    public class TeamController : Controller
    {
        private BowlersDBContext _context { get; set; }
        private IBowlersRepository _repo { get; set; }


        //contstructor
        //public HomeController(RecipesDBContext temp)
        public TeamController(IBowlersRepository temp)
        {
            //_context = temp;
            _repo = temp;
        }

        public IActionResult TeamView()
        {
            ViewBag.Teams = _repo.Teams.ToList();

            var blah = _repo.Bowlers
                .Include(x => x.Teams)

                .OrderBy(x => x.BowlerFirstName)
                //.GroupBy(x => x.BowlerFirstName)
                .ToList();

            //pass dataset info to the view!
            return View(blah);
        }

        public IActionResult Marlins()
        {
            var blah = _repo.Bowlers
                .Where(x => x.TeamID == 1)
                .ToList();

            //pass dataset info to the view!
            return View(blah);
        }

        public IActionResult Sharks()
        {
            var blah = _repo.Bowlers
                .Where(x => x.TeamID == 2)
                .ToList();

            //pass dataset info to the view!
            return View(blah);
        }

        public IActionResult Terrapins()
        {
            var blah = _repo.Bowlers
                .Where(x => x.TeamID == 3)
                .ToList();

            //pass dataset info to the view!
            return View(blah);
        }

        public IActionResult Barracudas()
        {
            var blah = _repo.Bowlers
                .Where(x => x.TeamID == 4)
                .ToList();

            //pass dataset info to the view!
            return View(blah);
        }

        public IActionResult Dolphins()
        {
            var blah = _repo.Bowlers
                .Where(x => x.TeamID == 5)
                .ToList();

            //pass dataset info to the view!
            return View(blah);
        }

        public IActionResult Orcas()
        {
            var blah = _repo.Bowlers
                .Where(x => x.TeamID == 6)
                .ToList();

            //pass dataset info to the view!
            return View(blah);
        }

        public IActionResult Manatees()
        {
            var blah = _repo.Bowlers
                .Where(x => x.TeamID == 7)
                .ToList();

            //pass dataset info to the view!
            return View(blah);
        }

        public IActionResult Swordfish()
        {
            var blah = _repo.Bowlers
                .Where(x => x.TeamID == 8)
                .ToList();

            //pass dataset info to the view!
            return View(blah);
        }

        public IActionResult Huckleberrys()
        {
            var blah = _repo.Bowlers
                .Where(x => x.TeamID == 9)
                .ToList();

            //pass dataset info to the view!
            return View(blah);
        }

        public IActionResult MintJuleps()
        {
            var blah = _repo.Bowlers
                .Where(x => x.TeamID == 10)
                .ToList();

            //pass dataset info to the view!
            return View(blah);
        }
        //public IActionResult

    }
}
