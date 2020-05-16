using Newtonsoft.Json;
using System.Collections.Generic;

namespace KursachServer.Models.DBModels
{
	public class TicketType
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }

		public TicketType()
		{
			Tickets = new HashSet<Ticket>();
		}

		[JsonIgnore]
		public ICollection<Ticket> Tickets { get; set; }

	}
}
