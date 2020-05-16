using System.Collections.Generic;

namespace KursachServer.Services.DBServices
{
	public interface IDBService<T>
	{
		bool Create(T entity);

		bool Update(T newEntity);

		bool Remove(int id);

		T GetById(int id);

		IList<T> GetAll();
	}
}
