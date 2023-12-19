﻿namespace OneApplyDataAccessLayer.Interfaces;

public  interface IRepository<TEntity> where TEntity : class
{ 
    Task<IQueryable<TEntity>> GetAllAsync();
    Task<TEntity> GetByIdAsync(int id);
    Task<TEntity> AddAsync(TEntity entity);
    void UpdateAsync(TEntity entity);
    Task<TEntity> DeleteAsync(int id);
}
