using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieManagementMVC.Models
{
    // create enum to limit Movie Format options 
    public enum MovieFormat
    {
        Dvd,
        BluRay,
        Digital,
        Other
    };
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }
        public MovieFormat Format { get; set; }
    }
}