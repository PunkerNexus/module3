namespace LogicLibrary
{
    public class Lathe : Machines
    {
        public Lathe (string name, string typeWork, string typeMachine, int power)
        {
            Name = name;
            TypeWork = typeWork;
            TypeMachine = typeMachine;
            Power = power;
        }
    }
}
