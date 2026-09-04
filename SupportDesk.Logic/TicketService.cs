using SupportDesk.Data;

namespace SupportDesk.Logic;

public class TicketService
{
	private readonly TicketRepository _repository = new();
	
	public List<Ticket> GetImportant()
	{
		return _repository.GetAll().Where(item => item.Priority == "high").ToList();
		
	}
}

