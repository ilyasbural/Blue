﻿namespace Blue.Core
{
	using System;
	using System.Linq.Expressions;

	public interface IRepository<T> where T : class, IEntity, new()
	{
		Task InsertAsync(T Entity);
		Task UpdateAsync(T Entity);
		Task DeleteAsync(T Entity);
		Task<List<T>> SelectAsync(Expression<Func<T, bool>> Predicate);
	}
}