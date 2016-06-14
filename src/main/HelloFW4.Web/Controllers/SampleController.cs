using HelloFW4.SampleMng.Service;
using Newtonsoft.Json;
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

        public IMySqlSampleService MySqlSampleService
        {
            get
            {
                return ContextRegistry.GetContext().GetObject<IMySqlSampleService>("MySqlSampleService");
            }
        }

        #endregion
        //
        // GET: /Sample/

        public ActionResult Index()
        {
            ViewBag.Date = SampleService.GetDate().ToString();
            ViewBag.MySqlDate = MySqlSampleService.GetDate().ToString();
            return View();
        }

        public JsonResult GetFruit()
        {
            var fruitList = SampleService.GetFruit("Red");
            var fruit =JsonConvert.SerializeObject(fruitList);
            return Json(new { Data = fruit }, JsonRequestBehavior.AllowGet);
        }

    

    }
}
