using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadanie_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Procesing...");
            var doneTask = new Task(()=> Worker.DoWorkAsync(5));

            var task2 = new Task(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                    Console.Write("+");
                }

                Console.WriteLine();
            });

            task2.Start();
            doneTask.Start();

            Task.WaitAll(doneTask);
            bool done = doneTask.IsCompleted;

            if (done)
            {
                Console.WriteLine("Done!");
            }
            else
            {
                Console.WriteLine("not done!");
            }


            Console.WriteLine("end of program");
            Console.Read();
        }

        
    }
}
