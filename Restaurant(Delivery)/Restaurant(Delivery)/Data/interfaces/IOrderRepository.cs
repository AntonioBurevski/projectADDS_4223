using Restaurant_Delivery_.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Delivery_.Data.interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
