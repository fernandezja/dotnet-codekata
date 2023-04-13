using Calc.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp1
{
    public class Manager
    {
        private ICalc _calc;


        public Manager(ICalc calc)
        {
            _calc = calc;
        }

        public void SetCalc(ICalc calc) {
            _calc = calc;
        }

        public void Print() {
            Console.WriteLine($"[App1] Add {_calc.Add(1, 1)}");
        }
    }
}
