using Microsoft.AspNetCore.Mvc;

namespace Git_Playground.Controllers;

public class Branch2PageController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}