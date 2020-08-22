using System;
using System.Linq.Expressions;

namespace repository_pattern.domain
{
	public interface ISpecification<T>
	{
		bool IsSatisfiedBy(T entity);

		Specification<T> And(ISpecification<T> specification);

		Specification<T> Or(ISpecification<T> specification);

		Expression<Func<T, bool>> SatisfyByCriteria();
	}
}
