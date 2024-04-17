using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    class Employee
    {
         
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public string EmployeeType {  get; set; }
        
        public double EmpSalary { get; set; }
        public int EmployeeAge { get; set; }

        public Employee(int EmpId, string EmpName, string EmpType, double Salary, int Age)
        {
            EmployeeId = EmpId;
            EmployeeName = EmpName;
            EmployeeType = EmpType;
            EmpSalary = Salary;
            EmployeeAge = Age;
        }

        public override string ToString()
        {
            return $"[EmployeeId = {EmployeeId}, EmployeeName = {EmployeeName}, EmployeeType = {EmployeeType}, EmployeeAge = {EmployeeAge}, Employee Salary = {EmpSalary}]";
        }

    }
}
