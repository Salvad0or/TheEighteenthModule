using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheEighteenthModule
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            Task.Factory.StartNew(Metod1);
            Task.Factory.StartNew(Metod2);
            Task.Factory.StartNew(Metod3);

            Console.ReadKey();                             
        }



        static async Task Metod1()
        {

            var task_name = Thread.CurrentThread;

            task_name.Name = "Metod1";

            Random r = new Random();

            Console.Write($"Поток {task_name.Name} начал работу, ID : {task_name.ManagedThreadId}");

            for (int i = 0; i < 10; i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("1");
                await Task.Delay(300);
            }

            Console.WriteLine($"Поток {task_name.Name} закончил работу, ID : {task_name.ManagedThreadId}");
        }
        static async Task Metod2()
        {

            var task_name = Thread.CurrentThread;

            task_name.Name = "Metod2";

            Random r = new Random();

            Console.WriteLine($"Поток {task_name.Name} начал работу, ID : {task_name.ManagedThreadId}");

            for (int i = 0; i < 10; i++)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("2");
                await Task.Delay(200);

            }

            Console.WriteLine($"Поток {task_name.Name} закончил работу, ID : {task_name.ManagedThreadId}");
        }

        static async Task Metod3()
        {

            var task_name = Thread.CurrentThread;

            task_name.Name = "Metod3";

            Random r = new Random();

            Console.WriteLine($"Поток {task_name.Name} начал работу, ID : {task_name.ManagedThreadId}");

            for (int i = 0; i < 10; i++)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("3");
                await Task.Delay(300);
            }

            Console.WriteLine($"Поток {task_name.Name} закончил работу, ID : {task_name.ManagedThreadId}");

        }


    }
}
