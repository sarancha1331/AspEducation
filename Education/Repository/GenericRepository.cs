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
        private readonly DbEducationContext context;

        /// <summary>
        /// Инициализация контекста 
        /// </summary>
        public GenericRepository(DbEducationContext dbNotebookContext)
        {
            context = dbNotebookContext;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }


    }

}
