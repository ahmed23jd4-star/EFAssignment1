using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erfcore.model
{
    internal class book
    {
        //- each book has a title, ISBN number, price, number  of pages, the year
        public int id { get; set; }
        public int numberofpage { get; set; }
        public string titlte{ get; set; }
        public string isbn{ get; set; }
        public decimal price{ get; set; }
        public DateTime yearpublic { get; set; }
        public bool inStock { get; set; }
    }
}
