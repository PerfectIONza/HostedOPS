using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlashOps.Models;

namespace FlashOps.Controllers
{
    public class ServersController : Controller
    {
        // GET: Servers/Devservers
        public ActionResult ServersDEV()
        {
            var server = new Server() { Name = "ServersDEV" };
            
            return View();
        }
        public ActionResult ServersLIVE()
        {
           
            return View();
        }
        public ActionResult Loadbalancer40()
        {

            return View();
        }
    }
    
}
