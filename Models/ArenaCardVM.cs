using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClashRoyale.Models
{
    public class ArenaCardVM
    {
        public Arena Arena { get; set; }
        public List<Card> Cards { get; set; }
        public List<Chest> Chests { get; set; }
    }
}