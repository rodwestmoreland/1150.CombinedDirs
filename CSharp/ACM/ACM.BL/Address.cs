using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address
    {
    public Address()
        {

        }
        public Address(int addressID)
    {
        AddressID = addressID;
    }
    public int AddressID { get; private set; }
    public int AddressType { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Zip { get; set; }
    public string State { get; set; }
    public string StreetLine1 { get; set; }
    public string StreetLine2 { get; set; }
    public bool ValidateNameAndAddress()
    {
            var isValid = false;
            if (!string.IsNullOrWhiteSpace(Zip))
            {
                isValid = true;
            }
            return isValid;
    }

    }
}
