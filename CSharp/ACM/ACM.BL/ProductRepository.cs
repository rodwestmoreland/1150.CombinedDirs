using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int idNUmber)
        {
            var product = new Product(idNUmber);
            
            if (idNUmber == 2)
            {
                product.Name = "Snail Food";
                product.Description = "Gary's favorite food.";
                product.CurrentPrice = 18.95M;
            }
            return product;
        }
        public List<ProductRepository> Retrieve()
        {
            return new List<ProductRepository>();
        }
        public bool Save(Product product)
        {
            var success = true;
            if(product.HasChanges)
                {if (product.IsValid)
                    {if(product.IsNew)
                    {
                        //call insert Stored procedure
                    }
                    else
                    {
                        //call update Stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
                return success;
        } 
    }
}
