using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace CineTrack.Client.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
