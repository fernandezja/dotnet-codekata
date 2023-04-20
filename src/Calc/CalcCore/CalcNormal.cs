using Calc.Core.Interfaces;

namespace CalcCore
{
    public class CalcNormal : ICalc
    {
        public EventHandler Procesando { get; set; }
        public EventHandler Termino { get; set; }

        public int Add(int x, int y)
        {
            if (Procesando != null)
            {
                Procesando.Invoke(this, new EventArgs());
            }
            

            var resultado = x + y;


            if (Termino!=null)
            {
                Termino.Invoke(this, new EventArgs());
            }
           

            return resultado;
        }
    }
}