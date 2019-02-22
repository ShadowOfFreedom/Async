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
            var doneTask = Worker.DoWorkAsync(5);

            bool done = doneTask.Result;

            if (done)
            {
                Console.WriteLine("Done!");
            }
            else
            {
                Console.WriteLine("not done!");
            }
            
            Console.Read();
        }
    }
}
