using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAD.WebApp._7506.DAL.DTO;

namespace WAD.WebApp._7506.DAL.Repositories
{
    public class EmployeeRepository : BaseRepository, IRepository<Employee>
    {
        public EmployeeRepository(CarRentDbContext context)
            : base(context)
        {
        }
        public Task CreateAsync(Employee emp)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Employee emp)
        {
            throw new NotImplementedException();
        }
    }
}
