using KursachServer.Models;
using KursachServer.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KursachServer.Services.DBServices;

namespace KursachServer.Services
{
	public class ServicesService
	{
		private readonly DBServicesService service;

		public ServicesService(DBServicesService service)
		{
			this.service = service;
		}

		public Service GetService(int id)
		{
			return service.GetById(id);
		}

		public List<Service> GetAllServices()
		{
			return service.GetAll().ToList();
		}
	}
}
