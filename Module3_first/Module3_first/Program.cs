using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Module3_first
{
    class Program
    {
        static void Main(string[] args)
        {
            // существует 3 типа станков: токарный, сверлильный, шлифовальный.
            // ввод планирую осуществить в отдельном классе, к примеру создать Invoker, реализующий логику приложения
            // ввод параметров сделать как-то так: Name = Console.ReadLine(); int.Parse(ReadLine()) для интового,
            // и перед этими вводами сделать writeline'ы, которые спрашивают что вводить
            //Collection.Invoker();

            // типы работ захардкодить?

            Console.WriteLine("What a you going to do?(сhoose number)"); // пока не придумал какие действия сделаю в меню
            var mainmenu = Console.ReadLine(); // для будущего switch-case

            Console.ReadKey();
        }
    }
}
