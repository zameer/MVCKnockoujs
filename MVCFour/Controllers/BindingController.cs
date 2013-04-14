using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFour.Controllers
{
    public class BindingController : Controller
    {
        //
        // GET: /Binding/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult eachBinding()
        {
            return View();
        }
        public ActionResult samzBinding()
        {
            return View();
        }
        public JsonResult Save(Person person)
        {
            var message = string.Format("Save {0} and {1}", person.FirstName, person.LastName);
            return Json(new {message});
        }
    }
}
