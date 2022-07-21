using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movies = new List<Movie>()
            {
                new Movie(id: 1, name: "Shrek"),
                new Movie(id: 2, name: "I Am Legend")
            };

            var viewModel = new IndexMovieViewModel()
            {
                Movies = movies
            };

            return View(viewModel);
        }

        //public ActionResult Details(int movieId)
        //{
        //    return Content("movieId = " + movieId);
        //}

        // movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }

        //    return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        //}

        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
    }
}