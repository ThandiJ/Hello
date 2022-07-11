using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Constructors
{
    internal class Student: Person
    {
        internal Student(string firstName, string lastName):base(firstName, lastName)   
        {
        }
        public string Name => base.Name;
    }
}
