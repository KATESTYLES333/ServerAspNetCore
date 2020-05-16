using KursachServer.Models;
using KursachServer.Models.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursachServer.Services.DBServices
{
	public class DBFlatsService : IDBService<FLat>
	{
		public bool Create(FLat entity)
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

		public IList<FLat> GetAll()
		{
			using (var context = new ApplicationContext())
			{
				return context.Flats.ToList();
			}
		}

		public FLat GetById(int id)
		{
			using (var context = new ApplicationContext())
			{
				return context.Flats.FirstOrDefault(x => x.Id == id);
			}
		}

		public bool Remove(int id)
		{
			using (var context = new ApplicationContext())
			{
				var deleted = context.Flats.FirstOrDefault(x => x.Id == id);

				if (deleted == null)
				{
					return false;
				}

				var result = context.Flats.Remove(deleted).State;

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

		public bool Update(FLat newEntity)
		{
			if (newEntity == null)
			{
				return false;
			}

			using (var context = new ApplicationContext())
			{
				var prevEntity = context.Flats.FirstOrDefault(x => x.Id == newEntity.Id);

				if (prevEntity == null)
				{
					return false;
				}

				prevEntity.Number = newEntity.Number;
				prevEntity.HouseId = newEntity.HouseId;

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
