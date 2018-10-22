using System.Data.Entity;
using MA.DAL.Interfaces;
using MA.DAL.UnitOfWork;
using MA.Domain;

namespace MA.DAL.Classes
{
    public class SiteSettingDal : GenericDal<SiteSetting>, ISiteSettingDal
    {
        private readonly DataContext _context;
        private readonly DbSet<SiteSetting> _siteSettings;
        public SiteSettingDal(DataContext context) : base(context)
        {
            _context = context;
            _siteSettings = _context.Set<SiteSetting>();
        }
    }
}
