using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.ZooManagementSystem
{
    internal class GoldenEagle:Bird
    {
        public override string Eat()
        {
            return "Golden Eagle eats small animals(fish, rabbit, snake)";
        }

        public override string Move()
        {
            return "Move speed - 32 miles per hour";
        }

        public override int MaxLifespan => 30;
        public override int MinLifespan => 20;

        public override decimal MaxSpeed => 120;
        public override decimal MinSpeed => 32;
    }
}
