using System.Xml.Serialization;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEvento.Domain;
using ProEvento.Persistence.Contratos;
using ProEvento.Persistence.Contextos;

namespace ProEvento.Persistence
{
    public class GeralPersist : IGeralPersist
    {
        private readonly ProEventoContext _context;
        public GeralPersist(ProEventoContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeleteRange<T>(T[] entityArray) where T : class
        {
            _context.RemoveRange(entityArray);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

    }
}

