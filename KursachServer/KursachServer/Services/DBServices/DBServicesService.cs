using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KursachServer.Models.DBModels;
using KursachServer.Models;
using Microsoft.EntityFrameworkCore;

namespace KursachServer.Services.DBServices
{
	public class DBServicesService : IDBService<Service>
	{
		public bool Create(Service entity)
		{
			if (entity == null)
			{
				return false;
			}

			using (var context = new ApplicationContext())
			{
				var state = context.Add(entity).State;

				if (state != EntityState.Added)
				{
					return false;
				}

				try
				{
					context.SaveChanges();

				}
				catch
				{
					return false;
				}

				return true;
			}
		}


		public IList<Service> GetAll()
		{
			using (var context = new ApplicationContext())
			{
				return context.Services.ToList();
			}
		}

		public Service GetById(int id)
		{
			using (var context = new ApplicationContext())
			{
				return context.Services.FirstOrDefault(x => x.Id == id);
			}

		}

		public bool Remove(int id)
		{
			using (var context = new ApplicationContext())
			{
				var deleted = context.Services.FirstOrDefault(x => x.Id == id);

				if (deleted == null)
				{
					return false;
				}

				var result = context.Services.Remove(deleted).State;

				if (result != EntityState.Deleted)
				{
					return false;
				}

				try
				{
					context.SaveChanges();
				}
				catch
				{
					return false;
				}

				return true;
			}
		}

		public bool Update(Service newEntity)
		{
			if (newEntity == null)
			{
				return false;
			}

			using (var context = new ApplicationContext())
			{
				var prevEntity = context.Services.FirstOrDefault(x => x.Id == newEntity.Id);

				if (prevEntity == null)
				{
					return false;
				}

				prevEntity.Name = newEntity.Name;
				prevEntity.Price = newEntity.Price;

				try
				{
					context.SaveChanges();
				}
				catch
				{
					return false;
				}

				return true;
			}
		}
	}
}
