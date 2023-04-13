using Calc.Core.Interfaces;
using CalcCore;
using CalcSuperpower;

namespace CalcApp1
{
    internal class Program
    {
        private static ICalc _calc;

        static void Main(string[] args)
        {

            _calc = new CalcSuperpower.CalcSuperpower();

            //Console.WriteLine($"[App1] Add {_calc.Add(1, 1)}");

            var m = new Manager(_calc);
            m.Print();


            m.SetCalc(new CalcCore.CalcNormal());
            m.Print();

            Console.ReadKey();
        }
    }
}