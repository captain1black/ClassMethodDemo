using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {

        public void CustomerList(Customer customer)
        {
            Console.WriteLine("New User List : " + customer.Id + " : " + customer.Name + " : " 
                + customer.LastName + " : " + customer.Age + "  :  " + customer.CreditRating );
        }

        public void CustomerAdding(Customer customer)
        {
            Console.WriteLine("New user. Thank you for choosing us. : "
                 + customer.Id + " : " + customer.Name + " : " + customer.LastName);
        }

        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine("User left. We are sorry to leae us! : "
                 + customer.Id + " : " + customer.Name + " : " + customer.LastName);
        }

       

    }
}
