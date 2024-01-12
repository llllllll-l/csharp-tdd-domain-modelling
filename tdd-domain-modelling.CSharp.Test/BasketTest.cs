using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test {

    [TestFixture]
    public class BasketTest {
        private Basket basket;

        [SetUp]
        public void SetUp() {
            basket = new Basket();

            basket.AddProduct(new Product("Product1", 10f));
            basket.AddProduct(new Product("Product2", 20f));
            basket.AddProduct(new Product("Product3", 12f));
            basket.AddProduct(new Product("Product4", 17f));
            basket.AddProduct(new Product("Product5", 11f));
        }


        [Test]
        public void TestAddProduct() {
            bool isAdded = basket.AddProduct(new Product("Milk", 17));


            Assert.IsTrue(isAdded);
            Assert.IsTrue(basket.products.Any(p=> p.productName == "Milk"));
            Assert.AreEqual(6, basket.products.Count);
            
        }

        [Test] 
        public void TestRemoveProduct() {
            string removeProduct = "Product3";

            bool isRemoved = basket.RemoveProduct(removeProduct);

            Assert.IsTrue(isRemoved);
            Assert.IsFalse(basket.products.Any(p => p.productName == removeProduct));
            Assert.AreEqual(4, basket.products.Count);
        }

        [Test]
        public void TestCalculateTotalCost() {
            float totBasket = basket.CalculateTotalCost();

            Assert.AreEqual(10+20+12+17+11, totBasket);
        }

        [Test]
        public void TestReceipt() {
            List<string> receipt = basket.Receipt();
            
            Assert.AreEqual("Product1 - Quantity: 1 - Price: $10.00", receipt[0]);
            Assert.AreEqual("Product2 - Quantity: 1 - Price: $20.00", receipt[1]);
            Assert.AreEqual("Product3 - Quantity: 1 - Price: $12.00", receipt[2]);
            Assert.AreEqual("Product4 - Quantity: 1 - Price: $17.00", receipt[3]);
            Assert.AreEqual("Product5 - Quantity: 1 - Price: $11.00", receipt[4]);
            Assert.AreEqual("Total Cost: $70.00", receipt[5]);
            
        }
    }
}