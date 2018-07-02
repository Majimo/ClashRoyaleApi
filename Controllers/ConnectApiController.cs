using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ClashRoyale.Controllers
{
    public class ConnectApiController : Controller
    {
        protected static string urlHome = @"http://www.clashapi.xyz/";
        protected static string urlArena = @"http://www.clashapi.xyz/api/arenas";
        protected static string urlCard = @"http://www.clashapi.xyz/api/cards";
        protected static string urlChest = @"http://www.clashapi.xyz/api/chests";
    }
}