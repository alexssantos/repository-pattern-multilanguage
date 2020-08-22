using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace repository_pattern.domain
{
	public interface IRepositoryBase<T> where T : class
	{
		Task<IList<T>> GetAll();
		Task<T> GetById(object id);
		Task Save(T obj);
		Task Update(object id, T obj);
		Task Delete(object id);
		Task<T> GetOneByCriteria(Expression<Func<T, bool>> expr);
		Task<IList<T>> GetAllByCriteria(Expression<Func<T, bool>> expr);
	}
}
