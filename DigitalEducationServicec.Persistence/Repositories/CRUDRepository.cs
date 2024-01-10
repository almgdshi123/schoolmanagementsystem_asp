
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEducationServicec.Persistence.Repositories
{
    //public class CRUDRepository<T> : ICRUDRepository<T> where T : class
    //{
    //    private readonly DbContext _context;

    //    public CRUDRepository(DbContext context)
    //    {
    //        _context = context;
    //    }

    //    public void Create(T entity)
    //    {
    //        _context.Set<T>().Add(entity);
    //        _context.SaveChanges();
    //    }

    //    public void Update(T entity)
    //    {
    //        _context.Set<T>().Update(entity);
    //        _context.SaveChanges();
    //    }

    //    public void Delete(T entity)
    //    {
    //        _context.Set<T>().Remove(entity);
    //        _context.SaveChanges();
    //    }

    //    public T GetById(long id)
    //    {
    //        return _context.Set<T>().Find(id);
    //    }

    //    public IEnumerable<T> GetAll()
    //    {
    //        return _context.Set<T>().ToList();
    //    }
    //}
}
