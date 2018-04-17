using System;
using Microsoft.AspNetCore.Mvc;
using RectanglesChecker.Models;


namespace RectanglesChecker.Controllers
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
