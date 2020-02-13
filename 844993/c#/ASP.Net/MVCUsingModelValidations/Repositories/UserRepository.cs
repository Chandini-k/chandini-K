using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCUsingModelValidations.Models;
namespace MVCUsingModelValidations.Repositories
{
    public class UserRepository
    {
        public static List<User> ulist = new List<User>()
        {
            new User() {
            Name = "Chandu",
            Country = "INDIA",
            Uname = "Chandu22",
            Pwd = "1234"
            }
        };

        public UserRepository()
        { 
        }
        public void Add(User item)
        {
            ulist.Add(item);//Add User data into list
        }
        public User Validate(string uname,string pwd)
        {
            foreach(var item in ulist)
            {
                if(item.Uname==uname&&item.Pwd==pwd)
                {
                    return item;
                }
            }
            return null;
        }
    }
}