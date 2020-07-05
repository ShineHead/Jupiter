using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Title Title { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
