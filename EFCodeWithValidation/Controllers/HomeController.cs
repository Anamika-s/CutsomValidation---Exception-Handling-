using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeWithValidation.Controllers
{
    [HandleError()]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(string txtNo1, string txtNo2)
        {
            //try
            //{
                int n1 = int.Parse(txtNo1);
                int n2 = int.Parse(txtNo2);
                int result = n1 / n2;
                ViewBag.result = result;
                return View();
            //}
            //catch(Exception ex)
            //{
            //    //  ViewBag.result = ex.Message;
            //    return View("~/Views/Shared/Error.cshtml");
            //}
           
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //protected override void OnException(ExceptionContext filterContext)
        //{
        //    Exception ex = filterContext.Exception;
        //    filterContext.ExceptionHandled = true;

        //    var model = new HandleErrorInfo(filterContext.Exception, "Controller", "Action");

        //    var Result = this.View("Error", new HandleErrorInfo(ex,
        //    filterContext.RouteData.Values["controller"].ToString(),
        //    filterContext.RouteData.Values["action"].ToString()));

        //    filterContext.Result = Result;





        //}

    }
}