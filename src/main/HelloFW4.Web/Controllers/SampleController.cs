using HelloFW4.SampleMng.Service;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloFW4.Web.Controllers
{
    public class SampleController : Controller
    {

        #region member(s)

        public ISampleService SampleService
        {
            get {
                return ContextRegistry.GetContext().GetObject<ISampleService>("SampleService");
            }
        }

        #endregion
        //
        // GET: /Sample/

        public ActionResult Index()
        {
            ViewBag.Date = SampleService.GetDate().ToString();
            return View();
        }

    }
}
