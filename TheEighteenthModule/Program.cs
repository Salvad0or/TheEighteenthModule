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
        static void Main(string[] args)
        {

            Thread[] threads = 
                { 
                new Thread(Metod1),
                new Thread(Metod2),
                new Thread(Metod3),
                new Thread(Metod4),
                new Thread(Metod5),
                
            };

            
            
        }



        static void Metod1()
        {

            var task_name = Thread.CurrentThread;

            task_name.Name = "Metod1";

            Random r = new Random();
           
            Console.WriteLine($"Поток {task_name.Name}, ID : {task_name.ManagedThreadId}");

            for (int i = 0; i < 1000; i++)
            {
                Console.BackgroundColor = ConsoleColor.Red;  
                Thread.Sleep(r.Next(1000,5000));
            }
        }

        

    }
}
