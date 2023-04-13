using Calc.Core.Interfaces;

namespace CalcSuperpower
{
    public class CalcSuperpower : ICalc
    {
        public int Add(int x, int y)
        {
            return x + y + 10000;
        }
    }
}