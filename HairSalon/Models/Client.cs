namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public int ClientPhone { get; set; }
    public int StylistId { get; set; }
    public virtual Client Client { get; set; }
  }
}