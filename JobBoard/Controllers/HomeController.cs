using Microsoft.AspNetCore.Mvc;

namespace JobOpenings.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}
