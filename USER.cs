using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectFinal
{
    public class USER : Person
    {
        public float budget;
        public string type;
        string c = "Client";
        public USER(string user, string password, string firstname, string lastname, string gender, float budget1, string type1) : base(user, password, firstname, lastname, gender)
        {

            this.budget = budget1;
            this.type = type1;

        }
        public override string Display()
        {
            return c;
        }

    }
}
