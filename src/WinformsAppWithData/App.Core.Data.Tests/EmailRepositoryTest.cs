namespace App.Core.Data.Tests
{
    public class EmailRepositoryTest
    {
        [Fact]
        public void BuscarTest()
        {

            var repo = new EmailRepository();
            var emails = repo.Buscar("Hola");

            Assert.NotNull(emails);
            Assert.Equal(100, emails.Count);

        }
    }
}