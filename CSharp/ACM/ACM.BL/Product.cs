using ACME.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }
        public Product(int productID)
        {
            ProductID = productID;
        }
        //public override string ToString() => ProductName;
        public int ProductID { get; private set; }
        private string _name;
        public string Name 
        { get { return StringHandler.InsertSpaces(_name); } set { _name = value; } }

        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        public string Log() => 
            ($"{ProductID}, {Description}, Price: {CurrentPrice}, Status: {EntityState.ToString()}");
        public override bool ValidateInput()
        {
            var isValid = false;
            if (!string.IsNullOrWhiteSpace(Name) || CurrentPrice == null)
            {
                isValid = true;
            }
            return isValid;
        }

    }
}
