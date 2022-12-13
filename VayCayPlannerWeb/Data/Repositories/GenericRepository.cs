﻿using Microsoft.EntityFrameworkCore;
using VayCayPlannerWeb.Contracts;

namespace VayCayPlannerWeb.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task AddRangeAsync(List<T> entities)
        {
            await _dbContext.AddRangeAsync(entities);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dbContext.Set<T>().FindAsync(id);
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        //public async Task<T> AddAsync(T entity)
        //{
        //    await _dbContext.AddAsync(entity);
        //    await _dbContext.SaveChangesAsync();
        //    return entity;
        //}

        //Task<T> IGenericRepository<T>.UpdateAsync(T entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
