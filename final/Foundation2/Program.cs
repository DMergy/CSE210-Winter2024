using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("345 Moulin Rouge", "Bourgeois District", "Paris", "France");
        Customer customer1 = new Customer("Satine Blue", address1);
        List<Product> productsList1 = new List<Product>();

        Product p3451 = new Product("Toy Windmill", "WM400", 34.99, 1);
        Product p3452 = new Product("Top Hat", "TH20", 65.55, 2);
        Product p3453 = new Product("Petticoat", "PC24", 44.95, 1);

        productsList1.Add(p3451);
        productsList1.Add(p3452);
        productsList1.Add(p3453);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();


        Address address2 = new Address("123 Hershey Walk", "Hershey", "PA", "USA");
        Customer customer2 = new Customer("Joy Crackle", address2);
        List<Product> productsList2 = new List<Product>();

        Product p1231 = new Product("Smores Bar", "HM3", 2.99, 5);
        Product p1232 = new Product("Almond Surprise", "HM80", 3.55, 8);
        Product p1233 = new Product("Peanut Butter Truffle", "HM324", 6.75, 12);

        productsList2.Add(p1231);
        productsList2.Add(p1232);
        productsList2.Add(p1233);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

    }
}