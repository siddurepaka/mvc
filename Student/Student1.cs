using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    abstract class Student1
    {
        string name;
        string stuid;
        double grade;
        public abstract Boolean Ispassed(double grade);
    }
    class undergraduate : Student1
    {
        public override bool Ispassed(double grade)
        {
            // throw new NotImplementedException();
            if (grade > 70.0)
                return true;
            else
                return false;
        }

    }
    class Graduate : Student1
    {
        public override bool Ispassed(double grade)
        {
            //throw new NotImplementedException();
            if (grade > 80.0)
                return true;
            else
                return false;
        }

    }
}          
        
        
