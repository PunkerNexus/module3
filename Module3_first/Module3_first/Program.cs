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
            // существует 3 типа станков: токарный, сверлильный, шлифовальный.
            // разобраться как выводить коллекцию из другого метода(2 вариант в меню)
            // создать потоки, управляющие отправкой станков на работу(3 вариант в меню)

            Console.WriteLine("What a you going to do?(сhoose number)");
            Console.WriteLine("1 - enter machine\n2 - see all machines\n3 - work\n4 - exit program");
            var mainmenu = Console.ReadLine();

            while(true)
            {
                switch (mainmenu)
                {
                    case "1":
                        Invoker.EnterOfMachine();
                        break;

                    case "2":

                        break;

                    case "3":

                        break;

                    case "4":
                        return;

                }
            }
        }
    }
}
