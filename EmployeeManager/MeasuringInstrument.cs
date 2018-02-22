using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
    public static class MeasuringInstrument
    {
        private const int TotalCount = 100;
        public static void Measure(Func<IList<ManagedEmployee>> getManageEmployees)
        {
            Console.WriteLine("Begin setup.");
            getManageEmployees();
            Console.WriteLine("Setuped.");

            Measure(getManageEmployees, TotalCount, 1);
            Measure(getManageEmployees, TotalCount, 2);
            Measure(getManageEmployees, TotalCount, 5);
            Measure(getManageEmployees, TotalCount, 10);
            Measure(getManageEmployees, TotalCount, 20);

            Console.WriteLine("Completed");
            Console.ReadLine();
        }

        private static void Measure(Func<IList<ManagedEmployee>> getManageEmployees, int totalCount, int threadCount)
        {
            Console.Write($"Thread:{threadCount} RepeatCount:{totalCount / threadCount}");
            getManageEmployees();

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < threadCount; i++)
            {
                tasks.Add(Task.Run(() =>
                {
                    for (int j = 0; j < totalCount / threadCount; j++)
                    {
                        getManageEmployees();
                    }
                }));
            }
            Task.WaitAll(tasks.ToArray());
            stopwatch.Stop();
            Console.WriteLine($" Elapsed:{stopwatch.Elapsed}");
        }
    }
}
