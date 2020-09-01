using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        public Customer Retrieve(int idNUmber)
        {
            Customer customer = new Customer(idNUmber); 
            if (idNUmber == 1)
            {
                customer.FirstName = "bob";
                customer.LastName = "Plankton";
                customer.EmailAddress = "bob@aol.com";
                customer.AddressList = addressRepository.RetrieveByCustomerID(idNUmber).ToList();
            }
            return customer;
        }
        public List<CustomerRepository> Retrieve()
        {
            return new List<CustomerRepository>();
        }
        public bool Save()
        {
            return true;
        }
    }
}
