public ActionResult TicketView()
{
    var rand = new Random();
    var client = ClientServices.GetClient();
    var ticket = new TicketModel()
    {
        TicketNumber = rand.Next(100000, 999999),
        TicketDate = DateTime.Now,
        Email = client.Email,
        Name = client.Name,
        Phone = client.Phone
    };

    return View(ticket);
}