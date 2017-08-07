using ChordsTransposer.Models;
using System.Web.Mvc;
using System;

namespace ChordsTransposer.Controllers
{
    public class ChordsController : Controller
    {
              // GET: Chords
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View(new ChordList("C A G E D"));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Insert(ChordList model)
        {
            ViewBag.ModelContains = model.UserChords;
            return Content(model.UserChords);
        }
    }
}