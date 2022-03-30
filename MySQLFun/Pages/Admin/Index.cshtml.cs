using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MySQLFun.Pages.Admin
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }

        [Key]
        [Required]
        public int BowlerID { get; set; }

        public string BowlerFirstName { get; set; }

        public string BowlerMiddleInit { get; set; }

        public string BowlerLastName { get; set; }

        public string BowlerAddress { get; set; }

        public string BowlerCity { get; set; }

        public string BowlerState { get; set; }

        public string BowlerZip { get; set; }

        public string BowlerPhoneNumber { get; set; }
    }
}
