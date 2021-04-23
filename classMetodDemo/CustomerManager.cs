using System;
using System.Collections.Generic;
using System.Text;

namespace classMetodDemo
{
   public class CustomerManager
    {
      public  void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName+"   Eklendi");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + "   Silindi");
        }

        public void List(Customer customer)
        {
                Console.WriteLine(customer.FirstName +"\n"+customer.LastName+"  listelendi" );        
        }

        
    }
}
