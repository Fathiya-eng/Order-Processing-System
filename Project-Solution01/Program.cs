using System;
using System.Collections.Generic;

namespace Project_Solution01
{
    class Program
    {
        static void Main(string[] args)
        {
            // =========================
            // CUSTOMER
            // =========================
            Customer customer = new Customer(
                "1",
                "Yahia",
                "yahia@email.com"
            );

            // =========================
            // PRODUCTS
            // =========================
            Product p1 = new ElectronicsProduct(
                "1",
                "Laptop",
                1000,
                5
            );

            Product p2 = new ClothingProduct(
                "2",
                "T-Shirt",
                50,
                10
            );

            // =========================
            // ORDER
            // =========================
            Order order = new Order("100", customer);

            order.AddProduct(p1, 1);
            order.AddProduct(p2, 2);

            // =========================
            // PAYMENT
            // =========================
            order.SetPayment(new CashPayment());

            // =========================
            // PROCESS ORDER
            // =========================
            order.ProcessOrder();

            // =========================
            // PRINT SUMMARY
            // =========================
            order.PrintSummary();

            Console.ReadKey();
        }
    }

    // =========================
    // ENUM
    // =========================
    public enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered
    }

    // =========================
    // INTERFACES
    // =========================
    public interface IPayable
    {
        void Pay(decimal amount);
    }

    public interface IShippable
    {
        void Ship();
    }

    // =========================
    // CUSTOMER
    // =========================
    public class Customer
    {
        public string Id { get; private set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public List<Order> Orders { get; private set; }

        public Customer(string id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;

            Orders = new List<Order>();
        }
    }

    // =========================
    // PRODUCT (ABSTRACTION)
    // =========================
    public abstract class Product
    {
        public string Id { get; private set; }

        public string Name { get; private set; }

        public decimal Price { get; protected set; }

        public int StockQuantity { get; set; }

        public Product(
            string id,
            string name,
            decimal price,
            int stockQuantity)
        {
            Id = id;
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }

        public virtual decimal CalculatePrice()
        {
            return Price;
        }
    }

    // =========================
    // ELECTRONICS PRODUCT
    // =========================
    public class ElectronicsProduct : Product
    {
        public ElectronicsProduct(
            string id,
            string name,
            decimal price,
            int stockQuantity)
            : base(id, name, price, stockQuantity)
        {
        }

        public override decimal CalculatePrice()
        {
            // 10% extra fee
            return Price * 1.10m;
        }
    }

    // =========================
    // CLOTHING PRODUCT
    // =========================
    public class ClothingProduct : Product
    {
        public ClothingProduct(
            string id,
            string name,
            decimal price,
            int stockQuantity)
            : base(id, name, price, stockQuantity)
        {
        }

        public override decimal CalculatePrice()
        {
            // 5% discount
            return Price * 0.95m;
        }
    }

    // =========================
    // ORDER ITEM
    // =========================
    public class OrderItem
    {
        public Product Product { get; private set; }

        public int Quantity { get; private set; }

        public decimal SubTotal
        {
            get
            {
                return Product.CalculatePrice() * Quantity;
            }
        }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
    // =========================
    // PAYMENT (ABSTRACTION)
    // =========================


    // =========================
    // CASH PAYMENT
    // =========================


    // =========================
    // CREDIT CARD PAYMENT
    // =========================


    // =========================
    // PAYPAL PAYMENT
    // =========================


    // =========================
    // ORDER
    // =========================


    // =========================
    // ADD PRODUCT
    // =========================


    // =========================
    // CALCULATE TOTAL
    // =========================


    // =========================
    // SET PAYMENT
    // =========================


    // =========================
    // PROCESS ORDER
    // =========================


    // =========================
    // SHIP ORDER
    // =========================


    // =========================
    // DELIVER ORDER
    // =========================



    // =========================
    // PRINT SUMMARY
    // =========================


}
}