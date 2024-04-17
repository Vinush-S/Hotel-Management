using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Password {  get; set; }

        public Customer(int cid, string cname, string caddr, string pwd) 
        {
            CustomerId = cid;
            CustomerName = cname;
            Address = caddr;
            Password = pwd;
        }

        public override string ToString()
        {
            return ($"[CustomerId : {CustomerId}, CustomerName : {CustomerName}, Address : {Address}]");
        }

    }
}
