using ClassLibrary1.Abstract;
using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Concreate
{
    public class ProductRepository : BaseRepo<Product>
    {
        public ProductRepository() : base(nameof(Product))
        {

        }

    }
}
