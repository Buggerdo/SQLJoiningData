namespace SQLJoiningData
{
    internal class Program
    {
        static void Main()
        {
            List<CustomerOrder> customerOrders = new()
            {
                new CustomerOrder{ CustomerName = "Acme Hardware", Item = "Mouse", Price = 25M, Quantity = 3 },
                new CustomerOrder{ CustomerName = "Acme Hardware", Item = "Keyboard", Price = 45M, Quantity = 2 },
                new CustomerOrder{ CustomerName = "Falls Realty", Item = "Macbook", Price = 800M, Quantity = 2 },
                new CustomerOrder{ CustomerName = "Joe's Chicago Pizza"},
                new CustomerOrder{ CustomerName = "Julie’s Morning Diner", Item = "iPad", Price = 525m, Quantity = 1 },
                new CustomerOrder{ CustomerName = "Julie’s Morning Diner", Item = "Credit Card Reader", Price = 45m, Quantity = 1 },
            };

            var uniqueCustomers = customerOrders.Select(c => c.CustomerName).Distinct();


            //foreach(var customer in uniqueCustomers)
            //{
            //    Console.WriteLine(customer);
            //    Console.WriteLine("\t{0,-21}{1,-9}{2,-10}{3}", "Item", "Price", "Quantity", "Total");
            //    foreach(var order in customerOrders.Where(c => c.CustomerName == customer))
            //    {
            //        Console.WriteLine($"\t{order.Item,-20} {order.Price,-8} {order.Quantity,-10}{order.Price * order.Quantity}");
            //    }
            //    Console.WriteLine();
            //}


            //foreach(var customer in uniqueCustomers)
            //{
            //    Decimal total = 0;
            //    Console.WriteLine(customer);
            //    Console.WriteLine("\t{0,-21}{1,-9}{2,-10}{3}", "Item", "Price", "Quantity", "Total");
            //    foreach(var order in customerOrders.Where(c => c.CustomerName == customer))
            //    {
            //        total += order.Price * order.Quantity;
            //        Console.WriteLine($"\t{order.Item,-20} {order.Price,-8} {order.Quantity,-10}{order.Price * order.Quantity}");
            //    }
            //    Console.WriteLine(" {0, -47}{1}", "Total", total);
            //    Console.WriteLine();
            //}

            //foreach(var customer in uniqueCustomers)
            //{
            //    Decimal total = 0;
            //    int itemCount = 0;
            //    Console.WriteLine("{0,-25}{1,-21}{2,-9}{3,-10}{4}","Customer", "Item", "Price", "Quantity", "Total");
            //    foreach(var order in customerOrders.Where(c => c.CustomerName == customer))
            //    {
            //        total += order.Price * order.Quantity;


            //        if(itemCount==0)
            //        {
            //            Console.WriteLine($"{order.CustomerName,-25}{order.Item,-20} {order.Price,-8} {order.Quantity,-10}{order.Price * order.Quantity}");
            //            itemCount++;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{"",-25}{order.Item,-20} {order.Price,-8} {order.Quantity,-10}{order.Price * order.Quantity}");
            //        }
            //    }
            //    Console.WriteLine(" {0, -47}{1}", "Total", total); 
            //    Console.WriteLine();
            //}

            //foreach(var customer in uniqueCustomers)
            //{
            //    int itemCount = 0;
            //    Console.WriteLine(customer);

            //    foreach(var order in customerOrders.Where(c => c.CustomerName == customer))
            //    {
            //        if(order.Item == null)
            //        {
            //            Console.WriteLine($"\t**No Orders**");
            //        }
            //        else if(itemCount == 0)
            //        {
            //            Console.WriteLine("\t{0,-21}{1,-9}{2,-10}{3}", "Item", "Price", "Quantity", "Total");
            //            Console.WriteLine($"\t{order.Item,-20} {order.Price,-8} {order.Quantity,-10}{order.Price * order.Quantity}");
            //            itemCount++;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"\t{order.Item,-20} {order.Price,-8} {order.Quantity,-10}{order.Price * order.Quantity}");
            //        }
            //    }
            //    Console.WriteLine();
            //}


            //foreach(var customer in uniqueCustomers)
            //{
            //    Decimal total = 0;
            //    int itemCount = 0;
            //    bool isTotal = true;
            //    Console.WriteLine(customer);
            //    foreach(var order in customerOrders.Where(c => c.CustomerName == customer))
            //    {
            //        total += order.Price * order.Quantity;
            //        if(order.Item == null)
            //        {
            //            Console.WriteLine($"\t**No Orders**");
            //            isTotal = false;
            //        }
            //        else if(itemCount == 0)
            //        {
            //            Console.WriteLine("\t{0,-21}{1,-9}{2,-10}{3}", "Item", "Price", "Quantity", "Total");
            //            Console.WriteLine($"\t{order.Item,-20} {order.Price,-8} {order.Quantity,-10}{order.Price * order.Quantity}");
            //            itemCount++;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"\t{order.Item,-20} {order.Price,-8} {order.Quantity,-10}{order.Price * order.Quantity}");
            //        }
            //    }
            //    if(isTotal)
            //    {
            //        Console.WriteLine(" {0, -47}{1}", "Total", total); 
            //    }
            //    Console.WriteLine();
            //}


            Console.WriteLine("{0,-25}{1,-21}{2,-9}{3,-10}{4}", "Customer", "Item", "Price", "Quantity", "Total");
            foreach(var customer in uniqueCustomers)
            {
                int itemCount = 0;
                foreach(var order in customerOrders.Where(c => c.CustomerName == customer))
                {
                    if(order.Item == null)
                    {
                        Console.WriteLine($"{order.CustomerName,-25}**No Orders**");
                    }
                    else if(itemCount == 0)
                    {
                        Console.WriteLine($"{order.CustomerName,-25}{order.Item,-20} {order.Price,-8} {order.Quantity,-10}{order.Price * order.Quantity}");
                        itemCount++;
                    }
                    else
                    {
                        Console.WriteLine($"{"",-25}{order.Item,-20} {order.Price,-8} {order.Quantity,-10}{order.Price * order.Quantity}");
                    }
                }
            }
        }
    }
}