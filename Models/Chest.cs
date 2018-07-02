using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClashRoyale.Models
{
    public class Unlock
    {
        public int time { get; set; }
        public int gemCost { get; set; }
    }

    public class Gold
    {
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Cards
    {
        public int number { get; set; }
        public int minLegendary { get; set; }
        public int minEpic { get; set; }
        public int minRare { get; set; }
    }

    public class Chest
    {
        public string _id { get; set; }
        public string idName { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public int __v { get; set; }
        public Unlock unlock { get; set; }
        public int gemCost { get; set; }
        public Gold gold { get; set; }
        public Cards cards { get; set; }
        public int arena { get; set; }
        public string description { get; set; }
        public string information { get; set; }
        public int? league { get; set; }
        public int? numberOfChoices { get; set; }
    }
}