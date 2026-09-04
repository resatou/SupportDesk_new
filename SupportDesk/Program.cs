using SupportDesk.Logic;
var service = new TicketService();
Console.WriteLine("Отобранные записи: ");
foreach (var item in service.GetImportant())
{
    Console.WriteLine($"{item.Id}: {item.Subject}");
}