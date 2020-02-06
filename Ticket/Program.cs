using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger p = new Passenger("Ram", 20);
            int n = 5;
                try
            {
                if(n>2)
                    throw new BookingException("Booking cannot be Acceptable");
            }


            catch (Exception e)
            {
                Console.WriteLine(e.Message + " " + e.StackTrace);
            }
            Console.ReadLine();

        }
    }
}
