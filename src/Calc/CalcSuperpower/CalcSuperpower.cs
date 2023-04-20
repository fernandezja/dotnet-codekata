using Calc.Core.Interfaces;

namespace CalcSuperpower
{
    public class CalcSuperpower : ICalc
    {
        public EventHandler Procesando { get; set; }
        public EventHandler Termino { get; set; }


        public int Add(int x, int y)
        {
            if (Procesando != null)
            {
                Procesando.Invoke(this, new EventArgs());
            }

            

            var resultado = x + y + 10000;


            if (Termino != null)
            {
                Termino.Invoke(this, new EventArgs());
            }

            return resultado;

        }
    }
}