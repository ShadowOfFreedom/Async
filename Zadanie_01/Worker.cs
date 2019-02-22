using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadanie_01
{
    public static class Worker
    {
        public static async Task<bool> DoWorkAsync(int n)
        {
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < n; i++)
            {
                string path = Path.Combine(@"C:\Loggs\", $"{i}.log");
                tasks.Add(new Task(()=>File.Create(path)));
            }

            tasks.ForEach(t =>
            {
                t.Start();
                Thread.Sleep(1000);
            });

            await Task.WhenAll(tasks);

            return true;
        }
    }
}
