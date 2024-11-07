using info.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace info.Controllers
{
    public class InfoController : Controller
    {
        [HttpGet]
        public ActionResult info()
        {

            return View(new Info());
        }



        [HttpPost]
        public ActionResult info(Info s)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index","Home");
            }
            return View(s);
        }

    }

    
}