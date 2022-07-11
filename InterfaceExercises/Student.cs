using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.InterfaceExercises
{
    internal class Student:IPerson
    {
        private string firstName;
        private string lastName;
        internal Student(string firstName,string lastName)
        { 
            this.firstName = firstName;
            this.lastName = lastName;   
        }
        
        public string Name => $"{firstName} {lastName}";
    }
}
