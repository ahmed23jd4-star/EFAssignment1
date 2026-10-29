using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erfcore.model
{
    internal class Category
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string ? description{ get; set; }
        public bool stillactive{ get; set; }
    }
}
