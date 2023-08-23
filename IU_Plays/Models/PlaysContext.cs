using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IU_Plays.Models
{
    public class PlaysContext:DbContext
    {
        public DbSet<login> Users { get; set; }

    }
}