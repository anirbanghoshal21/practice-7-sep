using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_library
{
    public delegate void MathDelegate(int No1, int No2);
    public class Program
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine("THE SUM IS : " + (x + y));
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine("THE SUB IS : " + (x - y));
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine("THE MUL IS : " + (x * y));
        }
      

        static void Main(string[] args)
        {
            Program p = new Program();
            MathDelegate del1 = new MathDelegate(Add);
            MathDelegate del2 = new MathDelegate(Program.Sub);
            MathDelegate del3 = p.Mul;


            MathDelegate del4= del1 + del2 + del3;
            del4.Invoke(29, 8);
            Console.WriteLine();
            del4 -= del2;
            del4(42, 5);

            Console.ReadKey();
        }
    }
}

