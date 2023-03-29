using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Alumno(string nombre)
        {
          Nombre = nombre;
        }

        public Alumno()
        {
        }
    }
}
