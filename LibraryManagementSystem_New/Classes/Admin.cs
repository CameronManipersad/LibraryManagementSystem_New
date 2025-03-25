using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem_New.Classes
{
    public class Admin : User
    {
        // Constructor for Admin class
        public Admin(string name, string id) : base(name, id) { }

        // Method to generate a comprehensive report
        public void GenerateAdminReport()
        {
            Console.WriteLine("Generating full library report...");
            // Implement detailed report generation logic
        }
    }
}
