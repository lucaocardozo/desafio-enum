using System;
using System.Globalization;
using desafio_enum.Entities;
using desafio_enum.Entities.Enum;


namespace desafio_enum {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());



            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birth);
            Order order = new Order(DateTime.Now, status, client);




            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++) {
                Console.WriteLine("$Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(name, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);
                order.AddItem(orderItem);


            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);


        }
    }
}
