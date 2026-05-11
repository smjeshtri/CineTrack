using Microsoft.AspNetCore.Mvc;
using CineTrack.Client.Data.Models;

namespace CineTrack.Client.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            var movie = new Movie
            {
              Id = 1,
              Title = "Inception",
              Genre = "Sci-Fi",
              ReleaseYear = 2010
            };

            var allData = new List <Movie>();
            allData.Add(movie);
            return View(allData);
        }
    }
}