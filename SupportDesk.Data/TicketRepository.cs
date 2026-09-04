namespace SupportDesk.Data;

public class TicketRepository
{
	private readonly List<Ticket> _items = new()
	{
		new Ticket { Id = 1, Subject = "Не работает принтер", Priority = "high"},
		new Ticket { Id = 2, Subject = "ЗНе работает мышь", Priority = "medium"},
		new Ticket { Id = 3, Subject = "Ноутбук не включается после зарядки", Priority = "high"},
		new Ticket { Id = 4, Subject = "Блокировка учетной записи", Priority = "high"}
	};
	
	public List<Ticket> GetAll()
	{
		return _items;
	}
}