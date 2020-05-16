using Newtonsoft.Json;
using System.Collections.Generic;

namespace KursachServer.Models.DBModels
{
	public class Country
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public Country()
		{
			Cities = new HashSet<City>();
		}

		[JsonIgnore]
		public ICollection<City> Cities { get; set; }
	}
}
