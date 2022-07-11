using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.ZooManagementSystem
{
    internal abstract class Reptile: Animal
    {
        public override string GetDescription()
        {
            return @"Reptiles have dry skin,
                    mostly composed by scales or bone plates.
                    Lay soft-shelled eggs 
                    and are unable to regulate their own temperature.";
        }
    }
}
