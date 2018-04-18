using System;
using Microsoft.AspNetCore.Mvc;
using RectanglesChecker.Models;
using System.Collections.Generic;

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
            Dictionary<string, object> Shapes = new Dictionary<string, object>();
            Rectangles myRectangle = new Rectangles(Int32.Parse(Request.Query["side-length"]), Int32.Parse(Request.Query["side-width"]));
            Shapes.Add("ResultingRectangle", myRectangle);
            if (myRectangle.IsSquare())
            {
                Cube myCube = new Cube(myRectangle);
                Shapes.Add("ResultingCube", myCube);
            }
            return View("Result", Shapes);
        }
  }
}
