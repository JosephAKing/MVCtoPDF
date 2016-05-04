using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rotativa;


namespace MVCtoPDF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(string parm)
        {
            if (parm != null)
            {
                ViewBag.Message = String.Format("You asked for information about {0}", parm);
            }
            else
            {
                ViewBag.Message = "Your application description page.";
            }
            return View();
        }

        public ActionResult GeneratePDF(string parm, string parm2)
        {
            // Real time generation
            var fileName = String.Format("{0}.pdf", parm);
            return new ActionAsPdf(parm, new { parm = parm2 }) {FileName = fileName};
           
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}