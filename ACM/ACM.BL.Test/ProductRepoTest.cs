using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class ProductRepoTest
    {
        [TestMethod]
        public void ValidateRetrieve()
        {
            var productRepo = new ProductRepository();

            var expected = new Product(2)
            {
                Name = "Snail Food",
                Description = "Gary's favorite food.",
                CurrentPrice = 18.95M
            };

            var actual = productRepo.Retrieve(2);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}
