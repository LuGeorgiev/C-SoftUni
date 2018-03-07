using System;
using System.Collections.Generic;
using System.Linq;

namespace AndreyAndBilliard
{
    //NOT FINISHED
    class AndyBilliard
    {
        static void Main(string[] args)
        {
            var numberOfProducts = int.Parse(Console.ReadLine());
            var products = new Dictionary<string, double>();

            for (int i = 0; i < numberOfProducts; i++)
            {
                string[] newProduct = Console.ReadLine().Split('-').ToArray();
                string productName = newProduct[0];
                double productPrice = double.Parse(newProduct[1]);

                if (!products.ContainsKey(productName))
                {
                    products.Add(productName,productPrice);
                }
                else
                {
                    products[productName] = productPrice;
                }
            }

            string customerNewEntry = Console.ReadLine();
            var customers = new List<Customer>();

            while (customerNewEntry!= "end of clients")
            {
                string[] custItem = customerNewEntry.Split(new char[] { '-', ',' }).ToArray();
                string custName = custItem[0];
                string custProd = custItem[1];
                int prodQty = int.Parse(custItem[2]);
                bool isCustExist = false;

                if (products.ContainsKey(custProd))
                {
                    foreach (var customer in customers)
                    {
                        //add product to existing customer
                        if (customer.Name== custName&&customer.Products.ContainsKey(custProd))
                        {
                            customer.Products[custProd] += prodQty;
                            isCustExist = true;
                        }
                        else if(customer.Name == custName && !customer.Products.ContainsKey(custProd))
                        {
                            customer.Products[custProd] = prodQty;
                            isCustExist = true;
                        }
                    }

                    //add new customer
                    if (!isCustExist)
                    {
                        customers.Add(new Customer(custName, custProd, prodQty));
                    }
                }

                customerNewEntry = Console.ReadLine();
            }
            var sortedCustomers = customers
                .OrderBy(x => x.Name);

            double totalBill = 0;
            foreach (var customer in sortedCustomers)
            {
                double customerBill = 0;
                Console.WriteLine(customer.Name);
                foreach (var item in customer.Products)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                    customerBill += item.Value * products[item.Key];
                }
                Console.WriteLine($"Bill: {customerBill:F2}");
                totalBill += customerBill;
            }
            Console.WriteLine($"Total bill: {totalBill:F2}");

        }

        private class Customer
        {
            private string name;
            private Dictionary<string, int> products;

            public string Name {
                get
                {
                    return this.name;
                }
                set
                {
                    this.name = value;
                }
            }
            public Dictionary<string, int> Products
            {
                get
                {
                    return this.products;
                }
                set
                {
                    this.products = value;
                }
            }

            public Customer(string name, string product, int qty)
            {
                this.Name = name;
                this.Products = new Dictionary<string, int>();
                this.Products.Add(product,qty );
            }                
        }
    }
}
