// See https://aka.ms/new-console-template for more information
using DataBaseFirst_Simple.Context;
using DataBaseFirst_Simple.Entites;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

var build = new DbContextOptionsBuilder<AppMyDbContext>()
    .UseSqlServer(@"Data Source=Said\SQLEXPRESS;Initial Catalog=DemoEF9_DBF;Integrated Security=True;Trust Server Certificate=True")
    .Options;


var appMyDbContext = new AppMyDbContext(build);

for (int i = 2; i < 10; i++)
{
    var client1 = new TClient { Id = i, Client = $"Client {i}", Adresse = $"Adresse Client  {i}" };
    appMyDbContext.TClients.Add(client1);
    appMyDbContext.SaveChanges();

}


var clients = appMyDbContext.TClients.ToList();

foreach (var client in clients)
{
    Console.WriteLine(client.Id);
}


Console.ReadKey(); 


