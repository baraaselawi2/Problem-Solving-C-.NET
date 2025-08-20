using System;
using System.Collections.Generic;
using System.Linq;

var products = new List<Product>
{
    new Product { Id = 1, Name = "Laptop", Price = 1000 },
    new Product { Id = 2, Name = "Phone", Price = 500 },
    new Product { Id = 3, Name = "Tablet", Price = 300 }
};


Func<Product, decimal> getDiscount = p => p.Price - (p.Price * 0.10m);

Action<decimal> print = price => Console.WriteLine($"Discounted Price = {price}");


products.Select(getDiscount).ToList().ForEach(print);

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
