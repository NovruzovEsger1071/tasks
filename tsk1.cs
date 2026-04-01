using System;
using System.Collections.Generic;
using System.Linq;

namespace MarketApp
{
    public interface IModel
    {
        int Id { get; set; }
    }

    public class Product : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, int count, double price)
        {
            Id = id;
            Name = name;
            Count = count;
            Price = price;
        }

        public void ShowInfo()
        {
            Console.WriteLine("------ Məhsul məlumatı ------");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Ad: {Name}");
            Console.WriteLine($"Sayı: {Count}");
            Console.WriteLine($"Qiymət: {Price}");
        }
    }

    public class ProductAlreadyExistException : Exception
    {
        public ProductAlreadyExistException(string message) : base(message)
        {
        }
    }

    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException(string message) : base(message)
        {
        }
    }

    public class Market : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private List<Product> products = new List<Product>();

        public Market(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddProduct(Product product)
        {
            if (products.Any(p => p.Id == product.Id))
                throw new ProductAlreadyExistException("Bu məhsul artıq marketdə mövcuddur!");

            products.Add(product);
            Console.WriteLine("Məhsul əlavə olundu.");
        }

        public void RemoveProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                throw new ProductNotFoundException("Məhsul tapılmadı!");

            products.Remove(product);
            Console.WriteLine("Məhsul silindi.");
        }

        public void ShowAllProducts()
        {
            Console.WriteLine("------ Marketdəki məhsullar ------");

            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.Id} | Ad: {product.Name} | Say: {product.Count} | Qiymət: {product.Price}");
            }
        }

        public void ShowProductById(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                throw new ProductNotFoundException("Məhsul tapılmadı!");

            product.ShowInfo();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Market market = new Market(1, "Araz Market");

            try
            {
                Product p1 = new Product(1, "Çörək", 50, 0.60);
                Product p2 = new Product(2, "Süd", 30, 1.50);
                Product p3 = new Product(3, "Yağ", 20, 3.20);

                market.AddProduct(p1);
                market.AddProduct(p2);
                market.AddProduct(p3);

                market.ShowAllProducts();

                Console.WriteLine();
                market.ShowProductById(2);

                Console.WriteLine();
                market.RemoveProduct(2);

                Console.WriteLine();
                market.ShowAllProducts();
            }
            catch (ProductAlreadyExistException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ProductNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
