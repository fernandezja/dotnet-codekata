using ConsoleApp1;
using System.Collections.Generic;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ListaAdd()
        {
            var alumnos = new List<Alumno>();
            //List<Alumno>() alumnos = null;

            alumnos.Add(new Alumno("Maria"));

            var juan = new Alumno();
            juan.Nombre = "Juan";

            var renata = new Alumno()
            {
                Nombre = "Renata"
            };

            alumnos.Add(juan);
            alumnos.Add(renata);

            //((Alumno)alumnos[1]).Nombre

            Assert.NotNull(alumnos);
            Assert.Equal(3, alumnos.Count);
            Assert.Equal("Maria", alumnos.First().Nombre);
            Assert.Equal("Juan", alumnos[1].Nombre);
            Assert.Equal("Renata", alumnos.Last().Nombre);

        }


        [Fact]
        public void ListaAdd1000()
        {
            var alumnos = new List<Alumno>();

            for (int i = 0; i < 1000; i++)
            {
                alumnos.Add(new Alumno($"Alumno {i}"));
            }

            Assert.NotNull(alumnos);
            Assert.Equal(1000, alumnos.Count);
        }


        [Theory]
        [InlineData(1000, "Demo")]
        [InlineData(10000, "Alumno")]
        [InlineData(100000, "Otro")]
        [InlineData(99999, "Otro")]
        public void ListaAdd2(int cantidad, string nombreAlumno)
        {
            var alumnos = new List<Alumno>();

            //if (cantidad == 99999)
            //{
            //    throw new ArgumentException("Error basico");
            //}


            for (int i = 0; i < cantidad; i++)
            {
                alumnos.Add(new Alumno($"{nombreAlumno} {i}"));
            }

            Assert.NotNull(alumnos);
            Assert.Equal(cantidad, alumnos.Count);
        }


        [Fact]
        public void ObtenerAlumnosConEdadPar() {
            var alumnos = new List<Alumno>();

            for (int i = 0; i < 1000; i++)
            {
                alumnos.Add(new Alumno($"Alumno {i}")
                {
                    Edad = i
                });
            }

            //for
            //while
            //do
            //foreach

            //foreach (var a in alumnos)
            //{
            //    //if a.Edad ES PAR
            //}


            //LINQ


            //1 Inferencia de Tipo
            //var a = new Alumno();
            //2 metodo de extension o extensores
            //a.MiNuevoMetodo
            //3 Objeto anonimo
            //4 Lambda  


            //enlace
            var alumnosConEdadPar = from a in alumnos
                                    where a.Edad == 100
                                    select a;

            var alumnosConEdadPar2 = alumnos
                                        .Where(x => x.Edad == 100)
                                        .Select(x => x);


            Assert.NotNull(alumnos);
            Assert.Equal(1000, alumnos.Count);
            Assert.Equal(1, alumnosConEdadPar.Count());
            //Assert.True(alumnosConEdadPar.Any());

        }
    }
}