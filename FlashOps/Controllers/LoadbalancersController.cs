using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlashOps.Controllers
{
    public class LoadbalancersController : Controller
    {
        // GET: Loadbalancers
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Users = "flash.local\\chase.pretorius")]
        public ActionResult Loadbalancer40()
        {
            ViewBag.Message = "https://192.168.0.40:444/";

            return View();
        }
        [Authorize(Users = "flash.local\\chase.pretorius")]
        public ActionResult Loadbalancer45()
        {
            ViewBag.Message = "https://192.168.0.45:444/";

            return View();
        }
        [Authorize(Users = "flash.local\\chase.pretorius")]
        public ActionResult LoadbalancerLIVE()
        {
            ViewBag.Message = "https://lb.flash.local:444/";

            return View();
        }
    }
}