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
    public class ChestController : ConnectApiController
    {
        static string json = new WebClient().DownloadString(urlChest);
        List<Chest> Chests = JsonConvert.DeserializeObject<List<Chest>>(json);

        // GET: Chest
        public ActionResult Index()
        {
            return View(Chests);
        }

        // GET: Chest/Details/5
        public ActionResult Details(string id)
        {
            string jsonArena = new WebClient().DownloadString(urlArena);
            List<Arena> arenas = JsonConvert.DeserializeObject<List<Arena>>(jsonArena);

            var chest = Chests.FirstOrDefault(c => c._id.Equals(id));
            var arena = new Arena();
            arena = arenas.FirstOrDefault(a => a.number == chest.arena);

            var chestArenaVM = new ChestArenaVM();
            chestArenaVM.Arena = arena;
            chestArenaVM.Chest = chest;

            if (chestArenaVM != null)
                return View(chestArenaVM);

            return View("Index");
        }
    }
}
