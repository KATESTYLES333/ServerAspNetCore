using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KursachServer.Models.DBModels;
using KursachServer.Services.DBServices;

namespace KursachServer.Controllers
{
	[Route("api/[controller]")]
	public class TicketsController : Controller
	{
		private readonly DBTicketsService service;
		public TicketsController(DBTicketsService service)
		{
			this.service = service;
		}

		[HttpGet("get/{id}")]
		public Ticket GetService(int id)
		{
			return service.GetById(id);
		}

		[HttpGet("create")]
		public void Create([FromBody]Ticket ticket)
		{
			this.service.Create(ticket);
		}

		[HttpGet("update")]
		public void Update([FromBody]Ticket ticket)
		{
			this.service.Update(ticket);
		}

		[HttpGet("getAll")]
		public IList<Ticket> GetAllServices()
		{
			return service.GetAll();
		}
	}
}