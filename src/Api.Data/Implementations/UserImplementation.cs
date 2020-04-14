using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repositories.User;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class UserImplementation : BaseRepository<UserEntity>, IUserRepository
    {
        private readonly DbSet<UserEntity> _dataSet;

        public UserImplementation(MyContext context) : base(context)
        {
            _dataSet = _context.Set<UserEntity>();
        }

        public async Task<UserEntity> FindByLogin(string email)
        {
            return await _dataSet.FirstOrDefaultAsync(u => u.Email.Equals(email));
        }
    }
}
