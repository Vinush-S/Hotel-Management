using Hotel_Management;
using System;
namespace workspace
{
    class Program
    {
        
        public static void Main(string[] args)
        {

            Admin admin = new Admin();
            Console.WriteLine("\n\t Hotel Mayur Heartly Welcomes You!!\nSelect the options given below in numbers \n1. Customer\n2. Admin");
            int select = int.Parse(Console.ReadLine());
            if(select == 1)
            {
                Console.WriteLine("1. New Customer\n2. Registered Customer");
                int customerType= int.Parse(Console.ReadLine());
                if(customerType == 1)
                {
                    admin.createCustomer();
                }
                else if(customerType == 2)
                {
                    admin.Validatecustomer();
                }
                else
                {
                    Console.WriteLine("Please enter a valid option");
                }
            }
            else if (select == 2)
            {

                admin.Adminprocess();

            }
            

        }
    }
}