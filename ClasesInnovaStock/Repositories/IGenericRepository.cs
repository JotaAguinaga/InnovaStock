using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ClasesInnovaStock.Data;

namespace ClasesInnovaStock.Repositories
{
   
    public interface IGenericRepository<T> where T : class
    {
        void Agregar(T entidad);
        List<T> ObtenerTodos();

        T ObtenerPorId(int id);
        void Modificar(T entidad);
        void Eliminar(int id);
    }
}