using ChordsTransposer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        
        [HttpPost]
        public ActionResult Index(ChordList model)
        {
            return View();
        }
    }
}