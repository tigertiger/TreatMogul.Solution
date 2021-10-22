using System;
using System.Linq;
using TreatMogul.Models;
using System.Collections;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TreatMogul.Controllers
{
  public class TreatsController : Controller
  {
    private readonly TreatMogulContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public TreatsController(UserManager<ApplicationUser> userManager, TreatMogulContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public ActionResult Index()
    {
      List<Treat> sorted = _db.Treats.ToList().OrderBy(treat => treat.Crub).ToList();
      return View(sorted);
    }


  }
}