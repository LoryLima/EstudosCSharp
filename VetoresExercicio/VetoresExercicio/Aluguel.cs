using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetoresExercicio
{
    internal class Aluguel
    {

        public string Name
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
 
        public Aluguel(string name, string email)
        {

            Name = name;
            Email = email;
            
        }

        public override string ToString()
        {
            return ($"{Name}, {Email}");
        }
    }
}
