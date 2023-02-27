using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectFinal
{
    public abstract class Person
    {
        public string user { get; set; }
        public string password { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }

        public string gender { get; set; }

        public Person()
        {

        }
        public Person(string user, string password, string firstName, string lastName, string gender)
        {
            this.user = user;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
        }
        public abstract string Display();
    }
}
