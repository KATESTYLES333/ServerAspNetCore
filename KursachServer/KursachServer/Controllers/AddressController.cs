using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KursachServer.Services.DBServices;
using KursachServer.Models.DBModels;

namespace KursachServer.Controllers
{
	[Route("api/[controller]")]
	public class AddressController : Controller
	{
		private readonly DBCountriesService counrtiesService;
		private readonly DBCitiesService citiesService;
		private readonly DBStreetsService streetsService;
		private readonly DBHousesService housesService;
		private readonly DBFlatsService flatsService;

		public AddressController(DBCountriesService counrtiesService, DBCitiesService citiesService, DBStreetsService streetsService, DBHousesService housesService, DBFlatsService flatsService)
		{
			this.counrtiesService = counrtiesService;
			this.citiesService = citiesService;
			this.streetsService = streetsService;
			this.housesService = housesService;
			this.flatsService = flatsService;
		}

		[HttpGet("GetCounties")]
		public IList<Country> GetCountries() => counrtiesService.GetAll();

		[HttpGet("GetCities")]
		public IList<City> GetCities() => citiesService.GetAll();

		[HttpGet("GetStreet")]
		public IList<Street> GetStreets() => streetsService.GetAll();

		[HttpGet("GetHouse")]
		public IList<House> GetHouse() => housesService.GetAll();

		[HttpGet("GetFlat")]
		public IList<FLat> GetFlats() => flatsService.GetAll();
	}
}