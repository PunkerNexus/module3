using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_first
{
    public class Grinding : Machines
    {
        public Grinding(string name, string typeWork, string typeMachine, int power)
        {
            Name = name;
            TypeWork = typeWork;
            TypeMachine = typeMachine;
            Power = power;
        }
    }
}
