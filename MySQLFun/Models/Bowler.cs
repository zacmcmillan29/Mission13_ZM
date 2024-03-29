﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySQLFun.Models
{
    //ONE instance of a recipe!
    public class Bowler
    {
        //these come from the dataset in MySQL


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

        [ForeignKey ("Teams")]
        public int TeamID { get; set; }
        public Team Teams { get; set; }

    }
}
