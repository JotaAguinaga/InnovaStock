using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ClasesInnovaStock.Data;

namespace ClasesInnovaStock.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AplicationDbContext _context;

        public GenericRepository()
        {
            _context = new AplicationDbContext();
            _context.Database.EnsureCreated();
        }

        public void Agregar(T entidad)
        {
            
            _context.Set<T>().Add(entidad);
            _context.SaveChanges(); 
        }

        public List<T> ObtenerTodos()
        {
            return _context.Set<T>().ToList(); // Aquí se ejecuta el SELECT[cite: 6]
        }

        public T ObtenerPorId(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Modificar(T entidad)
        {
            _context.Set<T>().Update(entidad);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var entidad = ObtenerPorId(id);
            if (entidad != null)
            {
                _context.Set<T>().Remove(entidad);
                _context.SaveChanges();
            }
        }
    }
}