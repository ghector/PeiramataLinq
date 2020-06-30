using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeiramataLinq
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        //Navigation Properties
        public virtual Movie Movie { get; set; }

        public static void Output(string name)
        {
            Console.WriteLine(name);
        }

    }
}
