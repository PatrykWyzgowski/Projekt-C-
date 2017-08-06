using ChordsTransposer.Models;
using System.Web.Mvc;

namespace ChordsTransposer.Controllers
{
    public class ChordsController : Controller
    {
        ChordList chordlist = new ChordList("C A G E D");
              // GET: Chords
        public ActionResult Index(string userString)
        {
            //ViewBag.userString = userString;
            return View();
        }

        //[HttpGet]
        //public ActionResult Test()
        //{            
        //    return View();
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string userchords)
        {
            if (ModelState.IsValid)
            {
                chordlist.UserChords = userchords;
                return RedirectToAction("Index");
            }
                
            return View(chordlist);
        }
    }
}