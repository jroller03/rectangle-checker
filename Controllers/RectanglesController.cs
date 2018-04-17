using System;
using Microsoft.AspNetCore.Mvc;
using RectanglesChecker.Models;

namespace RectanglesChecker.Controllers
{
  public class RectanglesController : Controller
  {
    [HttpGet("/rectangles")]
    public ActionResult Index()
    {
      return View("CreateForm");
    }

    [HttpGet("/rectangles/result")]
    public ActionResult Result()
    {
      Rectangles myRectangle = new Rectangles(Int32.Parse(Request.Query["side-length"]), Int32.Parse(Request.Query["side-width"]));
      return View("Result", myRectangle);
    }
  }
}
