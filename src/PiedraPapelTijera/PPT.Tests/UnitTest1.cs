using PPT.Entidades;
using AliasDeTijera = PPT.Entidades.Tijera;

namespace PPT.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void DebeGanarLaPiedraALaTijera()
        {
            var p1 = new PPT.Entidades.Piedra();
            var t1 = new AliasDeTijera();

            var resultado = p1.ResultadoCon(t1);

            Assert.Equal("gana", resultado);
        }


        [Fact]
        public void DebePerderLaPiedraAlPapel()
        {
            var p1 = new PPT.Entidades.Piedra();
            var papel1 = new Papel();

            var resultado = p1.ResultadoCon(papel1);

            Assert.Equal("pierde", resultado);
        }

        [Fact]
        public void DebeEmpatarPiedracontraPiedra()
        {
            var p1 = new PPT.Entidades.Piedra();
            var p2 = new Piedra();

            var resultado = p1.ResultadoCon(p2);

            Assert.Equal("empata", resultado);
        }
    }
}