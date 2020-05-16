using KursachServer.Models;
using KursachServer.Models.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursachServer.Services.DBServices
{
	public class DBCustomersService : IDBService<Customer>
	{
		public bool Create(Customer entity)
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

		public IList<Customer> GetAll()
		{
			using (var context = new ApplicationContext())
			{
				return context.Customers.Include(c => c.Ticket).ThenInclude(t => t.Service).Include(c => c.Ticket).ThenInclude(t => t.TicketType)
					.Include(c => c.FLat).ThenInclude(f => f.House).ThenInclude(h => h.Street).ThenInclude(s => s.City).ThenInclude(ct => ct.Country).ToList();
			}
		}

		public Customer GetById(int id)
		{
			using (var context = new ApplicationContext())
			{
				return context.Customers.Include(c => c.Ticket).ThenInclude(t => t.Service).Include(c => c.Ticket).ThenInclude(t => t.TicketType)
					.Include(c => c.FLat).ThenInclude(f => f.House).ThenInclude(h => h.Street).ThenInclude(s => s.City).ThenInclude(ct => ct.Country).FirstOrDefault(x => x.Id == id);
			}
		}

		public bool Remove(int id)
		{
			using (var context = new ApplicationContext())
			{
				var deleted = context.Customers.FirstOrDefault(x => x.Id == id);

				if (deleted == null)
				{
					return false;
				}

				var result = context.Customers.Remove(deleted).State;

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

		public bool Update(Customer newEntity)
		{
			if (newEntity == null)
			{
				return false;
			}

			using (var context = new ApplicationContext())
			{
				var prevEntity = context.Customers.FirstOrDefault(x => x.Id == newEntity.Id);

				if (prevEntity == null)
				{
					return false;
				}

				prevEntity.FIO = newEntity.FIO;
				prevEntity.TicketId = newEntity.TicketId;
				prevEntity.FlatId = newEntity.FlatId;

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
