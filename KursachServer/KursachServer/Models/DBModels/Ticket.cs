using Newtonsoft.Json;
using System.Collections.Generic;

namespace KursachServer.Models.DBModels
{
	public class Ticket
	{
		public int Id { get; set; }
		public decimal Price { get; set; }
		public int AmountTraining { get; set; }
		public int TicketTypeId { get; set; }
		public TicketType TicketType { get; set; }//ForeignKey
		public int ServiceId { get; set; }
		public Service Service { get; set; }//ForeignKey

		public Ticket()
		{
			Customers = new HashSet<Customer>();
		}

		[JsonIgnore]
		public ICollection<Customer> Customers { get; set; }

	}
}
