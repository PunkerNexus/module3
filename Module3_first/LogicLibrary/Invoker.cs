using System;
using System.Collections.Generic;
using System.Threading;

namespace LogicLibrary
{
    public class Invoker
    {
        public static List<Machines> machines = new List<Machines>();

        public static void WorkForMach()
        {
            foreach (var mechs in machines)
            {
                var thread = new Thread(machin => MachineLoad(machin as Machines));
                thread.Start(mechs);
            }
        }

        private static Random Random = new Random();

        public static void MachineLoad(Machines machines)
        {
            //попытка реализовать нагрузку без рандома
            //var powerg = ForWriting("Enter power which will load machine: ", x => Convert.ToInt32(x));
            while (true)
            {
                var powerg = Random.Next(0, machines.Power + 15);

                Console.WriteLine($"Machine {machines.Name}. Load on the machine: {powerg}");
                if (powerg > machines.Power)
                {
                    Console.WriteLine($"Machine broke down: {machines.Name}");
                    return;
                }

                Thread.Sleep(1000);
                //powerg += powerg;
            }
        }

        public static void Show()
        {
            foreach (var mech in machines)
            {
                Console.Write($"Name - {mech.Name}, ");
                Console.Write($"type of work - {mech.TypeWork}, ");
                Console.Write($"type of machine - {mech.TypeMachine}, ");
                Console.WriteLine($"power -  {mech.Power}");
            }
        }

        public static void EnterOfMachine()
        {
            string name = null;
            string typeWork = null;
            string typeMachine = null;
            int power = 0;
            Console.WriteLine("Choose type of machine(1 - Lathe, 2 - Grinding, 3 - Drilling): ");
            var typemachine = Console.ReadLine();
            switch (typemachine)
            {
                case "1":
                    var lathe = new Lathe(name, typeWork, typeMachine, power)
                    {
                        Name = ForWriting("Enter name: ", x => Convert.ToString(x)),
                        TypeWork = ForWriting("Enter type of work(hard or easy): ", x => Convert.ToString(x)),
                        TypeMachine = ForWriting("Enter type of Machine: ", x => Convert.ToString(x)),
                        Power = ForWriting("Enter power: ", x => Convert.ToInt32(x))
                    };
                    machines.Add(lathe);
                    break;

                case "2":
                    var grinding = new Grinding(name, typeWork, typeMachine, power)
                    {
                        Name = ForWriting("Enter name: ", x => Convert.ToString(x)),
                        TypeWork = ForWriting("Enter type of work(hard or easy): ", x => Convert.ToString(x)),
                        TypeMachine = ForWriting("Enter type of Machine: ", x => Convert.ToString(x)),
                        Power = ForWriting("Enter power: ", x => Convert.ToInt32(x))
                    };
                    machines.Add(grinding);
                    break;

                case "3":
                    var drilling = new Drilling(name, typeWork, typeMachine, power)
                    {
                        Name = ForWriting("Enter name: ", x => Convert.ToString(x)),
                        TypeWork = ForWriting("Enter type of work(hard or easy): ", x => Convert.ToString(x)),
                        TypeMachine = ForWriting("Enter type of Machine: ", x => Convert.ToString(x)),
                        Power = ForWriting("Enter power: ", x => Convert.ToInt32(x))
                    };
                    machines.Add(drilling);
                    break;
            }
        }

        public static T ForWriting<T>(string message, Func<string, T> mapper) // создается делегат, слева вывод, справа ввод
        {
            while (true)
            {
                Console.Write(message);

                try
                {
                    return mapper.Invoke(Console.ReadLine()); // выполняет делегат
                }
                catch (Exception)
                {
                    Console.WriteLine("Input error");
                }
            }
        }
    }
}
