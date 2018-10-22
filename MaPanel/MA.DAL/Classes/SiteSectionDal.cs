using System.Data.Entity;
using MA.DAL.Interfaces;
using MA.DAL.UnitOfWork;
using MA.Domain;

namespace MA.DAL.Classes
{
    public class SiteSectionDal : GenericDal<SiteSection>, ISiteSectionDal
    {
        private readonly DataContext _context;
        private readonly DbSet<SiteSection> _siteSections;
        public SiteSectionDal(DataContext context) : base(context)
        {
            _context = context;
            _siteSections = context.Set<SiteSection>();
        }
    }
}
