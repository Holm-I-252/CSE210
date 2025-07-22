using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("John Doe", "123 Main St", "Anytown", "CA", "USA");
        Customer customer2 = new Customer("Jane Smith", "456 Elm St", "Othertown", "NY", "USA");

        Product product1 = new Product("Laptop", 101, 999.99, 1);
        Product product2 = new Product("Smartphone", 102, 499.99, 2);
        Product product3 = new Product("Tablet", 103, 299.99, 3);
        Product product4 = new Product("Headphones", 104, 199.99, 1);
        Product product5 = new Product("Smartwatch", 105, 249.99, 1);
        Product product6 = new Product("Camera", 106, 599.99, 1);

        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.AddProduct(product3);

        order.GetOrderLabelDetails();
        order.GetShippingLabel();

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        order2.GetOrderLabelDetails();
        order2.GetShippingLabel();
    }
}