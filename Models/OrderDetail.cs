using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jupiter.Models
{
    public class OrderDetail
    {

        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public int TitleId { get; set; }

        public int Amount { get; set; }

        public decimal Price { get; set; }

        public Title Title { get; set; }

        public Order Order { get; set; }
    }
}
