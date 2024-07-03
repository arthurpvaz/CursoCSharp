using System;
using System.Text;
using System.Globalization;

namespace ExercicioFixacao.Entities
{
    internal class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Product);
            sb.Append(", ");
            sb.Append("Quantity: ");
            sb.Append(Quantity);
            sb.Append(", Subtotal: $");
            sb.Append(SubTotal().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
