using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arith = new ArithProgression();
            arith.SetStart(0);
            for (int i = 0; i < 9; i++)
                Console.WriteLine(arith.GetNext());
            Console.WriteLine("\nСбросить");
            arith.Reset();
            Console.WriteLine();
            GeomProgression geom = new GeomProgression();
            geom.SetStart(0);
            for (int i = 0; i < 9; i++)
                Console.WriteLine(geom.GetNext());
            Console.WriteLine("\nСбросить");
            geom.Reset();
            Console.ReadKey();
        }
    }
     public interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }
    class ArithProgression : ISeries
    {
        int start;
        int next;

        public void SetStart(int x)
        {
            x = Convert.ToInt32(Console.ReadLine());
            start = x;
            next = start;
        }
        public int GetNext()
        {
            next += 10;
            return next;
        }
        public void Reset()
        {
            next = start;
        }

    }
    class GeomProgression : ISeries
    {
        int start;
        int next;

        public void SetStart(int x)
        {
            x = Convert.ToInt32(Console.ReadLine());
            start = x;
            next = start;
        }
        public int GetNext()
        {
            next *= 2;
            return next;
        }
        public void Reset()
        {
            next = start;
        }

    }
}
