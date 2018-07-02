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
    public class ArenaController : ConnectApiController
    {
        static string json = new WebClient().DownloadString(urlArena);
        List<Arena> Arenas = JsonConvert.DeserializeObject<List<Arena>>(json);

        // GET: Arena
        public ActionResult Index()
        {
            return View(Arenas);
        }

        // GET: Arena/Details/5
        public ActionResult Details(string id)
        {
            string jsonCard = new WebClient().DownloadString(urlCard);
            List<Card> cards = JsonConvert.DeserializeObject<List<Card>>(jsonCard);
            string jsonChest = new WebClient().DownloadString(urlChest);
            List<Chest> chests = JsonConvert.DeserializeObject<List<Chest>>(jsonChest);

            var arena = Arenas.FirstOrDefault(a=> a._id.Equals(id));
            var cardsUnlock = new List<Card>();
            foreach (var card in arena.cardUnlocks)
            {
                cardsUnlock.Add(cards.FirstOrDefault(c=>c._id == card));
            }

            var chestsAvailable = new List<Chest>();
            foreach (var chest in arena.chests)
            {
                chestsAvailable.Add(chests.FirstOrDefault(c => c._id == chest));
            }

            var arenaVM = new ArenaCardVM();
            arenaVM.Arena = arena;
            arenaVM.Cards = cardsUnlock;
            arenaVM.Chests = chestsAvailable;

            if (arenaVM != null)
                return View(arenaVM);

            return View("Index");
        }
    }
}
