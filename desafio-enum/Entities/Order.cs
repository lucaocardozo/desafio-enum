using System;
using System.Collections.Generic;
using desafio_enum.Entities.Enum;
using System.Text;
using System.Globalization;

namespace desafio_enum.Entities {
    class Order {
        public DateTime Moment { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public OrderStatus OrderStatus { get; set; }

        public Client Client { get; set; }


        public Order() {

        }

        public Order(DateTime moment, OrderStatus orderStatus, Client client) {
            Moment = moment;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void AddItem(OrderItem item) {
            Items.Add(item);

        }
        public void RemoveItem(OrderItem item) {
            Items.Remove(item);

        }

        public double Total() {
            double sum = 0.0;
            foreach (OrderItem item in Items) {
                sum = sum + item.SubTotal();
            }
            return sum;
        }


        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + OrderStatus);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items) {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
