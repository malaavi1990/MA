using System.Data.Entity;
using MA.DAL.Interfaces;
using MA.DAL.UnitOfWork;
using MA.Domain;

namespace MA.DAL.Classes
{
    public class UserDal : GenericDal<User>, IUserDal
    {
        private readonly DataContext _context;
        private readonly DbSet<User> _users;
        public UserDal(DataContext context) : base(context)
        {
            _context = context;
            _users = context.Set<User>();
        }
    }
}
