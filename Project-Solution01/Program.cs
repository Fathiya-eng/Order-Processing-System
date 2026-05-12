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


    // =========================
    // ELECTRONICS PRODUCT
    // =========================


    // =========================
    // CLOTHING PRODUCT
    // =========================
    

    // =========================
    // ORDER ITEM
    // =========================
 

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