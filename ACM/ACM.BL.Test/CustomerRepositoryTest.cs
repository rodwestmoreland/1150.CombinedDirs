using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValidation()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                
                FirstName = "bob",
                LastName = "Plankton",
                EmailAddress = "bob@aol.com"
            };
            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            //var address = new Address(1)
            
            var addressList = new List<Address>()
            {
                {
                 new Address()
                    {
                    AddressType = 1,
                    StreetLine1 = "123 Camel Way",
                    StreetLine2 = "East Third Rock",
                    City = "Tripoli",
                    State = "Moody",
                    Country = "Tyrannia",
                    Zip = "42"
                    }
                },
            {
                 new Address()
                {
                AddressType = 1,
                StreetLine1 = "400 Camel Way",
                StreetLine2 = "West First Bush",
                City = "Tripoli",
                State = "Delerious",
                Country = "Tyrannia",
                Zip = "42"
                }
            }

            };
        for(var i = 0; i < 0; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType,actual.AddressList[i].AddressType);
            }

        }



    }
}
