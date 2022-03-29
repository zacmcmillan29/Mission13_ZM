﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MySQLFun.Models;

namespace MySQLFun.Controllers
{
    public class HomeController : Controller
    {

        private RecipesDBContext _context { get; set; }
        private IRecipesRepository _repo { get; set; }
   

        //contstructor
        //public HomeController(RecipesDBContext temp)
        public HomeController (IRecipesRepository temp)
        {
            //_context = temp;
            _repo = temp;
        }


        public IActionResult Index()
        {
            //this pulls in the dataset info!
            //var blah = _context.Recipes.ToList();
            var blah = _repo.Recipes.ToList();

            //pass dataset info to the view!
            return View(blah);
        }

    }    
}
