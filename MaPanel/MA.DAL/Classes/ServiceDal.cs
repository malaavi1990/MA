using System.Data.Entity;
using MA.DAL.Interfaces;
using MA.DAL.UnitOfWork;
using MA.Domain;

namespace MA.DAL.Classes
{
    public class ServiceDal : GenericDal<Service>, IServiceDal
    {
        private readonly DataContext _context;
        private readonly DbSet<Service> _services;

        public ServiceDal(DataContext context) : base(context)
        {
            _context = context;
            _services = context.Set<Service>();
        }
    }
}
