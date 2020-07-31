using Microsoft.AspNetCore.Mvc;

namespace Salon.Controllers
{
  public class SalonController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}