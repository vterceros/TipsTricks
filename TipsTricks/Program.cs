using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TipsTricks.Casting;
using TipsTricks.SampleClass;

namespace TipsTricks
{
    class Program
    {
        static void Main(string[] args)
        {
            //int inte = 15;
            //Task<int> a = GetInt();
            //Task c = new Task(() => GetIntVoid(inte));
            CancellationTokenSource ts = new CancellationTokenSource();
            Task d = Task.Factory.StartNew(() => GetIntVoid(2),ts.Token);
            Console.WriteLine("Started Task");
            //d.Wait();
            int miliseconds = 10000;
            //if (d.Wait(miliseconds))
            //{
            //    Console.WriteLine("Passed {0} ms",miliseconds);
            //}
            //else
            //{
            //    Console.WriteLine("Not Passed {0} ms", miliseconds);
            //}
            ts.Cancel();
            if (d.Wait(miliseconds))
            {
                Console.WriteLine("Passed {0} ms", miliseconds);
            }
            else
            {
                Console.WriteLine("Not Passed {0} ms", miliseconds);
                ts.Cancel();
            }
            Console.WriteLine("Passed main wait");
            //Parallel.ForEach()
            //Task e = Task.Run(() => GetIntVoid(3));
            //Task<int> b = new Task<int>(()=>GetInt2());
            ////int r = b.Result;
            //b.Start();
            //b.Result
            //CastCompare.CompareTest();

            //foreach (string item in YieldSample.AllPalindromes("101230,121,1200325644"))
            //{
            //    Console.WriteLine(item);
            //}

            //GenericSample<Customer> generic = new GenericSample<Customer>(new Customer() { Age = 0, Name = "V" });
            //bool result = generic.Compare(new Customer() { Age = 0, Name = "V" });
            //Console.WriteLine(result);

            //foreach (int item in GetItemsYield())
            //{
            //    Console.WriteLine(item);
            //}            
            Console.ReadKey();
        }
        public static void GetIntVoid(int a)
        {
            Console.WriteLine("waiting 20 seconds");
            Thread.Sleep(20000);
            Console.WriteLine("Task done!");
        }
        public static async Task<int> GetInt2()
        {
            return await GetInt();
        }
        public static async Task<int> GetInt()
        {
            Thread.Sleep(2000);
            return 10;
        }
    }
}
