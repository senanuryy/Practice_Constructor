using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Constructor
{
    internal class Baby
    {
        public Baby()
        {

        }

        public Baby(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public DateTime DateOfBirth;
        public string Name;
        public string Surname;               

        public void Introduce()
        {
            Console.WriteLine(Name + " " + Surname + ": Ingaaaa");            
            Console.WriteLine("Date of Birth: " + DateOfBirth);
        }

    }
}
