using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _3._3._3._PIZZA_TIME
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer anton = new Customer("Антон");
            Order order = new Order(anton);
            order.Notify += ShowMessage;
            order.MakeOrder(SortOfPizza.Пеперони);
            Console.ReadLine();
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Customer
    {
        public string Name { get; private set; }

        public Customer (string name)
        {
            Name = name;
        }
    }

    class Order
    {
        public delegate void CookingHandler(string message);

        public event CookingHandler Notify;

        Customer customer;

        SortOfPizza pizza;

        Pizzeria pizzeria = new();

        public Order (Customer customer)
        {
            this.customer = customer;
        }

        public void MakeOrder (SortOfPizza pizza)
        {
            pizzeria.Notify += OrderComplete;

            pizzeria.Cook(pizza);
        }

        public void OrderComplete (SortOfPizza pizza)
        {
            Notify?.Invoke($"Заказ с пиццей {pizza} на имя {customer.Name} готов!");
        }
    }

    class Pizzeria
    {
        public delegate void CookingHandler(SortOfPizza pizza);

        public event CookingHandler Notify;

        public void Cook(SortOfPizza pizza)
        {
            Thread.Sleep(2000);

            Notify?.Invoke(pizza);
        }
    }


    public enum SortOfPizza
    {
            Маргарита,
            Гавайская,
            Салями,
            Пеперони,
            Четыре_сыра,
            Мексиканская,
    }
}
