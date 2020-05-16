using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursachServer.Models.DBModels
{
	public class House
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int StreetId { get; set; }
		public Street Street { get; set; } //ForeignKey

		public House()
		{
			Flats = new HashSet<FLat>();
		}

		[JsonIgnore]
		public ICollection<FLat> Flats { get; set; }
	}
}
