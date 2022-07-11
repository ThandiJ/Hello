using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.ZooManagementSystem
{
    internal class Turtle: Reptile
    {
        public override string Eat()
        {
            return @"Turtle eats fish or insects";
        }

        public override string Move()
        {
            return "Turtle Moving speed -  22 mph";
        }
     
        public override int MinLifespan => 30;
        public override int MaxLifespan => 45;
        public override decimal MinSpeed => 2m;
        public override decimal MaxSpeed => 22m;

    }
}
