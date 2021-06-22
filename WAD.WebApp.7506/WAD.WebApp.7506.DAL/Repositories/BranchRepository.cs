using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAD.WebApp._7506.DAL.DTO;

namespace WAD.WebApp._7506.DAL.Repositories
{
    public class BranchRepository : BaseRepository, IRepository<Branch>
    {
        public BranchRepository(CarRentDbContext context)
            : base(context)
        {
        }

        public Task CreateAsync(Branch branch)
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

        public Task<List<Branch>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Branch> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Branch branch)
        {
            throw new NotImplementedException();
        }
    }
}
