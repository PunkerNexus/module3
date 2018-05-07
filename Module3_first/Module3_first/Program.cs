using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using LogicLibrary;

namespace Module3_first
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("What a you going to do?(сhoose number)");
                Console.WriteLine("1 - enter machine\n2 - see all machines\n3 - work\n4 - exit program");
                string mainmenu = Console.ReadLine();

                switch (mainmenu)
                {
                    case "1":
                        Invoker.EnterOfMachine();
                        break;

                    case "2":
                        Invoker.Show();
                        break;

                    case "3":
                        Invoker.WorkForMach();
                        break;

                    case "4":
                        return;
                    default:
                        Console.WriteLine("\nInput error, try again\n");
                        break;

                }
                //Console.Clear();
            }
        }
    }
}
