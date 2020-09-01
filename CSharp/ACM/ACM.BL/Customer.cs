using ACME.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{

    public class Customer : EntityBase, ILoggable
    {
        public Customer():this(0)
        {
            
        }
        public Customer(int customerID) //NOTE CustomerID can't be set outside of class, so constructor is needed
        {
            CustomerID = customerID;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public int CustomerID { get; private set; }
        public int CustomreType { get; set; }
        public string EmailAddress { get; set; }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string FirstName { get; set; }
        public string FullName { get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
                //return LastName + ", " + FirstName; 

            } }
        public string Log() => 
            ($"ID: {CustomerID}; Name: {FullName}; Email: {EmailAddress}; Status: {EntityState.ToString()}");
        public override bool ValidateInput()
        {
            var isValid = false;
            if (!string.IsNullOrWhiteSpace(LastName) && !string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = true;
            }
            return isValid;
        }
        
    }
}
