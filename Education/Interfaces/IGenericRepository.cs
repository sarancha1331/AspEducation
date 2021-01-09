using Education.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
    }
}