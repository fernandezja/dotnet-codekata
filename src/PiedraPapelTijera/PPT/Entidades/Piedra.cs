using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPT.Entidades
{
    public class Piedra : ElementoBase
    {
        public Piedra()
        {
            Tipo = "Piedra";
        }


        public override string ResultadoCon(ElementoBase e)
        {
            return e.ResultadoParaPiedra();

            /*
             
              if (e.Tipo == "Tijera")
            {
                return "gana";
            }
            else if (e.Tipo == "Papel")
            {
                return "pierde";
            }
             */
        }


        public override string ResultadoParaPiedra()
        {
            return "empata";            
        }

        public override string ResultadoParaPapel()
        {
            return "pierde";
        }

        public override string ResultadoParaTijera()
        {
            return "gana";
        }
    }
}
