using Dapr.Client;

#region Counter Example
//const string storeName = "statestore";
//const string key = "counter";
//var daprClient = new DaprClientBuilder().Build();
//var counter = await daprClient.GetStateAsync<int>(storeName, key);
//while (true)
//{
//    Console.WriteLine($"Counter = {counter++}");
//    await daprClient.SaveStateAsync(storeName, key, counter);
//    await Task.Delay(1000);
//}
#endregion


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();