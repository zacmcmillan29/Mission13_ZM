using System;
using System.ComponentModel.DataAnnotations;

namespace MySQLFun.Models
{
    //ONE instance of a recipe!
    public class Recipe
    {
        //these come from the dataset in MySQL


        [Key]
        [Required]
        public int RecipeID { get; set; }

        public string RecipeTitle { get; set; }

        public int RecipeClassID { get; set; }

        public string Preparation { get; set; }

        public string Notes { get; set; }

    }
}
