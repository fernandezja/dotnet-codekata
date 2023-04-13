using Calc.Core.Interfaces;

namespace CalcCore
{
    public class CalcNormal : ICalc
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}