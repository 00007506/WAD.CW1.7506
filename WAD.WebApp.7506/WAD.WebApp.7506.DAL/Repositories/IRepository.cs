using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAD.WebApp._7506.DAL.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task UpdateAsync(T emp);
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        bool Exists(int id);
        Task CreateAsync(T emp);
        Task DeleteAsync(int id);
    }
}
