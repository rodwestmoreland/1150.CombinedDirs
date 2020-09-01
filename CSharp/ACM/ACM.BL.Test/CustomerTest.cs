using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class CustomerTest
    {
        
        public void FullNameValidTest()
        {
            //given - arrange
            //when  - act
            //then  - assert
            Customer customer = new Customer
            {
                LastName = "Plankton",
                FirstName = "Bob"
            };
            string expected = "Plankton, Bob";
            string actual = customer.FullName;

            Assert.AreEqual(expected,actual);

         }
        [TestMethod]
        public void NoFirstName()
        {
            Customer customer = new Customer
            {
                LastName = "Plankton",
                FirstName = ""
            };
            string expected = "Plankton";
            string actual = customer.FullName;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NoLastName()
        {
            Customer customer = new Customer
            {
                LastName = "",
                FirstName = "bob"
            };
            string expected = "bob";
            string actual = customer.FullName;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateLastNameAddress()
        {
            Customer customer = new Customer
            {
                LastName = "",
                FirstName = "bob",
                EmailAddress = ""
            };
            
            bool expected = false;
            bool actual = customer.ValidateNameAndAddress();
            Assert.AreEqual(expected, actual);
        }
    }
}
