namespace PPT.Entidades
{
    public class Papel : ElementoBase
    {
        public Papel()
        {
            Tipo = "Papel";
        }

        public override string ResultadoParaPiedra()
        {
            return "pierde";
        }

        public override string ResultadoParaPapel()
        {
            return "empata";
        }

        public override string ResultadoParaTijera()
        {
            return "gana";
        }
    }
}
