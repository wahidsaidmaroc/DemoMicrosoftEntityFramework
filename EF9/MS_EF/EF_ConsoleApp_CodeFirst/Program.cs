

using EF_ConsoleApp_CodeFirst.Data;
using EF_ConsoleApp_CodeFirst.Entites;



using (var context = new MyDbContext())
{

    Categorie categorie = new Categorie
    {
        Nom = "TV"
    };



    context.Categories.Add(categorie);
    context.SaveChanges();
}




using (var context = new MyDbContext())
{
    var list = context.Categories.ToList();

    foreach (var item in list)
    {
        Console.WriteLine($"id = {item.Id}   Categorie = {item.Nom}");
    }


}




Console.WriteLine();