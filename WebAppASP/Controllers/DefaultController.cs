using Microsoft.AspNetCore.Mvc;

namespace WebAppASP.Controllers;

public class DefaultController : Controller
{

    [Route("/")]
    public IActionResult Home()
    {
        return View();
    }
}
