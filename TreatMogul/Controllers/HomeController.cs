using Microsoft.AspNetCore.Mvc;

namespace TreatMogul.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() { 
      return View(); 
    }
  }
}