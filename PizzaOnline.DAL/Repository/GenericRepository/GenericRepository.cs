﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PizzaOnline.DAL.Repository.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly AplicationContext _context;
        private DbSet<TEntity> _dbSet;
        public GenericRepository(AplicationContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression)
        {
            return this._context.Set<TEntity>()
                .Where(expression)
                .AsNoTracking();
        }
        public IQueryable<TEntity> FindAll()
        {
            return _context.Set<TEntity>()
                .AsNoTracking();
        }
        public async Task<IEnumerable<TEntity>> GetAllAsyn()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<TEntity> GetByIdAsyn(int id)  
        {
            return await _dbSet.FindAsync(id);
        }
        public  async Task<TEntity> InsertAsyn(TEntity obj)
        {
            _dbSet.Add(obj);
            await _context.SaveChangesAsync();
            return obj;
        }
        public async Task<int> UpdateAsyn(TEntity obj)
        {
            if (obj == null)
                return 204; 

            _context.Entry(obj).State = EntityState.Modified;

            return await _context.SaveChangesAsync();                              
        }
        public async Task DeleteAsyn(int id)
        {
            await _context.SaveChangesAsync();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
