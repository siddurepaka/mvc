using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket
{
    class Passenger
    {
        string name;
        int age;
        public Passenger(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    public class BookingException : Exception
    {
        public BookingException(string s) : base(s)
        { }
    }
}

