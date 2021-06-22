using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAD.WebApp._7506.DAL.Repositories
{
    public class BaseRepository
    {
        protected readonly CarRentDbContext _dbContext;

        protected BaseRepository(CarRentDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
