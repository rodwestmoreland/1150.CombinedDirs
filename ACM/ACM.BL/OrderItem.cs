using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderID)
        {
            OrderID = orderID;
        }
        public int OrderID { get; private set; }
        public int ProductID { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Qty { get; set; }
        public bool Validate()
        {
            return true;
        }
        public OrderItem Retrieve()
        {
            return new OrderItem();
        }
        public bool Save()
        {
            return true;
        }
    }
}
