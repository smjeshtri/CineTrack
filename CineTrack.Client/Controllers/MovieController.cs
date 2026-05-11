using CineTrack.Client.Data.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CineTrack.Client.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            var movies = new List<MovieViewModel>
            {
                new MovieViewModel { Title = "Inception", Genre = "Sci-Fi", ReleaseYear = 2010 },
                new MovieViewModel { Title = "Interstellar", Genre = "Sci-Fi", ReleaseYear = 2014 },
                new MovieViewModel { Title = "The Dark Knight", Genre = "Action", ReleaseYear = 2008 }
            };
            return View(movies);
        }
    }
}