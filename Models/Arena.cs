using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClashRoyale.Models
{
    public class Donate
    {
        public int common { get; set; }
        public int rare { get; set; }
    }

    public class Request
    {
        public int common { get; set; }
        public int rare { get; set; }
    }

    public class Clan
    {
        public Donate donate { get; set; }
        public Request request { get; set; }
    }

    public class Arena
    {
        public string _id { get; set; }
        public string idName { get; set; }
        public int number { get; set; }
        public string name { get; set; }
        public int victoryGold { get; set; }
        public int minTrophies { get; set; }
        public int order { get; set; }
        public int __v { get; set; }
        public List<string> leagues { get; set; }
        public List<string> cardUnlocks { get; set; }
        public List<string> chests { get; set; }
        public Clan clan { get; set; }
    }
}