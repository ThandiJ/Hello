using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.ZooManagementSystem
{

    internal abstract class Animal
    {
        protected string Description = "Currently Not Known/Specified!";

        public abstract int MinLifespan { get; }
        public abstract int MaxLifespan { get; }
        public abstract decimal MinSpeed{get;}
        public abstract decimal MaxSpeed{get;}
        public abstract string Eat();
        public abstract string Move();


        public virtual string GetDescription()
        {
            return "Description is: " + Description;
        }
     
    }
}
