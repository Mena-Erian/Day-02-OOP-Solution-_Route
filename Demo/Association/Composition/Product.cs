using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.Composition
{
    internal class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; } // NULL
        public decimal UnitPrice { get; set; }
        public int UnitOfStock { get; set; }

    }
}
