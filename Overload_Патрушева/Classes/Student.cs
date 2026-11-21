using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Патрушева.Classes
{
    public class Student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Surname { get; set; }

        public Student(string  FirstName, string LastName, string Surname)
        {
            this.Firstname = Firstname;
            this.Lastname = LastName;
            this.Surname = Surname;
        }
    }
}
