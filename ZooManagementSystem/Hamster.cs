using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.ZooManagementSystem
{
    internal class Hamster: Mammal
    {
        public override string Move()
        {
            return "Hamster Moving speed - 1.85 mph";
        }
        public override string Eat()
        {
            return "Hamster eats insects and vegetables";
        }
        public override int MinLifespan => 1;
        public override int MaxLifespan => 2;
        public override decimal MinSpeed => 3;
        public override decimal MaxSpeed => 6;

    }
}
