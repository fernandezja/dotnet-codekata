// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;

Console.WriteLine("ADO.NET");


string connectionString =
            "Persist Security Info=True;Initial Catalog=Demo;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";


string querySql = "SELECT MovieId, Name, ImageUrl FROM dbo.Movie";


//int paramValue = 5;


//var conn2 = new SqlConnection();
//var connBuilder = new SqlConnectionStringBuilder();
//connBuilder.DataSource = ".";
//connBuilder.InitialCatalog = "Demo";
//connBuilder.ConnectionString


using (var connection =
            new SqlConnection(connectionString))
{
    
    var command = new SqlCommand(querySql, connection);
    //command.Parameters.AddWithValue("@paramName", paramValue);

   
    try
    {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            var movieId = reader.GetInt32(0);
            var movieName = reader[1].ToString();

            Console.WriteLine("\t{0}\t{1}\t{2}",
                reader[0], 
                reader[1], 
                reader[2]);
        }

        reader.Close();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"[ERROR] {ex.Message}");
    }
}

Console.ReadLine();