namespace TestProject1
{
    public class FormatTest
    {
        [Fact]
        public void Formatear()
        {
            var f1 = new DateTime(2012, 8, 20, 17, 52, 0, 0);


            Assert.Equal("20/08/2012", f1.ToShortDateString());
            Assert.Equal("lunes, 20 de agosto de 2012", f1.ToLongDateString());

            Assert.Equal("lunes", f1.ToString("dddd"));
            Assert.Equal(DayOfWeek.Monday, f1.DayOfWeek);

            Assert.Equal("lun. 20 de agosto de 2012 a las 17:52", 
                f1.ToString("ddd dd \\de MMMM \\de yyyy a la\\s HH:mm"));

        }

        [Fact]
        public void FormatearPersonalizado()
        {
            var f1 = new DateTime(2012, 8, 20, 17, 52, 0, 0);

            //Assert.Equal("lun. 20 de agosto de 2012 a las 17:52", f1.ToString("...."));

            Assert.Equal("lun. 20 de agosto de 2012 a las 17:52",
                         $"{f1.ToString("ddd")} {f1.ToString("dd")} de {f1.ToString("MMMM")} de {f1.ToString("yyyy")} a las {f1.ToString("HH:mm")}");

        }

    }
}