using System.Data.Entity;
using MA.DAL.Interfaces;
using MA.DAL.UnitOfWork;
using MA.Domain;

namespace MA.DAL.Classes
{
    public class TeamDal : GenericDal<Team>, ITeamDal
    {
        private readonly DataContext _context;
        private readonly DbSet<Team> _teams;

        public TeamDal(DataContext context) : base(context)
        {
            _context = context;
            _teams = context.Set<Team>();
        }
    }
}
