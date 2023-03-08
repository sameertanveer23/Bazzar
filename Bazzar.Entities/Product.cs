using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazzar.Entities
{
    public class Product: BaseEntity
    {
        public Catagory Catagory { get; set; }
        public decimal Price { get; set; }
    }
}
