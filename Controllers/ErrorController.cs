using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Index()
        {
            return View("Error"); // Vista genérica de error
        }

        public ActionResult NotFound()
        {
            return View("NotFound"); // Vista para 404 - Not Found
        }
    }
}
