using Jupiter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jupiter.Repository
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
