using CondoBox.Infrastructure.Data;
using CondoBox.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Infrastructure.Repository;

public class GenericRepository : IGenericRepository
{
    private readonly AppDbContext context;

    public GenericRepository(AppDbContext context)
    {
        this.context = context;
    }
    public void Add<T>(T entity) where T : class
    {
        context.Add(entity);
    }
    public void  Update<T>(T entity) where T : class
    {
        context.Update(entity);
    }

    public void Delete<T>(T entity) where T : class
    {
        context.Remove(entity);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await (context.SaveChangesAsync()) > 0;
    }
}
