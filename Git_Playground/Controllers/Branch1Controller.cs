using Microsoft.AspNetCore.Mvc;

namespace Git_Playground.Controllers;

public class Branch1Controller : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}