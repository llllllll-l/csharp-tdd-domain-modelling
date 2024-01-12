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

            basket.AddProduct(new Product("Product1", 10));
            basket.AddProduct(new Product("Product2", 20));
            basket.AddProduct(new Product("Product3", 12));
            basket.AddProduct(new Product("Product4", 17));
            basket.AddProduct(new Product("Product5", 11));
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

            
        }
    }
}