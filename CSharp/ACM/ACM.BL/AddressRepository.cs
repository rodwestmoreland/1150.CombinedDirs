using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class AddressRepository
    {
        public Address Retrieve(int idNumber)
        {
            var address = new Address(1);
            if (idNumber == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "123 Camel Way";
                address.StreetLine2 = "East Third Rock";
                address.City = "Tripoli";
                address.State = "Moody";
                address.Country = "Tyrannia";
                address.Zip = "42";
            }

            return address;
        }
        public IEnumerable<Address> RetrieveByCustomerID(int customerID)
        {

            var addressList = new List<Address>();
            var address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "123 Camel Way",
                StreetLine2 = "East Third Rock",
                City = "Tripoli",
                State = "Moody",
                Country = "Tyrannia",
                Zip = "42"
        };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 1,
                StreetLine1 = "400 Camel Way",
                StreetLine2 = "West First Bush",
                City = "Tripoli",
                State = "Delerious",
                Country = "Tyrannia",
                Zip = "42"
            };
            addressList.Add(address);
            return addressList;

        }
        public bool Save()
        {
            return true;
        }
    }
}
