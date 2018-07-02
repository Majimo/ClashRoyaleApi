using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClashRoyale.Models
{
    public class Card
    {
        public string _id { get; set; }
        public string idName { get; set; }
        public string rarity { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int elixirCost { get; set; }
        public int copyId { get; set; }
        public int arena { get; set; }
        public int order { get; set; }
        public int __v { get; set; }
    }
}