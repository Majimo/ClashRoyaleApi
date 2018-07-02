using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClashRoyale.Models;
using Newtonsoft.Json;

namespace ClashRoyale.Controllers
{
    public class CardsController : ConnectApiController
    {
        static string json = new WebClient().DownloadString(urlCard);
        List<Card> Cards = JsonConvert.DeserializeObject<List<Card>>(json);

        // GET: Cards
        public ActionResult Index()
        {
            return View(Cards);
        }

        // GET: Cards/Details/5
        public ActionResult Details(string id)
        {
            var card = Cards.FirstOrDefault(c => c._id.Equals(id));
            if (card != null)
                return View(card);
            return View("Index");
        }
    }
}
