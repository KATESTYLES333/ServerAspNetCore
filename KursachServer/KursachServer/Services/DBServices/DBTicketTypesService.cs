using KursachServer.Models;
using KursachServer.Models.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursachServer.Services.DBServices
{
	public class DBTicketTypesService : IDBService<TicketType>
	{
		public bool Create(TicketType entity)
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

		public IList<TicketType> GetAll()
		{
			using (var context = new ApplicationContext())
			{
				return context.TicketTypes.ToList();
			}
		}

		public TicketType GetById(int id)
		{
			using (var context = new ApplicationContext())
			{
				return context.TicketTypes.FirstOrDefault(x => x.Id == id);
			}
		}

		public bool Remove(int id)
		{
			using (var context = new ApplicationContext())
			{
				var deleted = context.TicketTypes.FirstOrDefault(x => x.Id == id);

				if (deleted == null)
				{
					return false;
				}

				var result = context.TicketTypes.Remove(deleted).State;

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

		public bool Update(TicketType newEntity)
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
