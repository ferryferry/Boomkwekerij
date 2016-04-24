using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomkwekerij.Controllers.Interfaces
{
	public interface IContext<T>
	{
		T Insert(T entity);

		T Get(int id);

		List<T> GetAll();

		bool Remove(T entity);

		bool Update(T entity);
	}
}
