namespace LogicLibrary
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
