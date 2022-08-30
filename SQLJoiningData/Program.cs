namespace SQLJoiningData
{
    internal class Program
    {
        static void Main()
        {
            List<CustomerOrder> customerOrders = new() 
            {
                new CustomerOrder("Acme Hardware", "Mouse", 25m, 3),
                new CustomerOrder("Acme Hardware", "Keyboard", 45m, 2),
                new CustomerOrder("Falls Realty", "Macbook", 800m, 2),
                new CustomerOrder("Julie’s Morning Diner", "iPad", 525m, 1),
                new CustomerOrder("Julie’s Morning Diner", "Credit Card Reader", 45m, 1),
            };

            var uniqueCustomers = customerOrders.Select(c => c.CustomerName).Distinct();

            foreach(var customer in uniqueCustomers)
            {
                Console.WriteLine(customer);
                Console.WriteLine("\t{0,-21}{1,-9}{2,-10}{3}", "Item", "Price", "Quantity", "Total");
                foreach(var order in customerOrders.Where(c => c.CustomerName == customer))
                {
                    Console.WriteLine($"\t{order.Item,-20} {order.Price,-8} {order.Quantity,-10}{order.Price * order.Quantity}");
                }
                Console.WriteLine();
            }


            foreach(var customer in uniqueCustomers)
            {
                Decimal total = 0;
                Console.WriteLine(customer);
                Console.WriteLine("\t{0,-21}{1,-9}{2,-10}{3}", "Item", "Price", "Quantity", "Total");
                foreach(var order in customerOrders.Where(c => c.CustomerName == customer))
                {
                    total += order.Price * order.Quantity;
                    Console.WriteLine($"\t{order.Item,-20} {order.Price,-8} {order.Quantity,-10}{order.Price * order.Quantity}");
                }
                Console.WriteLine($"Total{total,46}");
                Console.WriteLine();
            }

            foreach(var customer in uniqueCustomers)
            {
                Decimal total = 0;
                int itemCount = 0;
                Console.WriteLine("{0,-25}{1,-21}{2,-9}{3,-10}{4}","Customer", "Item", "Price", "Quantity", "Total");
                foreach(var order in customerOrders.Where(c => c.CustomerName == customer))
                {
                    total += order.Price * order.Quantity;
                    if(itemCount==0)
                    {
                        Console.WriteLine($"{order.CustomerName,-25}{order.Item,-20} {order.Price,-8} {order.Quantity,-10}{order.Price * order.Quantity}");
                        itemCount++;
                    }
                    else
                    {
                        Console.WriteLine($"{"",-25}{order.Item,-20} {order.Price,-8} {order.Quantity,-10}{order.Price * order.Quantity}");
                    }
                }
                Console.WriteLine($"Total{total,63}");
                Console.WriteLine();
            }
        }
    }
}