using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order(): this(0)
        {

        }
        public Order(int orderID)
        {
            OrderID = orderID;
            OrderItems = new List<OrderItem>();
        }
        public Order(DateTime orderDate)
        {
            OrderDate = orderDate;
        }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingID { get; set; }
        public int CutomerID { get; set; }
        public int OrderID { get; private set; }
        public DateTimeOffset? OrderDate { get; private set; }
        public bool ValidateDate()
        {
            return true;
        }

    }


}
