namespace SupportDesk.Data;
public class Ticket
{
    public int Id { get; set; }
    public string Subject { get; set; } = "";
    public string Priority { get; set; } = "";
}