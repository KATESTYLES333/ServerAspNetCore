using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KursachServer.Models.DBModels;
using System.ComponentModel.DataAnnotations.Schema;
using KursachServer.Services.DBServices;

namespace KursachServer.Controllers
{
	[Route("api/[controller]")]
	public class CustomersController : Controller
	{
		private readonly DBCustomersService service;

		public CustomersController(DBCustomersService service)
		{
			this.service = service;
		}
		//static readonly List<Customer> datacustomers;

		[HttpGet("create")]
		public void Create([FromBody]Customer customer)
		{
			service.Create(customer);
		}

		[HttpGet("update")]
		public void Update([FromBody]Customer customer)
		{
			service.Update(customer);
		}

		[HttpGet("getAll")]
		public IList<Customer> GetAll()
		{
			return service.GetAll();
		}

		[HttpGet("get/{id}")]
		public Customer GetCustomer(int id)
		{
			return service.GetById(id);
		}

	}
}