using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpManagement.Models
{
    public class EmployeeRepository:Interface
    {
        private List<Employee> employeeList;
        public EmployeeRepository()
        {
            employeeList = new List<Employee>() { new Employee(1, "Ajay","a@gmail.com","cse"), new Employee(2, "Ajay", "a@gmail.com", "A"), new Employee(3, "Ajay", "a@gmail.com", "A") };
        }
        public Employee GetEmployee(int id)
        {
            Employee e = employeeList.FirstOrDefault(e => e.Id == id);
            return e;
        }
        public List<Employee> DisplayDetails()
        {
            return employeeList;
        }
        public bool AddEmployee(Employee emp)
        {
            employeeList.Add(emp);
            return true;
        }
        
    }
}
