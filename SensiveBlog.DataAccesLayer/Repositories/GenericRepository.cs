using SensiveBlog.DataAccesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensiveBlog.DataAccesLayer.Context;

namespace SensiveBlog.DataAccesLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly SensiveContext _context;

        public GenericRepository(SensiveContext context)
        {
            _context = context;
        }

        public void Delete(T id)
        {
            var value = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(value); // Remove the entity from the context
            _context.SaveChanges(); // Save changes to the database
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList(); // Retrieve all entities from the context
        }

        public List<T> GetAll(Func<T, bool> filter)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id); // Find an entity by its ID
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity); // Add a new entity to the context   
            _context.SaveChanges(); // Save changes to the database
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity); // Update an existing entity in the context   
            _context.SaveChanges(); // Save changes to the database
        }
    }
}
