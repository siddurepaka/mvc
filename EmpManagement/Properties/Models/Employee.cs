﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpManagement.
    Models
{
    public class Employee
    {
        public int Id { get; set;}
        public string Name { get; set; }
        public string Email { get; set; }
        public string Dept { get; set; }
        public Employee()
        { }
        public Employee(int id,string name,string email,string dept)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Dept = dept;
        }

    }
}
