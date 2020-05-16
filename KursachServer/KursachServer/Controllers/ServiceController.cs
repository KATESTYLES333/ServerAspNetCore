using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KursachServer.Services;
using KursachServer.Models.DBModels;
using KursachServer.Services.DBServices;

namespace KursachServer.Controllers
{
	[Route("api/[controller]")]
	public class ServiceController : Controller
	{
		private readonly DBServicesService service;
		public ServiceController(DBServicesService service)
		{
			this.service = service;
		}

		[HttpGet("get/{id}")]
		public Service GetService(int id)
		{
			return service.GetById(id);
		}

		[HttpGet("create")]
		public void Create([FromBody]Service service)
		{
			this.service.Create(service);
		}

		[HttpGet("update")]
		public void Update([FromBody]Service service)
		{
			this.service.Update(service);
		}

		[HttpGet("getAll")]
		public IList<Service> GetAllServices()
		{
			return service.GetAll();
		}
	}
}