// See https://aka.ms/new-console-template for more information
Console.WriteLine("WebApiClientFromConsole!");

//HttpClientFactory
//https://learn.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests
Console.WriteLine("...");
Console.ReadKey();


using (var client = new HttpClient()) {

    var response = await client.GetAsync("https://localhost:7044/api/emails");

	if (response.IsSuccessStatusCode)
	{
		var content = await response.Content.ReadAsStringAsync();
        Console.WriteLine(content);
	}
	else
	{
        Console.WriteLine($"ERROR: StatusCode: {response.StatusCode}" );
    }
}

Console.ReadKey();


