namespace LogicLibrary
{
    public class Drilling : Machines
    {
        public Drilling(string name, string typeWork, string typeMachine, int power)
        {
            Name = name;
            TypeWork = typeWork;
            TypeMachine = typeMachine;
            Power = power;
        }
    }
}
