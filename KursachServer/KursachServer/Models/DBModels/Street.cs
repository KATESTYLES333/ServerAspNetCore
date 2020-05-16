using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursachServer.Models.DBModels
{
	public class Street
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int CityId { get; set; }
		public City City { get; set; } //ForeignKey

		public Street()
		{
			Houses = new HashSet<House>();
		}

		[JsonIgnore]
		public ICollection<House> Houses { get; set; }
	}
}
