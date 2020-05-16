using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursachServer.Models.DBModels
{
	public class Customer
	{
		public int Id { get; set; }
		public string FIO { get; set; }
		public int TicketId { get; set; }
		public Ticket Ticket { get; set; }
		public int FlatId { get; set; }
		public FLat FLat { get; set; }
	}
}
