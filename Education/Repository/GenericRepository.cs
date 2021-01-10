using Education.App_Data;
using Education.Entities;
using Education.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Repository     //ИЗМЕНИТЬ КОМЕНТЫ
{
    /// <summary>
    /// Нижний уроверь работы с бд через контекст данных
    /// </summary>
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Контекст данных для работы с БД
        /// </summary>
        protected readonly DbEducationContext context;

        /// <summary>
        /// Инициализация контекста 
        /// </summary>
        public GenericRepository(DbEducationContext dbNotebookContext)
        {
            context = dbNotebookContext;
        }

        public virtual async Task<List<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int? id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public virtual async Task DeleteAsync(int? id)
        {
            T entity = await GetByIdAsync(id);
            if (entity != null)
            {
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();
            }
        }

        public virtual async Task AddAsync(T entity)
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public virtual async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

        public IQueryable<T> AsQueryable()
        {
            return context.Set<T>().AsQueryable();
        }

    }

}
