using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpManagement.Models
{
    public interface Interface
    {
        Employee GetEmployee(int Id);
        List<Employee> DisplayDetails();
        bool AddEmployee(Employee employee);
    }
}
