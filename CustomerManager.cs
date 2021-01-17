using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void CostumerAdding(Customer customer)
        {
            Console.WriteLine("New user. Thank you for choosing us. : "
                 + customer.Id + " : " + customer.Name + " : " + customer.LastName);
        }

        public void CostumerDelete(Customer customer)
        {
            Console.WriteLine("User left. We are sorry to leae us! : "
                 + customer.Id + " : " + customer.Name + " : " + customer.LastName);
        }

    }
}
