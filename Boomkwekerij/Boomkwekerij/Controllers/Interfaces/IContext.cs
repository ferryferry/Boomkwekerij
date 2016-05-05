using System.Collections.ObjectModel;

namespace Boomkwekerij.Controllers.Interfaces
{
	public interface IContext<T>
	{
		T Insert(T entity);

		T Get(int id);

		ObservableCollection<T> GetAll();

		bool Remove(T entity);

		bool Update(T entity);
	}
}
