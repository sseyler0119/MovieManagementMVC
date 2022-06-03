using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieManagementMVC.Models
{
    public class MovieContext : DbContext // MovieContext inherits from DbContext
    {
        public DbSet<Movie> Movies { get; set; } // map Movie objects to database
    }
}