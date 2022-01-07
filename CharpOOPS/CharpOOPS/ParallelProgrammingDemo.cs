using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CharpOOPS
{
    class ParallelProgrammingDemo
    {
        public static void ExecuteParallelDemo()
        {
            //#region parallel for 
            //Console.WriteLine("C# For Loop");
            //int number = 10;
            //for (int count = 0; count < number; count++)
            //{
            //    //Thread.CurrentThread.ManagedThreadId returns an integer that 
            //    //represents a unique identifier for the current managed thread.
            //    Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
            //    //Sleep the loop for 10 miliseconds
            //    Thread.Sleep(10);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Parallel For Loop");
            //Parallel.For(0, number, count =>
            //{
            //    Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
            //    //Sleep the loop for 10 miliseconds
            //    Thread.Sleep(10);
            //});
            //#endregion

            //#region parallel foreach
            //DateTime StartDateTime = DateTime.Now;
            //Console.WriteLine(@"foreach Loop start at : {0}", StartDateTime);
            //List<int> integerList = Enumerable.Range(1, 10).ToList();
            //foreach (int i in integerList)
            //{
            //    long total = DoSomeIndependentTimeconsumingTask();
            //    Console.WriteLine("{0} - {1}", i, total);
            //};
            //DateTime EndDateTime = DateTime.Now;
            //Console.WriteLine(@"foreach Loop end at : {0}", EndDateTime);
            //TimeSpan span = EndDateTime - StartDateTime;
            //int ms = (int)span.TotalMilliseconds;
            //Console.WriteLine(@"Time Taken by foreach Loop in miliseconds {0}", ms);

            //DateTime StartDateTime1 = DateTime.Now;
            //Console.WriteLine(@"parallel foreach Loop start at : {0}", StartDateTime1);
            //List<int> integerList1 = Enumerable.Range(1, 10).ToList();
            //Parallel.ForEach(integerList1, i =>
            //{
            //    long total = DoSomeIndependentTimeconsumingTask();
            //    Console.WriteLine("{0} - {1}", i, total);
            //});
            //DateTime EndDateTime1 = DateTime.Now;
            //Console.WriteLine(@"parallel foreach Loop end at : {0}", EndDateTime1);
            //TimeSpan span1 = EndDateTime1 - StartDateTime1;
            //int ms1 = (int)span1.TotalMilliseconds;
            //Console.WriteLine(@"Time Taken by parallel foreach Loop in miliseconds {0}", ms1);

          
            //Console.WriteLine("Press any key to exist");
            //#endregion

            #region parallel invoke
            Parallel.Invoke(
                    () => DoSomeTask(1),
                    () => DoSomeTask(2),
                    () => DoSomeTask(3),
                    () => DoSomeTask(4),
                    () => DoSomeTask(5),
                    () => DoSomeTask(6),
                    () => DoSomeTask(7)
                );
            Console.ReadKey();
            #endregion
        }
        static long DoSomeIndependentTimeconsumingTask()
        {
            //Do Some Time Consuming Task here
            //Most Probably some calculation or DB related activity
            long total = 0;
            for (int i = 1; i < 100000000; i++)
            {
                total += i;
            }
            return total;
        }
        static void DoSomeTask(int number)
        {
            Console.WriteLine($"DoSomeTask {number} started by Thread {Thread.CurrentThread.ManagedThreadId}");
            //Sleep for 5000 milliseconds
            Thread.Sleep(5000);
            Console.WriteLine($"DoSomeTask {number} completed by Thread {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
