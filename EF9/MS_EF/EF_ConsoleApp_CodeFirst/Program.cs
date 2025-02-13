using EF_ConsoleApp_CodeFirst.Data;
using EF_ConsoleApp_CodeFirst.Entites;



//La création
using (var context = new MyDbContext())
{
    Categorie categorie = new Categorie
    {
        Nom = "TV"
    };
    context.Categories.Add(categorie);
    context.SaveChanges();
}



//Pour voire la liste des catégories
using (var context = new MyDbContext())
{
    var list = context.Categories.ToList();

    foreach (var item in list)
    {
        Console.WriteLine($"id = {item.Id}   Categorie = {item.Nom}");
    }


}


//Supperimer un element dans la table
using (var context = new MyDbContext())
{

    var categorie = context.Categories.Where(a => a.Id == 1).FirstOrDefault();
    var categorieByFind = context.Categories.Find(1);

    if (categorie != null)
    {
        context.Categories.Remove(categorie);
        context.SaveChanges();
    }
}

//pour la modifications
using (var context = new MyDbContext())
{
    var categorie = context.Categories.Where(a => a.Id == 2).FirstOrDefault();
    if (categorie != null)
    {
        categorie.Nom = "Smart TV";

        context.SaveChanges();
    }
}



using (var context = new MyDbContext())
{
    using(var tr = context.Database.BeginTransaction())
    {
        try
        {

            for (int i = 0; i < 10; i++)
            {
                Categorie categorie = new Categorie
                {
                    Nom = "Categorie " + i.ToString()
                };
                context.Categories.Add(categorie);
                context.SaveChanges();
            }


            tr.Commit();
        }
        catch (Exception ex)
        {
            tr.Rollback();
            Console.WriteLine(ex.Message);
        }
    }
}




Console.WriteLine();