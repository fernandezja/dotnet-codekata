using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPT.Entidades
{
    public class Tijera : ElementoBase
    {
        public Tijera()
        {
            Tipo = "Tijera";
        }

        public override string ResultadoParaPiedra() {
            return "gana";
        }

        public override string ResultadoParaPapel()
        {
            return "pierde";
        }

        public override string ResultadoParaTijera()
        {
            return "empata";
        }
    }
}
