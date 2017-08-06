using ChordsTransposer.Models;
using System.Web.Mvc;

namespace ChordsTransposer.Controllers
{
    public class ChordsController : Controller
    {
              // GET: Chords
        public ActionResult Index()
        {
                     
            return View();
        }
        
        public ActionResult Test()
        { 
        
            ChordList model = new ChordList("");
            
            return View(model.userChords);
        }

        [HttpPost]
        public ActionResult TestResult(ChordList model)
        {
            //string test = model.userChords;
            return Content(model.userChords);
        }
    }
}