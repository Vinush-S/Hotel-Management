using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    class Admin
    {

        ArrayList EmpList = new ArrayList();

        Dictionary<int, Customer> CustList = new Dictionary<int, Customer>();

        public void Adminprocess()
        {
            Console.WriteLine("Admin Process\n1. Create Employee\n2. Display Employee\n3. Display Customer\nSelect any options from above : ");
            
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    createEmployee();
                    break;
                case "2":
                    displayEmployees();
                    break;
                case "3":
                    displayCustomerdetails();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
        

        public void createEmployee()
        {
            
            Console.WriteLine("Newly joined employees count: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                
                Console.WriteLine();
                int EmpId=int.Parse(Console.ReadLine());
                string EmpName=Console.ReadLine();
                string EmpType=Console.ReadLine();
                double Salary = int.Parse(Console.ReadLine());
                int Age = int.Parse(Console.ReadLine());
                Employee employee = new Employee(EmpId,EmpName,EmpType,Salary,Age);
               
                EmpList.Add(employee);
            }

        }
        public void displayEmployees() 
        {
            foreach (Employee emp in EmpList) 
            {
                Console.WriteLine(emp);
            }
        }

        
        public void createCustomer()
        {
            int id = 100;
            Console.WriteLine("Enter your name : ");
            string custName = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            string custAddr = Console.ReadLine();
            Label:
            Console.WriteLine("Enter your password of alphanumeric(atleast 6 characters) : ");
            string custPass = Console.ReadLine();
            if(custPass.Length < 6)
            {
                Console.WriteLine("Enter a valid password of length 6");
                goto Label;
            }
            else
            {

                Customer cust = new Customer(++id,custName,custAddr,custPass);
                CustList.Add(cust.CustomerId, cust);
                Console.WriteLine($"\nCustomer Added Successfully\nYour Customer ID : {cust.CustomerId}");
                Validatecustomer();
            }
        }

        public void Validatecustomer()
        {

            Console.WriteLine("Login by using your credentials\nEnter your ID : ");
            int CustID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Password : ");
            string CustPass = Console.ReadLine();
            for (int i = 1; i <= CustList.Count; i++)
            {
                if (CustID == CustList[CustID].CustomerId)
                {
                    if (CustPass == CustList[CustID].Password)
                    {
                        //check the password when connected to database
                        Service service = new Service();
                        service.showServices();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Password");
                    }
                }
                else
                Console.WriteLine("Invalid CustomerID");
            }

        }

        public void displayCustomerdetails()
        {
            foreach (KeyValuePair<int, Customer> cust in CustList)
            {
                Console.WriteLine(cust.Value);
            }
        }


    }
}
