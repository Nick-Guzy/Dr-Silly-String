using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {
      private readonly FactoryContext _db;

      public HomeController(FactoryContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        Engineer[] engins = _db.Engineers.ToArray();
        Item[] items = _db.Items.ToArray();
        Dictionary<string,object[]> model = new Dictionary<string, object[]>();
        model.Add("engineers", engins);
        model.Add("items", items);
        return View(model);
      }
    }
}