
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FileManager.Tests
{
    public class SerializationTests
    {

        //[Fact]
        //public void SerializarEnJsonUnDirectorio()
        //{
        //    //Directory.CreateDirectory("Starwars");

        //    var d = new DirectoryInfo("Starwars");
        //    d.Create();

        //    var options = new JsonSerializerOptions()
        //    {
        //        ReferenceHandler = ReferenceHandler.Preserve
        //    };

        //    var dJson = JsonSerializer.Serialize(d, options: options);

        //    Assert.True(true);
        //}


      [Fact]
      public void SerializarEnJsonUnObjetoAnonimo()
       {
            var directorio = new
            {
                Name = "Starwars",
                Date = new DateTime(2023, 4, 11, 16, 35, 0)
            };

            var dataJson = JsonSerializer.Serialize(directorio);

            Assert.Equal("Starwars", directorio.Name);
            Assert.Equal("{\"Name\":\"Starwars\",\"Date\":\"2023-04-11T16:35:00\"}", dataJson);
        }



    }
}