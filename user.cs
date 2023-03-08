using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal class user {
        List<user> users = new List<user>();
        public int id;
        public string name;
        public string address;
        public user(int _id,string _name,string _address)
        {
            id = _id;
            name = _name;
            address = _address;

        }
        public void add_user(user b)
        {
            users.Add(b);
        }
       
    
    }
}
