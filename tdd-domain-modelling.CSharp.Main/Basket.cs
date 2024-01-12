using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public struct Product {
        public string productName { get; set; }
        public float productPrice { get; set; }

        public Product(string productName, float productPrice) {
            this.productName = productName;
            this.productPrice = productPrice;
        }
    }
    public class Basket {
        
        public List<Product> products;

        public Basket() {
            products = new List<Product>();
        }
        public bool AddProduct(Product product)
        {
            products.Add(product);
            
            return true;
        }
        public bool RemoveProduct(string removeProduct) {
            throw new NotImplementedException();
        }
        public float CalculateTotalCost()
        {
            throw new NotImplementedException();
        }

        public List<string> Receipt()
        {
            throw new NotImplementedException();
        }

       
    }
}