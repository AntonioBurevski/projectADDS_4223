using Restaurant_Delivery_.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Delivery_.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> HotDeals { get; set; }
    }
}
