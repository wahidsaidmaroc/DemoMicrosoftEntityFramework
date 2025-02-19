namespace Configuration_FluentAPI.Entites;

public class Client
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public List<Commande> Commandes { get; set; }
}