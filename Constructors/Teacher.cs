using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Constructors
{
    internal class Teacher: Person
    {
        public Teacher(string firstName,string lastName): base(firstName,lastName )
        { }

        public string Name => base.Name;
    }
}
