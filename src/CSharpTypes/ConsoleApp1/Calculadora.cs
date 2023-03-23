namespace ConsoleApp1
{
    public class Calculadora
    {
        public int Sumar(int x, int y)
        {
            return x+y;
        }

        public void DemoValor(int x)
        {
            x = x * 2;
            return;
        }

        public void DemoReferencia(ref string cadena1)
        {
            cadena1 = cadena1 + cadena1;
            return;
        }

        public void DemoReferencia(ItemValor item)
        {
            item.Nombre = item.Nombre + item.Nombre;
            return;
        }
    }
}
