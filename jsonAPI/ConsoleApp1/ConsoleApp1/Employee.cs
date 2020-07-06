using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Employee
    {
        public dynamic id { get; set; }
        public dynamic employee_name { get; set; }
        public dynamic employee_salary { get; set; }
        public dynamic employee_age { get; set; }

        public Employee(dynamic id, dynamic employee_name, dynamic employee_salary, dynamic employee_age)
        {
            this.id = id;
            this.employee_name = employee_name;
            this.employee_salary = employee_salary;
            this.employee_age = employee_age;
        }
    }
}
