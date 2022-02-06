using System;

namespace ClassesCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Hakan";
            customer.LastName = "Yiğit";
            customer.City = "İstanbul";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Engin",
                LastName = "Demiroğ"
            };

            Console.WriteLine(customer2.FirstName);

        }
    }
}
