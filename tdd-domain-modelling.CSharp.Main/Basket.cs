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

        public List<string> Receipt() {
            List<string> receipt = new List<string>();
            Dictionary<string, Tuple<int, Product>> items = new Dictionary<string, Tuple<int, Product>>();

            foreach (Product product in products) {
                if (items.ContainsKey(product.productName)) {
                    items[product.productName] = new Tuple<int, Product>(items[product.productName].Item1 + 1 ,product);
                } else {
                    items.Add(product.productName, new Tuple<int, Product>(1, product));
                }
                
            }

            foreach (KeyValuePair<string, Tuple<int, Product>> item in items) {
                float tot = item.Value.Item2.productPrice * item.Value.Item1;
                receipt.Add($"{item.Value.Item2.productName} {item.Value.Item2.productPrice:F2}x{item.Value.Item1} = {tot:F2}");
            }
            receipt.Add($"Total cost = {CalculateTotalCost():F2}");

            return receipt;
        }

       
    }
}