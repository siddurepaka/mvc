using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HtmlHelpers.Models;
namespace HtmlHelpers.Repositories
{
    public class UserRepository
    {
        public static List<User> list = new List<User>()
        {
            new User(){Name="Rohan", Country="INDIA",Uname="Rohan123",password="123"}
            };
        public UserRepository()
        {

        }
        public void Add(User item)
        {
            list.Add(item);
        }

        public User Validate(string uname,string password)
        {
            foreach(var item in list)
            {
                if(item.Uname==uname && item.password==password)
                {
                    return item;
                }
            }
            return null;
        }
        
    }
}
