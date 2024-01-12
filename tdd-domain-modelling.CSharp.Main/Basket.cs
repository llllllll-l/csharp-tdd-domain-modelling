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
            var productToRemove = products.FirstOrDefault(p => p.productName == removeProduct);

            if (removeProduct != null)
            {
                products.Remove(productToRemove);
                return true;
            }

            return false;
        }
        public float CalculateTotalCost()
        {
            return products.Sum(p => p.productPrice);
        }

        public List<string> Receipt()
        {
            var receipt = new List<string>();

            foreach (var product in products)
            {
                receipt.Add($"{product.productName} - Quantity: 1 - Price: {product.productPrice:C}");
            }

            receipt.Add($"Total Cost: {CalculateTotalCost():C}");

            return receipt;
        }

       
    }
}