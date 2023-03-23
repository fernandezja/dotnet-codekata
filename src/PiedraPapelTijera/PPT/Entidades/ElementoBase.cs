using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPT.Entidades
{
    public abstract class ElementoBase
    {
        public string Tipo { get; set; }


        //Propiedad en C#
        private int _demo2;

        public int Demo2
        {
            get { return _demo2; }
            set { _demo2 = value; }
        }


        //Java Like
        private string _demo;
        public string getDemo()
        {
            return _demo;
        }
        public void setDemo(string valor)
        {
            _demo = valor;
        }

        public virtual string ResultadoCon(ElementoBase e) {
            return "";
        }

        public virtual string ResultadoParaPiedra()
        {
            return "";
        }

        public virtual string ResultadoParaPapel()
        {
            return "";
        }

        public virtual string ResultadoParaTijera()
        {
            return "";
        }

        /*
           public string GanaCon(ElementoBase e)
           {


           if (this.Tipo == "Piedra" && e.Tipo == "Tijera")
           {
               return "gana";
           }

           else if(this.Tipo == "Piedra" && e.Tipo == "Papel")
           {
               return "pierde";
           }
           */


    }
}
