using ConsoleApp1;

namespace TestProject1
{
    public class StringTests
    {
        [Fact]
        public void Concatenacion()
        {
            var cadena1 = "Yoda";
            var cadena2 = cadena1 + cadena1;

            var cadena3 = String.Concat(cadena1, cadena1);

            var cadena4 = $"{cadena1}{cadena1}";

            var cadena5 = String.Format("{0}{1}", cadena1, cadena1);

            var cadena6 = String.Format("{0}{0}", cadena1);

            Assert.Equal(cadena2, cadena6);

        }

        [Theory]
        [InlineData(10, 40)]
        [InlineData(100, 400)]
        [InlineData(1000, 4000)]
        [InlineData(10000, 40000)]
        //[InlineData(100000, 400000)]
        public void ConcatenacionPesada(int cantidad,
                                        int cantidadEsperada)
        {
            string cadena1 = "Yoda";
            string resultado = string.Empty;

            for (int i = 0; i < cantidad; i++)
            {
                resultado += cadena1;
            }
           
            Assert.Equal(cantidadEsperada, resultado.Length);

        }


        [Theory]
        [InlineData(10, 40)]
        [InlineData(100, 400)]
        [InlineData(1000, 4000)]
        [InlineData(10000, 40000)]
        [InlineData(100000, 400000)]
        [InlineData(1000000, 4000000)]
        [InlineData(10000000, 40000000)]
        public void ConcatenacionRapida(int cantidad,
                                      int cantidadEsperada)
        {
            string cadena1 = "Yoda";
            var resultado = new System.Text.StringBuilder();

            for (int i = 0; i < cantidad; i++)
            {
                resultado.Append(cadena1);
            }

            Assert.Equal(cantidadEsperada, resultado.Length);

        }

    }
}