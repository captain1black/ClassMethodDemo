using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = "1996865";
            customer1.Name = "İsmail";
            customer1.LastName = "Toy";
            customer1.Age = "18";
            customer1.CreditRating = "10";

            Customer customer2 = new Customer();
            customer2.Id = "1996866";
            customer2.Name = "Cemal";
            customer2.LastName = "Sürreya";
            customer2.Age = "57";
            customer2.CreditRating = "8.2";

            Customer customer3 = new Customer();
            customer3.Id = "1996867";
            customer3.Name = "Nikola";
            customer3.LastName = "Tesla";
            customer3.Age = "49";
            customer3.CreditRating = "6.8";

            Customer customer4 = new Customer();
            customer4.Id = "1996868";
            customer4.Name = "Rodion";
            customer4.LastName = "Raskolnikov";
            customer4.Age = "28";
            customer4.CreditRating = "7.6";

            Customer customer5 = new Customer();
            customer5.Id = "1996869";
            customer5.Name = "Nazım";
            customer5.LastName = "Hikmet";
            customer5.Age = "53";
            customer5.CreditRating = "9";

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4, customer5 };


            Console.WriteLine("<<<<<<<<<<<< Customerss >>>>>>>>>>>>>>>>");

            foreach (Customer customer in customers)
            {
                Console.WriteLine("\n" + "=========================");

                Console.WriteLine("Customer Number : " + customer.Id);
                Console.WriteLine("Customer Name : " + customer.Name);
                Console.WriteLine("Customer Last name : " + customer.LastName);
                Console.WriteLine("Customer Age : " + customer.Age);
                Console.WriteLine("Customer Credit rating : " + customer.CreditRating);

            }




            Console.WriteLine("\n" + "<<<<<<<<<<<< NEW USER LİST >>>>>>>>>>>>");

            CustomerManager customerManager2 = new CustomerManager();
            customerManager2.CustomerList(customer1);
            customerManager2.CustomerList(customer2);
            customerManager2.CustomerList(customer3);
            customerManager2.CustomerList(customer4);
            customerManager2.CustomerList(customer5);



            Console.WriteLine("\n" + "<<<<<<<<<<<<< USER ADDİNG >>>>>>>>>>>>>>");


            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerAdding(customer1);
            customerManager.CustomerAdding(customer2);
            customerManager.CustomerAdding(customer3);
            customerManager.CustomerAdding(customer4);
            customerManager.CustomerAdding(customer5);



            Console.WriteLine("\n" + "<<<<<<<<<<<< USER DELETİON >>>>>>>>>>>>");


            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.CustomerDelete(customer1);
            customerManager1.CustomerDelete(customer2);
            customerManager1.CustomerDelete(customer3);
            customerManager1.CustomerDelete(customer4);
            customerManager1.CustomerDelete(customer5);


          




        }
    }
}