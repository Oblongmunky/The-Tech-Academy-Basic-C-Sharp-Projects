using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarLinkExercise
{
    public class Chains
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public Chains(string firstName) : this(firstName, "n/a")
        {
        }
        public Chains(string firstName, string lastName)
        {
            fName = firstName;
            lName = lastName;
        }
    }
}
