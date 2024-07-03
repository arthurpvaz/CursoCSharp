using System;
using ExercicioFixacao.Entities;
using ExercicioFixacao.Entities.Enums;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("TV", 1000.0);
            Product p2 = new Product("Mouse", 40.0);

            OrderItem orderItem1 = new OrderItem(1, p1.Price, p1);
            OrderItem orderItem2 = new OrderItem(2, p2.Price, p2);

            Client client = new Client("Alex Green", "alex@gmail.com", DateTime.Parse("15/03/1985"));

            Order order = new Order(DateTime.Now, OrderStatus.Processing, client);

            order.AddItem(orderItem1);
            order.AddItem(orderItem2);

            Console.WriteLine(order);
        }
    }
}