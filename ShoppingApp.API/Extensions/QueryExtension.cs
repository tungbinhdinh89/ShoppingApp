﻿using Microsoft.EntityFrameworkCore;
using ShoppingApp.API.Common;
using System.Linq.Expressions;

namespace ShoppingApp.API.Extensions
{
    public static class QueryExtension
    {
        public static IQueryable<T> Paging<T>(this IQueryable<T> query, int current = 0, int take = 100)
        {
            return query.Skip(current * take).Take(take);
        }

        public static async Task<Paging<TModel>> ToPagingAsync<TEntity, TModel>(
            this IQueryable<TEntity> query,
            Expression<Func<TEntity, TModel>> selector,
            int current = 0,
            int take = 100)
        {
            var items = await query.Paging(current, take).Select(selector).ToArrayAsync();
            var count = await query.CountAsync();

            return new Paging<TModel>(items, count, current);
        }

        public static IOrderedQueryable<T> Sort<T>(this IQueryable<T> query, Expression<Func<T, object>> orderBy, bool asc = true)
        {
            if (asc)
            {
                return query.OrderBy(orderBy);
            }
            else
            {
                return query.OrderByDescending(orderBy);
            }
        }
    }
}
