using Microsoft.AspNetCore.Mvc;
using TreatMogul.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace TreatMogul.Controllers
{
  public class HomeController : Controller
  {
    private readonly TreatMogulContext _db;

    public HomeController(TreatMogulContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index() { 
      return View(); 
    }
  
    [HttpGet("Menu")]
    public ActionResult Menu() 
    {
      dynamic model = new ExpandoObject();
      model.Treat = _db.Treats.ToList();
      model.Flavor = _db.Flavors.ToList();
      return View(model); 
    }
  }
}