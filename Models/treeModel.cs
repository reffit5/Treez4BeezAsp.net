using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyChoice.Models
{
    public class treeModel
    {
        public string treeName { get; set; }
        public string state { get; set; }
        public int price { get; set; }
        public int age { get; set; }
        public string season { get; set; } 
        public bool isFavorite { get; set; } = true;
    }
}