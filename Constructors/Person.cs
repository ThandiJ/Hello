using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Constructors
{
    internal abstract class Person
    {
        private readonly string firstName;
        private readonly string lastName;
        private static int counter ;
        protected Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            counter++;
        }

        public static int GetInstances()
        {
            return counter;
        }
        protected string Name => $"{firstName} {lastName}";
    }
}
