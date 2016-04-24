using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomkwekerij.Controllers.Repositories
{
	public interface IRepository<T>
	{
		T Insert(T entity);
		T Get(int id);
		List<T> GetAll();
		bool Remove(T entity);
		bool Update(T entity);
	}
}
