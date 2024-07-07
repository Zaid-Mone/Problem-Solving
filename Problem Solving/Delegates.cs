using Microsoft.EntityFrameworkCore;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    internal class Delegates
    {
    }




    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }


    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }


    public interface IProductRepository<T>
    {
        public Tuple<List<Product>, int> SearchWithPagination<TProperty>(
            int skip,
            int take,
            string order,
            Expression<Func<Product, bool>> predicate,
            Expression<Func<Product, TProperty>> orderByProperty,
            params Expression<Func<Product, object>>[] includes);



    }


    public class ProductRepository : IProductRepository<Product>
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }


        public Tuple<List<Product>, int> SearchWithPagination<TProperty>(
            int skip,
            int take,
            string order,
            Expression<Func<Product, bool>> predicate,
            Expression<Func<Product, TProperty>> orderByProperty,
            params Expression<Func<Product, object>>[] includes)
        {
            try
            {
                var records = _context.Products.Where(predicate);
                int totalCount = records == null ? 0 : records.Count();
                IQueryable<Product> query = records;
                if (string.IsNullOrEmpty(order) || order.Equals("ASC", StringComparison.CurrentCultureIgnoreCase))
                    //query = records.OrderBy(x => x.ID).Skip(skip).Take(take).AsNoTracking();
                    query = query.OrderBy(orderByProperty);
                else
                    //query = records.OrderByDescending(x => x.ID).Skip(skip).Take(take).AsNoTracking();
                    query = query.OrderByDescending(orderByProperty);

                query = query.Skip(skip).Take(take).AsNoTracking();
                #region Include Area 1
                foreach (var includeProperty in includes)
                {
                    query = query.Include(includeProperty);
                }
                return Tuple.Create(query.AsNoTracking().ToList(), totalCount);
               #endregion

                #region Include Area 2
                return Tuple.Create(includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).ToList(), totalCount);
                #endregion

            }
            catch (Exception)
            {
                return Tuple.Create(new List<Product>(), 0);
            }
        }
    }

}
