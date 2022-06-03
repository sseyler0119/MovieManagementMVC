using MovieManagementMVC.Models;
using MovieManagementMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieManagementMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using(MovieContext db = new MovieContext()) // connect to database
            {
                var movieVms = new List<MovieVM>(); // declare new MovieVM list to store result
                var movies = db.Movies.Where(x => x.Rating != "R" && x.Rating != "NR").ToList(); // only send "family friendly films" to list

                // iterate through each movie in the list, instantiate new MovieVM object, map variables accordingly, and add the movie to movieVms list
                foreach(var m in movies)
                {
                    var movieVm = new MovieVM(); // declare familyVm variable and instantiate with MovieVM
                    movieVm.Title = m.Title; // map Movie Title to MovieVM Title
                    movieVm.Director = m.Director; // map Movie Director to MovieVM Director
                    movieVm.Rating = m.Rating; // map Movie Rating to MovieVM Rating
                    movieVms.Add(movieVm); // add entry to movieVms list
                }
                return View(movieVms); // return partial model to view
            }
        }
    }
}