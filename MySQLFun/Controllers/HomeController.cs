﻿using System.Linq;
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

        public IActionResult ContactList()
        {
            //this pulls in the dataset info!
            //var blah = _context.Recipes.ToList();
            var blah = _repo.Bowlers.ToList();

            //pass dataset info to the view!
            return View(blah);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Create()
        //{
        //    return View();
        //}
    }    
}
