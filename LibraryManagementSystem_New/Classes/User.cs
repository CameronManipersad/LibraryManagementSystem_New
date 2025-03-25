using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem_New.Classes
{
    public abstract class User
    {
        public string Name { get; set; }
        public string ID { get; set; }

        // Constructor for User class
        public User(string name, string id)
        {
            Name = name;
            ID = id;
        }
    }
}
