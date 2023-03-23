using ConsoleApp1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void DebeSumar1Mas1YRetornar2()
        {
            var calc = new ConsoleApp1.Calculadora();
            var resultado = calc.Sumar(1, 1);
            Assert.Equal(2, resultado);
        }


        [Fact]
        public void DebeSumar2Mas3YRetornar5()
        {
            var calc = new ConsoleApp1.Calculadora();
            var resultado = calc.Sumar(2, 3);
            Assert.Equal(5, resultado);

        }


        [Fact]
        public void DebeMultiplicarPorSiMismo()
        {
            var numero1 = 2;
            var numero2 = numero1;

            var calc = new ConsoleApp1.Calculadora();
            calc.DemoValor(numero1);

            Assert.Equal(2, numero1);
            Assert.Equal(2, numero2);

            numero1 = 10;

            Assert.Equal(10, numero1);
            Assert.Equal(2, numero2);
        }


        [Fact]
        public void DebeMultiplicarPor2LaCadena()
        {
            var cadena1 = "UTN";
            var cadena2 = cadena1;

            var calc = new ConsoleApp1.Calculadora();
            calc.DemoReferencia(ref cadena1);

            Assert.Equal("UTNUTN", cadena1);
            Assert.Equal("UTN", cadena2);

        }


        [Fact]
        public void DebeMultiplicarPor2LaCadenaDelItemValor()
        {
            var item1 = new ItemValor();
            item1.Nombre = "UTN";

            var item2 = item1;

            var calc = new ConsoleApp1.Calculadora();
            calc.DemoReferencia(item1);

            Assert.Equal("UTNUTN", item1.Nombre);
            Assert.Equal("UTNUTN", item2.Nombre);

            item2.Nombre = "Yoda";

            Assert.Equal("Yoda", item1.Nombre);
            Assert.Equal("Yoda", item2.Nombre);

            calc.DemoReferencia(item2);

            Assert.Equal("YodaYoda", item1.Nombre);
            Assert.Equal("YodaYoda", item2.Nombre);

        }


        [Fact]
        public void DemoIgualdad()
        {
            var item1 = new ItemValor();
            item1.Nombre = "UTN";

            var item2 = item1;

            var item3 = new ItemValor();
            item3.Nombre = "UTN";


            Assert.True(item1 == item1);
            Assert.True(item1 == item2);
            Assert.True(item2 == item2);

            Assert.False(item1 == item3);

        }


    }
}