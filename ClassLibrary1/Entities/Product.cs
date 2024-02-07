using ClassLibrary1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public int StockAmount { get; set; }

    }
}
