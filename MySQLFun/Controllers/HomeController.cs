using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySQLFun.Models;

namespace MySQLFun.Controllers
{
    public class HomeController : Controller
    {

        private BowlersDBContext _context { get; set; }
        private IBowlersRepository _repo { get; set; }
   

        //contstructor
        //public HomeController(RecipesDBContext temp)
        public HomeController (IBowlersRepository temp)
        {
            //_context = temp;
            _repo = temp;
        }


        public IActionResult Index()
        {
            return View();
        }


        //------ READ ----------

        public IActionResult ContactList()
        {

            //this pulls in the dataset info!
            var blah = _repo.Bowlers
                .Include(x => x.Teams)
                //.OrderBy(x => x.BowlerFirstName)
                .ToList();

            //pass dataset info to the view!
            return View(blah);
        }

       

        //------ CREATE ----------


        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Teams = _repo.Teams.ToList();
            return View(new Bowler());
        }

        [HttpPost]
        public IActionResult Create(Bowler bowler)
        {
            if (ModelState.IsValid)
            {
                _repo.AddBowler(bowler);
                return RedirectToAction("TeamView", "Team", null);
            }
            // ViewBag.Categories = _appContext.ToList(); where is categories coming from? It isn't a property of appointment
            return RedirectToAction("TeamView", "Team", null);
        }


        //------ EDIT ----------

        [HttpGet]
        public IActionResult Edit (int id)
        {
            ViewBag.Teams = _repo.Teams.ToList();
            var person = _repo.Bowlers.Single(x => x.BowlerID == id);
            return View(person);
        }

        [HttpPost]
        public IActionResult Edit (Bowler b)
        {
            ViewBag.Teams = _repo.Teams.ToList();
            _repo.SaveBowler(b);
            return RedirectToAction("TeamView", "Team", null);
        }

        // ----- DELETE -------

        [HttpGet]
        public IActionResult Delete (int id)
        {
            var person = _repo.Bowlers.Single(x => x.BowlerID == id);
            return View(person);
        }

        [HttpPost]
        public IActionResult Delete (Bowler bowler)
        {
            _repo.DeleteBowler(bowler);
            return RedirectToAction("TeamView", "Team", null);

        }

    }    
}
