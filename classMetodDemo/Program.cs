using System;

namespace classMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Ali";
            customer1.LastName = "atsak";
            customer1.Address = "Aydın";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Pınar";
            customer2.LastName = "bicer";
            customer2.Address = "Aydın";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Senay";
            customer3.LastName = "aygun";
            customer3.Address = "Aydın";


            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.List(customer3);
             
        }
    }
}
