using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeMvc.Models;

namespace EmployeeMvc.Repositories
{
    public class EmployeeRepository
    {
        public static List<Employee> list = new List<Employee>()
        {
            new Employee(){Eid="123",Password="1234"}
            };
        public EmployeeRepository()
        {

        }
        public void Add(Employee item)
        {
            list.Add(item);
        }

        public Employee Validate(string eid, string pwd)
        {
            foreach (var item in list)
            {
                if (item.Eid == eid && item.Password == pwd)
                {
                    return item;
                }
            }
            return null;
        }

    }
}