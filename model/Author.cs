using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erfcore.model
{
    internal class Author
    {
        public int Id { get; set; }
        public string firstname { get; set; }
        public string lastnames{ get; set; } 
        public string email { get; set; }
        public string? biography{ get; set; }
        public DateTime dateofbirth{ get; set; }

    }
}
