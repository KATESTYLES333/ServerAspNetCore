using KursachServer.Models;
using KursachServer.Models.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursachServer.Services.DBServices
{
	public class DBHousesService : IDBService<House>
	{
		public bool Create(House entity)
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

		public IList<House> GetAll()
		{
			using (var context = new ApplicationContext())
			{
				return context.Houses.ToList();
			}
		}

		public House GetById(int id)
		{
			using (var context = new ApplicationContext())
			{
				return context.Houses.FirstOrDefault(x => x.Id == id);
			}
		}

		public bool Remove(int id)
		{
			using (var context = new ApplicationContext())
			{
				var deleted = context.Houses.FirstOrDefault(x => x.Id == id);

				if (deleted == null)
				{
					return false;
				}

				var result = context.Houses.Remove(deleted).State;

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

		public bool Update(House newEntity)
		{
			if (newEntity == null)
			{
				return false;
			}

			using (var context = new ApplicationContext())
			{
				var prevEntity = context.Houses.FirstOrDefault(x => x.Id == newEntity.Id);

				if (prevEntity == null)
				{
					return false;
				}

				prevEntity.Name = newEntity.Name;
				prevEntity.StreetId = newEntity.StreetId;

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
