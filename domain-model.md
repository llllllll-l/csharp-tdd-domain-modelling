#Domain Models In Here

```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```
```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

struct Product
    string name;
    float productPrice

class basket
    propertise:
        public List<Product> products;

    methods:
        public float CalculateTotalCost(); // Will calculate the total cost of all products in the basket and return the total price of the basket
        public List<string> Receipt(); // Will return all the names, quantities and prices of the pruducs  
        public void AddProduct(string _product); // Add new product to the products List
        public void RemoveProduct(string _product) // Remove the specific product from the List products