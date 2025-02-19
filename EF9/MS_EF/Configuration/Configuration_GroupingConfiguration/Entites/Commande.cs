namespace Configuration_GroupingConfiguration.Entites;

public class Commande
{
    public int Id { get; set; }
    public DateTime dateTime { get; set; }
    public decimal totalHT { get; set; }
    public int ClientId { get; set; }
    public Client Client { get; set; } = new Client();
    public string Description { get; set; } = string.Empty;

}
