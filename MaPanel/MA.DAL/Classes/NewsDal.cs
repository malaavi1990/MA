using System.Data.Entity;
using MA.DAL.Interfaces;
using MA.DAL.UnitOfWork;
using MA.Domain;

namespace MA.DAL.Classes
{
    public class NewsDal : GenericDal<News>, INewsDal
    {
        private readonly DataContext _context;
        private readonly DbSet<News> _newses;

        public NewsDal(DataContext context) : base(context)
        {
            _context = context;
            _newses = context.Set<News>();
        }
    }
}
