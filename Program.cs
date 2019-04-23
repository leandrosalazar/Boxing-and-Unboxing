using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_y_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var relojito = new System.Diagnostics.Stopwatch();
            relojito.Start();

            Stack<object> millon = new Stack<object>();

            for (int i = 0; i < 1000000; i++)
            {

                millon.Push(i);

            }


            foreach (var item in millon)
            {
                Console.WriteLine(item);
            }

            relojito.Stop();
            Console.WriteLine(relojito.Elapsed.TotalSeconds);
            relojito.Reset();
            Console.ReadKey();
            relojito.Start();

            Stack<int> millon2 = new Stack<int>();

            for (int i = 0; i < 1000000; i++)
            {
                millon2.Push(i);
            }

            foreach (var item in millon2)
            {
                Console.WriteLine(item);
            }



            relojito.Stop();
            Console.WriteLine(relojito.Elapsed.TotalSeconds);
            
            Console.ReadKey();
        }
    }
}
