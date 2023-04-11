namespace FileManager.Tests
{
    public class FileDirectoryTests
    {
        [Fact]
        public void CrearUnArchivo()
        {
            var writer = new System.IO.StreamWriter(
                                    path:"demo.nadadenada",
                                    append: false);

            writer.Write("Demo demo");

            writer.Close();

            Assert.True(true);
        }



        [Fact]
        public void LeerUnArchivo()
        {
            var reader = new System.IO.StreamReader(
                                    path: "demo.nadadenada");

            var contenido = reader.ReadToEnd();

            reader.Close();

            Assert.Equal("Demo demo", contenido);


            Assert.True(true);
        }


        [Fact]
        public void EscribitUnArchivoAppendAllText()
        {
            File.AppendAllText(path: "demo-2.nadadenada", "Otro Archivo");


            Assert.True(true);
        }


        [Fact]
        public void DirectorioCrear()
        {
            Directory.CreateDirectory("Starwars");

            //d.CreateSubdirectory("Galaxy")
                        

            Assert.True(true);
        }



        [Fact]
        public void DirectorioEliminar()
        {

            var d = new DirectoryInfo("Starwars");

            d.Delete();

            //d.CreateSubdirectory("Galaxy")


            Assert.True(true);
        }

    }
}