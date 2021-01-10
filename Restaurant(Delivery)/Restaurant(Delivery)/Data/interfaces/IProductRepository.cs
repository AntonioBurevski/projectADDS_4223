using Restaurant_Delivery_.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Delivery_.Data.interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get;  }
        IEnumerable<Product> HotDeals { get;  }
        Product GetProductById(int ProductID);
    }
}
