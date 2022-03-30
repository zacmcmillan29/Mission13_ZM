using System.Linq;
using Microsoft.AspNetCore.Mvc;
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
            //var blah = _context.Recipes.ToList();
            var blah = _repo.Bowlers
                .OrderBy(x => x.BowlerFirstName)
                .ToList();

            //pass dataset info to the view!
            return View(blah);
        }

        public IActionResult TeamView()
        {
            return View();
        }

        //------ CREATE ----------


        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Bowlers = _repo.Bowlers.ToList();
            return View(new Bowler());
        }

        [HttpPost]
        public IActionResult Create(Bowler bowler)
        {
            if (ModelState.IsValid)
            {
                _repo.AddBowler(bowler);
                return RedirectToAction("ContactList");
            }
            // ViewBag.Categories = _appContext.ToList(); where is categories coming from? It isn't a property of appointment
            return View("Create");
        }


        //------ EDIT ----------

        [HttpGet]
        public IActionResult Edit (int id)
        {
            var person = _repo.Bowlers.Single(x => x.BowlerID == id);
            return View(person);
        }

        [HttpPost]
        public IActionResult Edit (Bowler b)
        {
            _repo.SaveBowler(b);
            return RedirectToAction("ContactList");
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
            return RedirectToAction("ContactList");

        }

    }    
}
