using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace ClashRoyale.Controllers
{
    public class HomeController : ConnectApiController
    {
        public ActionResult Index()
        {
            var anonym = new { message = ""};
            var json = new WebClient().DownloadString(urlHome);
            var welcome = JsonConvert.DeserializeAnonymousType(json, anonym);

            ViewBag.Message = welcome.message;

            return View();
        }
    }
}