﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IU_Plays.Models
{
    [Table("login")]
    public class login
    {
        public int id { get; set; }
        public string  Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}