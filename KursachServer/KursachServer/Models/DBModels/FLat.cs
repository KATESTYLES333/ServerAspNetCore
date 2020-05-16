using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursachServer.Models.DBModels
{
	public class FLat
	{
		public int Id { get; set; }
		public string Number { get; set; }
		public int HouseId { get; set; }
		public House House { get; set; } //ForeignKey

		public FLat()
		{
			Customers = new HashSet<Customer>();
		}

		[JsonIgnore]
		public ICollection<Customer> Customers { get; set; }
	}

}
