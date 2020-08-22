using Microsoft.EntityFrameworkCore;
using repository_pattern.domain;
using repository_pattern.repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace repository_pattern.repository.Repository
{
	public class RepositoryBase<T> : IRepositoryBase<T> where T : class
	{
		private DbSet<T> Query { get; set; }
		private MyContext Context { get; set; }



		public RepositoryBase(MyContext context)
		{
			Context = context;
			Query = context.Set<T>();
		}



		public async Task<IList<T>> GetAll()
		{
			return await Query.ToListAsync();
		}

		public async Task<T> GetById(object id)
		{
			return await Query.FindAsync();
		}

		public Task Save(T obj)
		{
			Query.Add(obj);
			Context.SaveChanges();
			return Task.CompletedTask;
		}

		public async Task Update(object id, T obj)
		{
			var objOld = await this.Query.FindAsync(id);

			objOld = obj;

			this.Query.Add(objOld);
			this.Context.Entry(objOld).State = EntityState.Modified;

			this.Context.SaveChanges();
		}

		public async Task Delete(object id)
		{
			var obj = await Query.FindAsync(id);
			this.Query.Remove(obj);
			this.Context.SaveChanges();
		}

		public async Task<IList<T>> GetAllByCriteria(Expression<Func<T, bool>> expr)
		{
			return await Query.Where(expr).ToListAsync();
		}

		public Task<T> GetOneByCriteria(Expression<Func<T, bool>> expr)
		{
			return Query.FirstOrDefaultAsync(expr);
		}
	}
}
