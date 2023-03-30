namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void MiEdad()
        {
            var f1 = new DateTime(2012, 8, 20);
            var hoy = DateTime.Today;

            var diferencia = hoy.Subtract(f1);

            var edad = diferencia.Days / 365;

            Assert.Equal(10, edad);
        }



        [Fact]
        public void ProbarDia()
        {
            var hoy = DateTime.Today;

            var dia = hoy.Day;

            Assert.Equal(30, dia);

        }

        [Fact]
        public void ProbarTodayVsNowDate()
        {
            Assert.Equal(DateTime.Today, DateTime.Now.Date);

        }
    }
}