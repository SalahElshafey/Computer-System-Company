using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectFinal
{
    public class Employee : Person
    {
        public static string s = "boss";
        public decimal salary { get; set; }

        public Employee()
        {

        }
        public Employee(string user, string password, string firstname, string lastname, string gender, decimal salary) : base(user, password, firstname, lastname, gender)
        {

            this.salary = salary;

        }
        public override string Display()
        {
            return s;
        }

    }
}
