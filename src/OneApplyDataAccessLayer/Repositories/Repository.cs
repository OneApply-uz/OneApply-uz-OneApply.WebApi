using Microsoft.EntityFrameworkCore;
using OneApplyDataAccessLayer.Data;
using OneApplyDataAccessLayer.Entities;
using OneApplyDataAccessLayer.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace OneApplyDataAccessLayer.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    private readonly ApplicationDbContext _dbContext;
    private readonly DbSet<TEntity> _dbSet;

    public Repository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<TEntity>();
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));
        

        await _dbSet.AddAsync(entity);
        await _dbContext.SaveChangesAsync();

        return entity;
    }

    public async Task<TEntity> DeleteAsync(TEntity entity)
    {
        _dbSet.Remove(entity ?? throw new Exception($"Deleteda entity null {entity}"));
        await _dbContext.SaveChangesAsync();

        return entity;
    }

    public  Task<IQueryable<TEntity>> GetAllAsync()
    {
        var list = _dbSet.AsNoTracking()
                         .AsQueryable();

        return Task.FromResult(list);
    }
    public Task<TEntity> GetByIdAsync(int id)
    {
        var entity = _dbSet.FirstOrDefault(c => c.Id == id);
        if (entity == null)
        {
            throw new Exception($"GetByIdAsync entity not found for ID: {id}");
        }
        return Task.FromResult(entity);
    }

    public Task UpdateAsync(TEntity entity)
    {
        _dbSet.Update(entity);
        return Task.CompletedTask;
    }
}
