using Microsoft.AspNetCore.Mvc;

namespace Git_Playground.Controllers;

public class Branch4PullRequestsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}